//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static cpu;

    partial struct BitPack
    {
        /// <summary>
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target value</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack1x8(in uint src, ref byte dst)
        {
            var v0 = vload(w256, src);
            dst = (byte)vpack.vpacklsb(vpack.vpack128x8u(v0));
            return ref dst;
        }

        /// <summary>
        /// Packs the leading 8 source bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bits to pack</param>
        [MethodImpl(Inline), Op]
        public static byte pack1x8(Span<uint> src)
        {
            var v0 = vload(w256, first(src));
            return (byte)vpack.vpacklsb(vpack.vpack128x8u(v0));
        }

        /// <summary>
        /// Packs the least significant bit from 8 32-bit unsigned integers to an 8-bit target
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte pack1x8(uint src)
        {
            var buffer = z8;
            return pack1x8(src, ref buffer);
        }

        /// <summary>
        /// Packs the least significant bit from 8 32-bit source values to a an 8-bit target
        /// </summary>
        /// <param name="src">The intput sequence</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static ref byte pack1x8(in NatSpan<N8,uint> src, ref byte dst)
        {
            dst = pack1x8(src.First);
            return ref dst;
        }
    }
}