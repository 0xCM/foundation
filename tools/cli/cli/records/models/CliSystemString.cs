//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Record(TableId)]
    public struct CliSystemString : IRecord<CliSystemString>
    {
        public const string TableId = "image.strings.system";

        public const byte FieldCount = 6;

        public Count Sequence;

        public bool IsSystemString;

        public ByteSize HeapSize;

        public Count Length;

        public Address32 Offset;

        public string Content;

        [MethodImpl(Inline)]
        public CliSystemString(Count seq, ByteSize heap, Address32 offset, string data)
        {
            Sequence = seq;
            IsSystemString = true;
            HeapSize = heap;
            Length = data.Length;
            Offset = offset;
            Content = data;
        }
    }
}