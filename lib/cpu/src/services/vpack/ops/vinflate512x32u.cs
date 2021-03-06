//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Root;
    using static core;
    using static cpu;

    partial struct vpack
    {
        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate512x32u(Vector256<ushort> src)
            => (vpack.vlo256x32u(src), vpack.vhi256x16u(src));

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate512x32u(Vector128<byte> src)
            => (vpack.vlo256x32u(src), vpack.vhi256x32u(src));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<uint> vinflate512x32u(in SpanBlock256<ushort> src, uint offset)
            => (v32u(ConvertToVector256Int32(gptr(src[offset]))),
                v32u(ConvertToVector256Int32(gptr(src[offset], 8))));
    }
}