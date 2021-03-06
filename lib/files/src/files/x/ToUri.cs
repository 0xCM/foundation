//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XFs
    {

        public static Span<FS.FileUri> ToUri(this Span<FS.FilePath> src)
            => src.Map(x => x.ToUri());

        public static Span<FS.FileUri> ToUri(this Index<FS.FilePath> src)
            => src.Map(x => x.ToUri());

        public static Span<FS.FileUri> ToUri(this FS.FilePath[] src)
            => src.Map(x => x.ToUri());

        public static Span<FS.FileUri> ToUri(this ReadOnlySpan<FS.FilePath> src)
            => src.Map(x => x.ToUri());

        public static Span<FS.FileUri> ToUri(this FS.Files src)
            => src.Map(x => x.ToUri());
    }
}