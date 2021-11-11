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

    partial struct BitPack
    {
        /// <summary>
        /// Partitions a 64-bit source value into 2 segments of width 32
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline), Op]
        public static ref uint unpack32x2(ulong src, ref uint dst)
        {
            seek64(dst,0) = src;
            return ref dst;
        }
    }
}