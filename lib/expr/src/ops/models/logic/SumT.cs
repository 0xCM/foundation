//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops.Logic
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Sum<T> : ISeqExpr<T>
        where T : IExpr
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public Sum(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Sum(uint count)
            => Data = core.alloc<T>(count);

        public ReadOnlySpan<T> Terms
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator Sum<T>(T[] src)
            => new Sum<T>(src);
    }
}