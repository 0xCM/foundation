//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly partial struct ApiClasses
    {
        const NumericKind Closure = NumericKind.UnsignedInts;

        public static string format<K>(K kind)
            where K : IApiClass
                => typeof(K).Name;

        public static ApiClass<K> describe<K>(K kind)
            where K : unmanaged, IApiClass<K>
                => kind;

        [KindFactory]
        public static And and()
            => default;

        [KindFactory]
        public static Or or()
            => default;

        [KindFactory]
        public static Xor xor()
            => default;

        [KindFactory]
        public static Nand nand()
            => default;

        [KindFactory]
        public static Nor nor()
            => default;

        [KindFactory]
        public static Xnor xnor()
            => default;

        [KindFactory]
        public static Not not()
            => default;

        [KindFactory]
        public static Impl impl()
            => default;

        [KindFactory]
        public static NonImpl nonimpl()
            => default;

        [KindFactory]
        public static CImpl cimpl()
            => default;

        [KindFactory]
        public static CNonImpl cnonimpl()
            => default;

        [KindFactory]
        public static LNot lnot()
            => default;

        [KindFactory]
        public static RNot rnot()
            => default;

        [KindFactory]
        public static Select select()
            => default;

        [KindFactory]
        public static Add add()
            => default;

        [KindFactory]
        public static Sub sub()
            => default;

        [KindFactory]
        public static Mul mul()
            => default;

        [KindFactory]
        public static Div div()
            => default;

        [KindFactory]
        public static Mod mod()
            => default;

        [KindFactory]
        public static Sll sll()
            => default;

        [KindFactory]
        public static Srl srl()
            => default;

        [KindFactory]
        public static Rotl rotl()
            => default;

        [KindFactory]
        public static Rotr rotr()
            => default;
    }
}