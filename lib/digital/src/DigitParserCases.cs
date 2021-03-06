//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct DigitParserCases
    {
        [Op]
        public static Index<DigitParserResult> run(ReadOnlySpan<DigitParserCase> cases)
        {
            var count = cases.Length;
            var buffer = alloc<DigitParserResult>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var @case = ref skip(cases,i);
                Digital.digit(@case.Base, @case.Input, out var d);
                seek(dst,i) = new DigitParserResult(@case, d);
            }

            return buffer;
        }

        [Op]
        public static Index<DigitParserCase> create()
        {
            const byte b2d = 2;
            const byte b8d = 8;
            const byte b10d = 10;
            const byte b16d = 16;

            var count = b2d + b8d + b10d + b16d + b16d;
            var buffer = alloc<DigitParserCase>(count);
            ref var dst = ref first(buffer);
            var j=0;

            for(byte i=0; i<b2d; i++)
                seek(dst, j++) = new DigitParserCase(base2, Digital.@char((BinaryDigitValue)i), i);

            for(byte i=0; i<b8d; i++)
                seek(dst, j++) = new DigitParserCase(base8, Digital.@char((OctalDigitValue)i), i);

            for(byte i=0; i<b10d; i++)
                seek(dst, j++) = new DigitParserCase(base10, Digital.@char((DecimalDigitValue)i), i);

            for(byte i=0; i<b16d; i++)
                seek(dst, j++) = new DigitParserCase(base16, Digital.@char(LowerCase, (HexDigitValue)i), i);

            for(byte i=0; i<b16d; i++)
                seek(dst, j++) = new DigitParserCase(base16, Digital.@char(UpperCase, (HexDigitValue)i), i);

            return buffer;
        }
    }
}