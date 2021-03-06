//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        /// <summary>
        /// Defines an alphabet over a caller-supplied symbol sequence
        /// </summary>
        /// <param name="name">The alphabet name</param>
        /// <param name="src">The defining symbols</param>
        /// <typeparam name="K">The symbol kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Alphabet<K> alphabet<K>(Label name, K[] src)
            where K : unmanaged
                => new Alphabet<K>(name, src);

        /// <summary>
        /// Defines an alphabet over a caller-supplied symbol sequence
        /// </summary>
        /// <param name="name">The alphabet name</param>
        /// <param name="src">The defining symbols</param>
        /// <typeparam name="K">The symbol kind</typeparam>
        public static Alphabet<K> alphabet<K>(Label name, ReadOnlySpan<K> src)
            where K : unmanaged
                => new Alphabet<K>(name, src.ToArray());

        /// <summary>
        /// Defines an alphabet over a parametrically-defined symbol sequence
        /// </summary>
        /// <typeparam name="K">The symbol kind</typeparam>
        public static Alphabet<K> alphabet<K>()
            where K : unmanaged, Enum
                => alphabet(typeof(K).Name, Symbols.index<K>().Kinds);

        /// <summary>
        /// Defines an alphabet over a parametrically-defined symbol sequence
        /// </summary>
        /// <param name="name">The alphabet name</param>
        /// <typeparam name="K">The symbol kind</typeparam>
        public static Alphabet<K> alphabet<K>(Label name)
            where K : unmanaged, Enum
                => alphabet(name, Symbols.index<K>().Kinds);
    }
}