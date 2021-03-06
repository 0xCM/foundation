//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MultiDiviner : IMultiDiviner
    {
        public static IMultiDiviner Service => default(MultiDiviner);

        [MethodImpl(Inline)]
        public TypeIdentity DivineIdentity(Type src)
            => ApiIdentity.identify(src);

        [MethodImpl(Inline)]
        public OpIdentity DivineIdentity(MethodInfo src)
            => ApiIdentity.identify(src);

        public OpIdentity DivineIdentity(Delegate src)
            => ApiIdentity.identify(src);

        [MethodImpl(Inline)]
        public OpIdentityG GenericIdentity(MethodInfo src)
            => ApiIdentity.generic(src);
    }
}