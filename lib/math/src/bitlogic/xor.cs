//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static sbyte xor(sbyte a, sbyte b)
            => (sbyte)(a ^ b);

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static short xor(short a, short b)
            => (short)(a ^ b);

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static ushort xor(ushort a, ushort b)
            => (ushort)(a ^ b);

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static int xor(int a, int b)
            => a ^ b;

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static uint xor(uint a, uint b)
            => a ^ b;

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static long xor(long a, long b)
            => a ^ b;

        /// <summary>
        /// Computes the bitwise xor c := a ^ b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Xor]
        public static ulong xor(ulong a, ulong b)
            => a ^ b;
    }
}