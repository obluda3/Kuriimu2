﻿using System;
using System.IO;
using Kompression.IO;
using Kompression.PatternMatch;

namespace Kompression.Implementations.Decoders
{
    public class BackwardLz77Decoder : IPatternMatchDecoder
    {
        private readonly ByteOrder _byteOrder;
        private CircularBuffer _circularBuffer;

        public BackwardLz77Decoder(ByteOrder byteOrder)
        {
            _byteOrder = byteOrder;
        }

        public void Decode(Stream input, Stream output)
        {
            var buffer = new byte[4];

            using (var inputReverseStream = new ReverseStream(input))
            using (var outputReverseStream = new ReverseStream(output))
            {
                input.Position = input.Length - 8;

                input.Read(buffer, 0, 4);
                var bufferTopAndBottom = _byteOrder == ByteOrder.LittleEndian ? GetLittleEndian(buffer) : GetBigEndian(buffer);

                input.Read(buffer, 0, 4);
                var originalBottom = _byteOrder == ByteOrder.LittleEndian ? GetLittleEndian(buffer) : GetBigEndian(buffer);

                var sourcePosition = input.Length - (bufferTopAndBottom >> 24);
                var destinationPosition = input.Length + originalBottom;
                var endPosition = input.Length - (bufferTopAndBottom & 0xFFFFFF);

                inputReverseStream.Position = sourcePosition;
                outputReverseStream.Position = destinationPosition;
                ReadCompressedData(inputReverseStream, outputReverseStream, endPosition);
            }
        }

        private void ReadCompressedData(Stream input, Stream output, long endPosition)
        {
            _circularBuffer = new CircularBuffer(0x1002);

            var codeBlock = input.ReadByte();
            var codeBlockPosition = 8;
            while (input.Position - endPosition > 0)
            {
                if (codeBlockPosition == 0)
                {
                    codeBlock = input.ReadByte();
                    codeBlockPosition = 8;
                }

                var flag = (codeBlock >> --codeBlockPosition) & 0x1;
                if (flag == 0)
                    HandleUncompressedBlock(input, output);
                else
                    HandleCompressedBlock(input, output);
            }
        }

        private void HandleUncompressedBlock(Stream input, Stream output)
        {
            var next = input.ReadByte();

            output.WriteByte((byte)next);
            _circularBuffer.WriteByte((byte)next);
        }

        private void HandleCompressedBlock(Stream input, Stream output)
        {
            var byte1 = input.ReadByte();
            var byte2 = input.ReadByte();

            var length = (byte1 >> 4) + 3;
            var displacement = (((byte1 & 0xF) << 8) | byte2) + 3;

            CircularBuffer.ArbitraryCopy(_circularBuffer, output, displacement, length);
        }

        private int GetLittleEndian(byte[] data)
        {
            return (data[3] << 24) | (data[2] << 16) | (data[1] << 8) | data[0];
        }

        private int GetBigEndian(byte[] data)
        {
            return (data[0] << 24) | (data[1] << 16) | (data[2] << 8) | data[3];
        }

        public void Dispose()
        {
            _circularBuffer?.Dispose();
        }
    }
}
