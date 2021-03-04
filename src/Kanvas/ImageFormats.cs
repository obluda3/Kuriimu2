﻿using Kanvas.Encoding;
using Kontract.Kanvas;
using Kontract.Models.IO;

namespace Kanvas
{
    public static class ImageFormats
    {
        public static IColorEncoding Rgba1010102(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(10, 10, 10, 2, byteOrder);
        public static IColorEncoding Rgba8888(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(8, 8, 8, 8, byteOrder);
        public static IColorEncoding Rgb888(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(8, 8, 8, byteOrder);
        public static IColorEncoding Rgba5551(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(5, 5, 5, 1, byteOrder);
        public static IColorEncoding Rgb565(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(5, 6, 5, byteOrder);
        public static IColorEncoding Rgb555(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(5, 5, 5, byteOrder);
        public static IColorEncoding Rgba4444(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(4, 4, 4, 4, byteOrder);
        public static IColorEncoding Rg88(ByteOrder byteOrder = ByteOrder.LittleEndian) => new Rgba(8, 8, 0, byteOrder);
        public static IColorEncoding L8() => new La(8, 0);
        public static IColorEncoding L4(BitOrder bitOrder = BitOrder.MostSignificantBitFirst) => new La(4, 0, ByteOrder.LittleEndian, bitOrder);
        public static IColorEncoding A8() => new La(0, 8);
        public static IColorEncoding A4(BitOrder bitOrder = BitOrder.MostSignificantBitFirst) => new La(0, 4, ByteOrder.LittleEndian, bitOrder);
        public static IColorEncoding La88(ByteOrder byteOrder = ByteOrder.LittleEndian) => new La(8, 8, byteOrder);
        public static IColorEncoding La44() => new La(4, 4);

        public static IIndexEncoding I4(BitOrder bitOrder = BitOrder.MostSignificantBitFirst) => new Index(4, ByteOrder.LittleEndian, bitOrder);
        public static IIndexEncoding I8() => new Index(8);
        public static IIndexEncoding Ia53() => new Index(5, 3);

        public static IColorEncoding Etc1(bool zOrder) => new Etc1(false, zOrder);
        public static IColorEncoding Etc1A4(bool zOrder) => new Etc1(true, zOrder);

        public static IColorEncoding Dxt1() => new Bc(BcFormat.Dxt1);
        public static IColorEncoding Dxt3() => new Bc(BcFormat.Dxt3);
        public static IColorEncoding Dxt5() => new Bc(BcFormat.Dxt5);
        public static IColorEncoding Ati1() => new Bc(BcFormat.Ati1);
        public static IColorEncoding Ati2() => new Bc(BcFormat.Ati2);
        public static IColorEncoding Ati1L() => new Bc(BcFormat.Ati1L);
        public static IColorEncoding Ati1A() => new Bc(BcFormat.Ati1A);
        public static IColorEncoding Ati2AL() => new Bc(BcFormat.Ati2AL);

        public static IColorEncoding Atc() => new Atc(AtcFormat.Atc);
        public static IColorEncoding AtcExplicit() => new Atc(AtcFormat.Atc_Explicit);
        public static IColorEncoding AtcInterpolated() => new Atc(AtcFormat.Atc_Interpolated);

        public static IColorEncoding Astc4x4()=>new Astc(AstcFormat.ASTC_4x4);
        public static IColorEncoding Astc5x4() => new Astc(AstcFormat.ASTC_5x4);
        public static IColorEncoding Astc5x5() => new Astc(AstcFormat.ASTC_5x5);
        public static IColorEncoding Astc6x5() => new Astc(AstcFormat.ASTC_6x5);
        public static IColorEncoding Astc6x6() => new Astc(AstcFormat.ASTC_6x6);
        public static IColorEncoding Astc8x5() => new Astc(AstcFormat.ASTC_8x5);
        public static IColorEncoding Astc8x6() => new Astc(AstcFormat.ASTC_8x6);
        public static IColorEncoding Astc8x8() => new Astc(AstcFormat.ASTC_8x8);
        public static IColorEncoding Astc10x5() => new Astc(AstcFormat.ASTC_10x5);
        public static IColorEncoding Astc10x6() => new Astc(AstcFormat.ASTC_10x6);
        public static IColorEncoding Astc10x8() => new Astc(AstcFormat.ASTC_10x8);
        public static IColorEncoding Astc10x10() => new Astc(AstcFormat.ASTC_10x10);
        public static IColorEncoding Astc12x10() => new Astc(AstcFormat.ASTC_12x10);
        public static IColorEncoding Astc12x12() => new Astc(AstcFormat.ASTC_12x12);

        /*
        ASTC_3x3x3,
        ASTC_4x3x3,
        ASTC_4x4x3,
        ASTC_4x4x4,
        ASTC_5x4x4,
        ASTC_5x5x4,
        ASTC_5x5x5,
        ASTC_6x5x5,
        ASTC_6x6x5,
        ASTC_6x6x6, */
    }
}
