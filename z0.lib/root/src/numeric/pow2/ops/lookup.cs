//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static Pow2Data;

    partial struct Pow2
    {
        [MethodImpl(Inline), Op]
        public static ulong lookup(byte i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(Pow2Bytes);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), i*8);
            return Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline), Op]
        public static Pow2x8 lookup(Log2x8 i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(Pow2Bytes);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), (byte)i*8);
            return (Pow2x8)Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline), Op]
        public static Pow2x16 lookup(Log2x16 i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(Pow2Bytes);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), (byte)i*8);
            return (Pow2x16)Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline), Op]
        public static Pow2x32 lookup(Log2x32 i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(Pow2Bytes);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), (byte)i*8);
            return (Pow2x32)Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline), Op]
        public static Pow2x64 lookup(Log2x64 i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(Pow2Bytes);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), (byte)i*8);
            return (Pow2x64)Unsafe.As<byte,ulong>(ref start);
        }

        [MethodImpl(Inline), Op]
        public static Pow2M1 m1(byte i)
        {
            ref readonly var first = ref MemoryMarshal.GetReference(M1Bytes64u);
            ref var start =  ref Unsafe.Add(ref Unsafe.AsRef(first), i*8);
            return (Pow2M1)Unsafe.As<byte,ulong>(ref start);
        }
    }
}