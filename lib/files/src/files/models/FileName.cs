//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;

    partial struct FS
    {
        public static FS.FileName timestamped(string name, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", name, (Timestamp.now()).Format()),ext);

        public readonly struct FileName : IFsEntry<FileName>, IComparable<FileName>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FileName(PathPart name)
                => Name = name;

            [MethodImpl(Inline)]
            public FileName(PathPart name, FileExt ext)
                => Name = string.Format(ExtPattern, name, ext);

            public bool HasExtension
            {
                [MethodImpl(Inline)]
                get => Path.HasExtension(Name);
            }

            public FileExt FileExt
            {
                [MethodImpl(Inline)]
                get => HasExtension ? FS.ext(Path.GetExtension(Name)) : FileExt.Empty;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Name.IsNonEmpty;
            }

            public FileName WithoutExtension
            {
                [MethodImpl(Inline)]
                get => FS.file(Path.GetFileNameWithoutExtension(Name));
            }

            public FileName WithExtension(FS.FileExt ext)
                => this + ext;

            /// <summary>
            /// Specifies the file's owning part, if any
            /// </summary>
            public PartId Owner
                => part(this);

            /// <summary>
            /// Determines whether the name of a file is of the form {owner}.{*}
            /// </summary>
            /// <param name="host">The owner to test</param>
            [MethodImpl(Inline)]
            public bool IsOwner(PartId id)
                => id == Owner;

            /// <summary>
            /// Determines whether the name of a file is of the form {owner}.{host}.{*}
            /// </summary>
            /// <param name="host">The owner to test</param>
            public bool IsHost(ApiHostUri host)
                => Name.Text.StartsWith(string.Concat(host.Part.Format(), Chars.Dot, host.HostName.ToLower(), Chars.Dot));

            public FileName ChangeExtension(FileExt ext)
                => FS.file(Path.GetFileNameWithoutExtension(Name), ext);

            /// <summary>
            /// Determines whether the filename, begins with a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool StartsWith(string substring)
                => Name.StartsWith(substring);

            /// <summary>
            /// Determines whether the filename, including the extension, contains a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool Contains(string substring)
                => Name.Contains(substring);

            [MethodImpl(Inline)]
            public bool Is(FileExt ext)
                => ext.Matches(this);

            public override int GetHashCode()
                => Name.GetHashCode();

            public bool Equals(FileName src)
                => Name == src.Name;

            public override bool Equals(object src)
                => src is FileName x && Equals(x);

            const string ExtPattern = "{0}.{1}";

            /// <summary>
            /// Converts this filename to a <see cref='FilePath'/>
            /// </summary>
            [MethodImpl(Inline)]
            public FilePath ToPath()
                => path(Name);

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            public override string ToString()
                => Format();

            public int CompareTo(FileName src)
                => Name.CompareTo(src.Name);

            [MethodImpl(Inline)]
            public FileNameTS WithTimestamp(Timestamp? ts = null)
                => new FileNameTS(this, ts ?? Timestamp.now());

            [MethodImpl(Inline)]
            public static FileName operator +(FileName a, FileExt b)
                => new FileName(string.Format("{0}.{1}", a.Name, b.Name));

            [MethodImpl(Inline)]
            public static bool operator ==(FileName a, FileName b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(FileName a, FileName b)
                => !a.Equals(b);

            public static FileName Empty
            {
                [MethodImpl(Inline)]
                get => new FileName(PathPart.Empty);
            }
        }
    }
}