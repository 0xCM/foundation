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
    using static cpu;

    partial struct vpack
    {
        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a)
        /// VPMOVSXBW ymm, xmm/m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vlo256x16i(Vector256<sbyte> src)
            => ConvertToVector256Int16(vlo(src));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a)
        /// VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vlo256x16i(Vector256<byte> src)
            => ConvertToVector256Int16(vlo(src));
    }
}