//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Root;
    using static core;
    using static cpu;

    partial struct vpack
    {
        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate512x64u(Vector256<uint> src)
            => (vlo256x64u(src), vhi256x64u(src));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> 8x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower target</param>
        /// <param name="hi">The upper target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vinflate512x64u(in SpanBlock256<uint> src, uint offset)
            => (v64u(ConvertToVector256Int64(gptr(src[offset]))),
                v64u(ConvertToVector256Int64(gptr(src[offset],4))));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 8x16u -> 8x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower target</param>
        /// <param name="hi">The upper target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vinflate512x64u(in SpanBlock128<ushort> src, uint offset)
            => (v64u(ConvertToVector256Int64(gptr(src[offset]))),
                v64u(ConvertToVector256Int64(gptr(src[offset],4))));

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate512x64u(Vector128<ushort> src)
            => (vlo256x64u(src), vhi256x64u(src));
    }
}