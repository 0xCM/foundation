//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct PrimalClass : IIsomorhphic<PrimalClass,PrimitiveKind>
    {
        public PrimitiveKind Kind {get;}

        public PrimalClass(PrimitiveKind kind)
        {
            Kind = kind;
        }

        public string Format()
            => types.format(Kind);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator PrimalClass(PrimitiveKind src)
            => new PrimalClass(src);

        [MethodImpl(Inline)]
        public static implicit operator PrimitiveKind(PrimalClass src)
            => src.Kind;
    }
}