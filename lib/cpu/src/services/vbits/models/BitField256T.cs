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

    using api = vbits;

    public struct Bitfield256<T>
        where T : unmanaged
    {
        public Vector256<T> State;

        internal readonly Vector256<byte> Widths;

        [MethodImpl(Inline)]
        public Bitfield256(Vector256<byte> widths, Vector256<T> state)
        {
            State = state;
            Widths = default;
        }

        public T this[byte index]
        {
            [MethodImpl(Inline)]
            get => Read(index);
        }

        [MethodImpl(Inline)]
        public byte SegWidth(byte index)
            => api.segwidth(this, index);

        [MethodImpl(Inline)]
        public T Mask(byte index)
            => vmask.mask(this, index);

        [MethodImpl(Inline)]
        public T Read(byte index)
            => api.extract(this, index);

        [MethodImpl(Inline)]
        public void Write(T src, byte index)
            => api.store(src, index, ref this);
    }
}