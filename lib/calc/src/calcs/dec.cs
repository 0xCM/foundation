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

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Dec<T> dec<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Dec, Closures(Closure)]
        public static Dec128<T> dec<T>(W128 w)
            where T : unmanaged
                => default(Dec128<T>);

        [MethodImpl(Inline), Dec, Closures(Closure)]
        public static Dec256<T> dec<T>(W256 w)
            where T : unmanaged
                => default(Dec256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VDec128<T> vdec<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VDec128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VDec256<T> vdec<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VDec256<T>);

        [MethodImpl(Inline), Dec, Closures(Closure)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => gcalc.apply(Calcs.dec<T>(), src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> dec<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref dec<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> dec<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref dec<T>(w256).Invoke(a, dst);
    }
}