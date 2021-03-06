//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static cpu;

    partial struct vpack
    {
        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vpack128x16i(Vector256<int> src)
            => vpack128x16i(vlo(src), vhi(src));

        /// <summary>
        /// (4x32i,4x32i) -> 8x16i
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vpack128x16i(Vector128<int> a, Vector128<int> b)
            => vpack.vpackss(a,b);
    }
}