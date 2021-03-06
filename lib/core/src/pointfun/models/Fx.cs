//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct PointFunctions
    {
        public readonly ref struct Fx
        {
            public readonly ReadOnlySpan<byte> Domain;

            public readonly ReadOnlySpan<byte> Range;

            [MethodImpl(Inline)]
            public Fx(ReadOnlySpan<byte> src, ReadOnlySpan<byte> dst)
            {
                Domain = src;
                Range = dst;
            }
        }
    }
}