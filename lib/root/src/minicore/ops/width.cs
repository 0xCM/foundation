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
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        public static BitWidth width<T>()
            => (uint)SizeOf<T>()*8;

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte width<T>(W8 w)
            => (byte)(width<T>());

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort width<T>(W16 w)
            => (ushort)(width<T>());

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<T>(W32 w)
            => (uint)(width<T>());

        /// <summary>
        /// Computes the bit-width of a parametrically-identified type
        /// </summary>
        /// <param name="w">The result width selector</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong width<T>(W64 w)
            => (ulong)(width<T>());
    }
}