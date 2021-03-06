//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Specifies that an element either occurs once or not at all
    /// </summary>
    public readonly struct ZeroOrOne<T>
        where T : IEquatable<T>
    {
        public Option<T> Element {get;}

        [MethodImpl(Inline)]
        public ZeroOrOne(T src)
            => Element = src;

        public bool IsOne
        {
            [MethodImpl(Inline)]
            get => Element.Exists;
        }


        public bool IsNone
        {
            [MethodImpl(Inline)]
            get => !Element.Exists;
        }

        public MultiplicityKind Multiplicity
            => MultiplicityKind.ZeroOrOne;

        [MethodImpl(Inline)]
        public static implicit operator ZeroOrOne<T>(T src)
            => new ZeroOrOne<T>(src);
    }
}