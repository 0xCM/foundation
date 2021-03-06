// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a square bitmatrix with order determined by the primal type over which it is defined
    /// The intent is to provide a primal bitmatrix generalization
    /// </summary>
    [StructLayout(LayoutKind.Sequential), IdentityProvider(typeof(BitMatrixIdentityProvider))]
    public readonly ref struct BitMatrix<T>
        where T : unmanaged
    {
        internal readonly Span<T> Data;

        public static int N => (int)width<T>();

        [MethodImpl(Inline)]
        internal BitMatrix(Span<T> data)
            => Data = data;

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes();
        }

        public Span<T> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// Specifies the number rows/columns
        /// </summary>
        public int Order
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        public ref BitVector<T> this[int row]
        {
            [MethodImpl(Inline)]
            get => ref AsBitVector(ref core.seek(Data, row));
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Data[row],(byte)col);

            [MethodImpl(Inline)]
            set => Data[row] = gbits.setbit(Data[row], (byte)col, value);
        }

        [MethodImpl(Inline)]
        static ref BitVector<T> AsBitVector(ref T src)
            => ref Unsafe.As<T,BitVector<T>>(ref src);

        [MethodImpl(Inline)]
        public BitMatrix<S> As<S>()
            where S : unmanaged
                => new BitMatrix<S>(Content.Recover<T,S>());

        [MethodImpl(Inline)]
        public static BitVector<T> operator * (BitMatrix<T> A, BitVector<T> x)
            => BitMatrix.mul(A,x);


    }
}