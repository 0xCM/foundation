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
    using G = AsmOperands.rCr;
    using K = AsmRegTokens.DebugReg;
    using api = AsmRegs;

    partial struct AsmOperands
    {
        public readonly struct rCr : IRegOp64<G>
        {
            public I Index {get;}

            [MethodImpl(Inline)]
            public rCr(I index)
            {
                Index = index;
            }

            public string Format()
                => ((K)Index).ToString();

            public override string ToString()
                => Format();

            public NativeSizeCode WidthCode
            {
                [MethodImpl(Inline)]
                get => NativeSizeCode.W64;
            }

            public RegClassCode RegClassCode
            {
                [MethodImpl(Inline)]
                get => RegClassCode.CR;
            }

            public RegWidth RegWidth
            {
                [MethodImpl(Inline)]
                get => WidthCode;
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
                => new((I)src);

            [MethodImpl(Inline)]
            public static implicit operator G(I src)
                => new(src);

            [MethodImpl(Inline)]
            public static implicit operator I(G src)
                => src.Index;

            [MethodImpl(Inline)]
            public static explicit operator byte(G src)
                => (byte)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(Sym<K> src)
                => new((I)src.Kind);

            [MethodImpl(Inline)]
            public static G operator ++(G src)
                => api.next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => api.prior(src);
        }

        public readonly struct cr0 : IRegOp64<cr0>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(cr0 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr0 src)
                => (K)src.Index;
        }

        public readonly struct cr1 : IRegOp64<cr1>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(cr1 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr1 src)
                => (K)src.Index;
        }

        public readonly struct cr2 : IRegOp64<cr2>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(cr2 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr2 src)
                => (K)src.Index;
        }

        public readonly struct cr3 : IRegOp64<cr3>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(cr3 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr3 src)
                => (K)src.Index;
        }

        public readonly struct cr4 : IRegOp64<cr4>
        {
            public I Index => I.r4;

            [MethodImpl(Inline)]
            public static implicit operator G(cr4 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr4 src)
                => (K)src.Index;
        }

        public readonly struct cr5 : IRegOp64<cr5>
        {
            public I Index => I.r5;

            [MethodImpl(Inline)]
            public static implicit operator G(cr5 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr5 src)
                => (K)src.Index;
        }

        public readonly struct cr6 : IRegOp64<cr6>
        {
            public I Index => I.r6;

            [MethodImpl(Inline)]
            public static implicit operator G(cr6 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr6 src)
                => (K)src.Index;
        }

        public readonly struct cr7 : IRegOp64<cr7>
        {
            public I Index => I.r7;

            [MethodImpl(Inline)]
            public static implicit operator G(cr7 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr7 src)
                => (K)src.Index;
        }
    }
}