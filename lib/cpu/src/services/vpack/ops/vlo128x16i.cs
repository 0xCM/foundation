//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static Root;

    partial struct vpack
    {
        /// <summary>
        /// __m128i _mm_cvtepi8_epi16 (__m128i a)
        /// PMOVSXBW xmm, xmm/m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vlo128x16i(Vector128<sbyte> src)
            => ConvertToVector128Int16(src);

        /// <summary>
        /// __m128i _mm_cvtepu8_epi16 (__m128i a)
        /// PMOVZXBW xmm, xmm/m64
        /// 8x8u -> 8x16u
        /// src[i] -> dst[i], i = 0,.., 7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vlo128x16i(Vector128<byte> src)
            => ConvertToVector128Int16(src);
    }
}