//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using DW = DataWidth;
    using TS = TypeSignKind;

    using W = W4;

    public readonly struct W4 : WData<W>
    {
        public const DW Width = DW.W4;

        public const TS Sign = TS.Unsigned;

        /// <summary>
        /// An instance-level representative
        /// </summary>
        public static W W => default;

        /// <summary>
        /// The width identity
        /// </summary>
        public const string Identifier = "w4";

        public string Id
            => Identifier;

        public DW DataWidth
            => Width;

        public TS TypeSign
            => Sign;

        [MethodImpl(Inline)]
        public static implicit operator int(W src)
            => (int)Width;

        [MethodImpl(Inline)]
        public static implicit operator DW(W src)
            => Width;

        [MethodImpl(Inline)]
        public static implicit operator DataWidth<W>(W src)
            => default;

        [MethodImpl(Inline)]
        public bool Equals(W w)
            => true;

        [MethodImpl(Inline)]
        public string Format()
            => Width.FormatValue();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Width;

        public override bool Equals(object obj)
            => obj is W;    }
}