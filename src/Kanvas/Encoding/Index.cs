﻿using System;
using Kanvas.Encoding.Base;
using Kanvas.Encoding.Descriptors;
using Kontract.Models.IO;

namespace Kanvas.Encoding
{
    /// <summary>
    /// Defines the default index encoding.
    /// </summary>
    public class Index : PixelIndexEncoding
    {
        /// <summary>
        /// Creates a new instance of <see cref="Index"/>.
        /// </summary>
        /// <param name="i">Value of the index component.</param>
        /// <param name="byteOrder">The byte order in which atomic values are read.</param>
        /// <param name="bitOrder">The bit order in which bit values are read.</param>
        public Index(int i, ByteOrder byteOrder = ByteOrder.LittleEndian, BitOrder bitOrder = BitOrder.MostSignificantBitFirst) :
            this(i, 0, "IA", byteOrder, bitOrder)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="Index"/>.
        /// </summary>
        /// <param name="i">Value of the index component.</param>
        /// <param name="a">Value of the alpha component.</param>
        /// <param name="byteOrder">The byte order in which atomic values are read.</param>
        /// <param name="bitOrder">The bit order in which bit values are read.</param>
        public Index(int i, int a, ByteOrder byteOrder = ByteOrder.LittleEndian, BitOrder bitOrder = BitOrder.MostSignificantBitFirst) :
            this(i, a, "IA", byteOrder, bitOrder)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="Index"/>.
        /// </summary>
        /// <param name="i">Value of the index component.</param>
        /// <param name="componentOrder">The order of the components.</param>
        /// <param name="byteOrder">The byte order in which atomic values are read.</param>
        /// <param name="bitOrder">The bit order in which bit values are read.</param>
        public Index(int i, string componentOrder, ByteOrder byteOrder = ByteOrder.LittleEndian, BitOrder bitOrder = BitOrder.MostSignificantBitFirst) :
            this(i, 0, componentOrder, byteOrder, bitOrder)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="Index"/>.
        /// </summary>
        /// <param name="i">Value of the index component.</param>
        /// <param name="a">Value of the alpha component.</param>
        /// <param name="componentOrder">The order of the components.</param>
        /// <param name="byteOrder">The byte order in which atomic values are read.</param>
        /// <param name="bitOrder">The bit order in which bit values are read.</param>
        public Index(int i, int a, string componentOrder, ByteOrder byteOrder = ByteOrder.LittleEndian, BitOrder bitOrder = BitOrder.MostSignificantBitFirst) :
            base(new IndexPixelDescriptor(componentOrder, i, a), byteOrder, bitOrder)
        {
            MaxColors = (int)Math.Pow(2, i);
        }
    }
}
