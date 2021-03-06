//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static Root;
    using static core;

    using L = math;

    [ApiHost]
    public readonly struct ByteLogic
    {
        [MethodImpl(Inline), Not]
        public static void not(in byte a, ref byte dst)
            => store(L.not(u64(a)), ref dst);

        [MethodImpl(Inline), And]
        public static void and(in byte a, in byte b, ref byte dst)
            => store(L.and(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), Nand]
        public static void nand(in byte a, in byte b, ref byte dst)
            => store(L.nand(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), Or]
        public static void or(in byte a, in byte b, ref byte dst)
            => store(L.or(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), Nor]
        public static void nor(in byte a, in byte b, ref byte dst)
            => store(L.nor(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), Xor]
        public static void xor(in byte a, in byte b, ref byte dst)
            => store(L.xor(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), Xnor]
        public static void xnor(in byte a, in byte b, ref byte dst)
            => store(L.xnor(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), NonImpl]
        public static void nonimpl(in byte a, in byte b, ref byte dst)
            => store(L.nonimpl(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), Impl]
        public static void impl(in byte a, in byte b, ref byte dst)
            => store(L.impl(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), CImpl]
        public static void cimpl(in byte a, in byte b, ref byte dst)
            => store(L.cimpl(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), CNonImpl]
        public static void cnonimpl(in byte a, in byte b, ref byte dst)
            => store(L.cnonimpl(u64(a), u64(b)), ref dst);

        [MethodImpl(Inline), XorNot]
        public static void xornot(in byte a, in byte b, ref byte dst)
            => store(L.xor(u64(a), L.not(u64(b))), ref dst);

        [MethodImpl(Inline), TestZ]
        public static bit testz(in byte a, in byte b)
            => testz(u64(a), u64(b));

        [MethodImpl(Inline), TestC]
        public static bit testc(in byte a, in byte b)
            => testc(u64(a), u64(b));

        [MethodImpl(Inline), TestC]
        public static bit testc(in byte a)
            => testc(u64(a));

        [MethodImpl(Inline), Select]
        public static void select(in byte a, in byte b, in byte c, ref byte dst)
            => store(L.select(u64(a), u64(b), u64(c)), ref dst);

        [MethodImpl(Inline), TestZ]
        static bit testz(ulong a, ulong b)
            => TestZ(cpu.vbroadcast(w128, a), cpu.vbroadcast(w128, b));

        [MethodImpl(Inline), TestZ]
        static bit testc(ulong a, ulong b)
            => TestC(cpu.vbroadcast(w128, a), cpu.vbroadcast(w128, b));

        [MethodImpl(Inline), TestZ]
        static bit testc(ulong a)
            => TestC(cpu.vbroadcast(w128, a), gcpu.vones<ulong>(w128));

        static W64 w => default;
    }
}