//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct core
    {
        /// <summary>
        /// Creates a u64 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<long> span64i<T>(in T src)
            where T : struct
                => recover<long>(bytes(src));

        /// <summary>
        /// Creates a u32 span from a bytespan
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<long> span64i(ReadOnlySpan<byte> src)
            => recover<long>(src);
    }
}