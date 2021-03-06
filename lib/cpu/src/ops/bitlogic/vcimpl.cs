//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Root;

    partial struct cpu
    {
        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<sbyte> vcimpl(Vector128<sbyte> x, Vector128<sbyte> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<byte> vcimpl(Vector128<byte> x, Vector128<byte> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<short> vcimpl(Vector128<short> x, Vector128<short> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<ushort> vcimpl(Vector128<ushort> x, Vector128<ushort> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<int> vcimpl(Vector128<int> x, Vector128<int> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<uint> vcimpl(Vector128<uint> x, Vector128<uint> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<long> vcimpl(Vector128<long> x, Vector128<long> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector128<ulong> vcimpl(Vector128<ulong> x, Vector128<ulong> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<sbyte> vcimpl(Vector256<sbyte> x, Vector256<sbyte> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<byte> vcimpl(Vector256<byte> x, Vector256<byte> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<short> vcimpl(Vector256<short> x, Vector256<short> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<ushort> vcimpl(Vector256<ushort> x, Vector256<ushort> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<int> vcimpl(Vector256<int> x, Vector256<int> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<uint> vcimpl(Vector256<uint> x, Vector256<uint> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<long> vcimpl(Vector256<long> x, Vector256<long> y)
            => Or(vnot(x),y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), CImpl]
        public static Vector256<ulong> vcimpl(Vector256<ulong> x, Vector256<ulong> y)
            => Or(vnot(x),y);
    }
}