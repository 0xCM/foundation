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
    using static SFx;

    partial struct CalcHosts
    {
        public readonly struct VOnes128<T> : IEmitter128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke()
                => gcpu.vones<T>(w128);
        }

        public readonly struct VOnes256<T> : IEmitter256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke()
                => gcpu.vones<T>(w256);
        }
    }
}