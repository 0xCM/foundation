//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly partial struct AsciG
    {
        [MethodImpl(Inline)]
        public static bool contains<T>(in T src, AsciCharSym match)
            where T : IAsciSeq
        {
            var code = (byte)match;
            var count = src.Length;
            var data = src.View;
            for(var i=0; i<count; i++)
                if(skip(data,i) == code)
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static int index<T>(in T src, AsciCharSym match)
            where T : IAsciSeq
        {
            var code = (byte)match;
            var count = src.Length;
            var data = src.View;
            for(var i=0; i<count; i++)
                if(skip(data,i) == code)
                    return i;

            return NotFound;
        }

        [MethodImpl(Inline)]
        public static string @string<A>(in A src)
            where A : unmanaged, IByteSeq
                => src.Format();

        [MethodImpl(Inline)]
        public static ref readonly asci2 cast<A>(N2 n, in A src)
            where A : unmanaged, IByteSeq
                => ref @as<A,asci2>(src);

        [MethodImpl(Inline)]
        public static ref readonly asci4 cast<A>(N4 n, in A src)
            where A : unmanaged, IByteSeq
                => ref @as<A,asci4>(src);

        [MethodImpl(Inline)]
        public static ref readonly asci8 cast<A>(N8 n, in A src)
            where A : unmanaged, IByteSeq
                => ref @as<A,asci8>(src);

        [MethodImpl(Inline)]
        public static ref readonly asci16 cast<A>(N16 n, in A src)
            where A : unmanaged, IByteSeq
                => ref @as<A,asci16>(src);

        [MethodImpl(Inline)]
        public static ref readonly asci32 cast<A>(N32 n, in A src)
            where A : unmanaged, IByteSeq
                => ref @as<A,asci32>(src);

        [MethodImpl(Inline)]
        public static ref readonly asci64 cast<A>(N64 n, in A src)
            where A : unmanaged, IByteSeq
                => ref @as<A,asci64>(src);

        [MethodImpl(Inline), Op]
        public static unsafe void copy<A>(ReadOnlySpan<A> src, Span<byte> dst)
            where A : unmanaged, IByteSeq
        {
            for(var i=0u; i<src.Length; i++)
                copy(skip(src,i), ref seek(dst,i*64));
        }

        [MethodImpl(Inline)]
        public static void copy<A>(in A src, ref byte dst)
            where A : unmanaged, IByteSeq
                => copy(n2, src, ref dst);

        [MethodImpl(Inline)]
        static void copy<A>(N2 n, in A src, ref byte dst)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci2))
                copy(cast(n2, src), ref dst);
            else if(typeof(A) == typeof(asci4))
                copy(cast(n4, src), ref dst);
            else if(typeof(A) == typeof(asci8))
                copy(cast(n8, src), ref dst);
            else if(typeof(A) == typeof(asci16))
                copy(cast(n16, src), ref dst);
            else
                copy(n32, src, ref dst);
        }

        [MethodImpl(Inline)]
        static void copy<A>(N32 n, in A src, ref byte dst)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci32))
                copy(cast(n32, src), ref dst);
            else if(typeof(A) == typeof(asci64))
                copy(cast(n64, src), ref dst);
            else
                throw no<A>();
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> chars<A>(in A src)
            where A : unmanaged, IByteSeq
                => chars(n2, src);

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars<A>(N2 n, in A src)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci2))
                return Asci.decode(cast(n2,src));
            else if(typeof(A) == typeof(asci4))
                return Asci.decode(cast(n4,src));
            else if(typeof(A) == typeof(asci8))
                return Asci.decode(cast(n8,src));
            else if(typeof(A) == typeof(asci16))
                return Asci.decode(cast(n16,src));
            else
                return chars(n32, src);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars<A>(N32 n, in A src)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci32))
                return Asci.decode(cast(n32,src));
            else if(typeof(A) == typeof(asci64))
                return Asci.decode(cast(n64,src));
            else
                return ReadOnlySpan<char>.Empty;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<AsciCode> codes<A>(in A src)
            where A : unmanaged, IByteSeq
                => codes(n2, src);

        [MethodImpl(Inline)]
        static ReadOnlySpan<AsciCode> codes<A>(N2 n, in A src)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci2))
                return recover<AsciCode>(cast(n2, src).View);
            else if(typeof(A) == typeof(asci4))
                return recover<AsciCode>(cast(n4, src).View);
            else if(typeof(A) == typeof(asci8))
                return recover<AsciCode>(cast(n8, src).View);
            else if(typeof(A) == typeof(asci16))
                return recover<AsciCode>(cast(n16, src).View);
            else
                return codes(n32, src);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<AsciCode> codes<A>(N32 n, in A src)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci32))
                return recover<AsciCode>(cast(n32, src).View);
            else if(typeof(A) == typeof(asci64))
                return recover<AsciCode>(cast(n64, src).View);
            else
                return ReadOnlySpan<AsciCode>.Empty;
        }
    }
}