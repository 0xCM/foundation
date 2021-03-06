//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static CalcHosts;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Mul), Closures(Closure)]
        public static Mul<T> mul<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory(Mul), Closures(Closure)]
        public static Span<T> mul<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => gcalc.apply(Calcs.mul<T>(), l, r, dst);
    }
}