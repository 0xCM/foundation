//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using I = RegIndexCode;
    using G = AsmOperands.rDb;
    using K = AsmRegTokens.DebugReg;
    using api = AsmRegs;

    partial struct AsmOperands
    {
        public readonly struct rDb : IRegOp64<rDb>
        {
            public RegIndexCode Index {get;}

            [MethodImpl(Inline)]
            public rDb(RegIndexCode index)
            {
                Index = index;
            }

            public string Format()
                => ((K)Index).ToString();

            public override string ToString()
                => Format();

            public NativeSize Size
            {
                [MethodImpl(Inline)]
                get => NativeSizeCode.W64;
            }

            public NativeSizeCode WidthCode
            {
                [MethodImpl(Inline)]
                get => NativeSizeCode.W64;
            }

            public RegClassCode RegClassCode
            {
                [MethodImpl(Inline)]
                get => RegClassCode.DB;
            }

            public RegWidth RegWidth
            {
                [MethodImpl(Inline)]
                get => Size;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClassCode;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => api.reg(src.WidthCode, src.RegClassCode, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);

            [MethodImpl(Inline)]
            public static implicit operator G(I src)
                => new G(src);

            [MethodImpl(Inline)]
            public static implicit operator I(G src)
                => src.Index;

            [MethodImpl(Inline)]
            public static explicit operator byte(G src)
                => (byte)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(Sym<K> src)
                => new G((I)src.Kind);

            [MethodImpl(Inline)]
            public static G operator ++(G src)
                => api.next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => api.prior(src);
        }

        public readonly struct db0 : IRegOp64<db0>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(db0 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db0 src)
                => (K)src.Index;
        }

        public readonly struct db1 : IRegOp64<db1>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(db1 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db1 src)
                => (K)src.Index;
        }

        public readonly struct db2 : IRegOp64<db2>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(db2 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db2 src)
                => (K)src.Index;
        }

        public readonly struct db3 : IRegOp64<db3>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(db3 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db3 src)
                => (K)src.Index;
        }

        public readonly struct db4 : IRegOp64<db4>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(db4 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db4 src)
                => (K)src.Index;
        }

        public readonly struct db5 : IRegOp64<db5>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(db5 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db5 src)
                => (K)src.Index;
        }

        public readonly struct db6 : IRegOp64<db6>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(db6 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db6 src)
                => (K)src.Index;
        }

        public readonly struct db7 : IRegOp64<db7>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(db7 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db7 src)
                => (K)src.Index;
        }
    }
}