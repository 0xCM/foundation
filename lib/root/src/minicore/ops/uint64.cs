//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct minicore
    {
        /// <summary>
        /// Converts a parametric source to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong uint64<T>(T src)
            => As<T,ulong>(ref src);

        /// <summary>
        /// Presents a parametric source reference to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong uint64<T>(ref T src)
            => ref As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T uint64<T>(in ulong src, out T dst)
        {
            dst = @as<ulong,T>(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong uint64<T>(in T src, out ulong dst)
        {
            dst = @as<T,ulong>(src);
            return ref dst;
        }

        /// <summary>
        /// Converts a nullable parametric source to a nullable <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As<T?, ulong?>(ref src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='ulong'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ulong> uint64<T>(Span<T> src)
            where T : struct
                => recover<T,ulong>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a readonly sequence of <see cref='ulong'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> uint64<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,ulong>(src);
    }
}