//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    public readonly struct TypeIdentityProviders
    {
        public static ITypeIdentityProvider create(Type t, ITypeIdentityProvider fallback)
        {
            var provider = Option.none<ITypeIdentityProvider>();
            if(t.Tagged<IdentityProviderAttribute>())
                provider = attributed(t);
            else if(t.Reifies<ITypeIdentityProvider>())
                provider = hosted(t);
            return provider.ValueOrElse(() => fallback);
        }

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        public static Option<ITypeIdentityProvider> hosted(Type host)
            => Option.Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        public static Option<ITypeIdentityProvider> attributed(Type t)
            => from a in t.Tag<IdentityProviderAttribute>()
               from tid in hosted(a.Host.ToOption().ValueOrDefault(t))
               select tid;

        /// <summary>
        /// Retrieves a type's specialized identity provider, if it has one; otherwise, returns a caller-supplied fallback
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="fallback">The identity provider to yield if the type does not have a specialized provider</param>
        public static ITypeIdentityProvider include(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => _TypeIdentityProviders.GetOrAdd(src.EffectiveType(), fallback);

        static ConcurrentDictionary<Type, ITypeIdentityProvider> _TypeIdentityProviders {get;}
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();
    }
}