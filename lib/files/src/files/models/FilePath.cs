//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Root;

    partial struct FS
    {
        public readonly struct FilePath : IFsEntry<FilePath>, IComparable<FilePath>, ILocatable<FilePath>, IEquatable<FilePath>
        {
            public PathPart Name {get;}

            [MethodImpl(Inline)]
            public FilePath(PathPart name)
                => Name = name;

            public Drive Drive
            {
                get
                {
                    if(drive(this, out var dst))
                        return dst;
                    else
                        return Drive.Empty;
                }
            }

            public uint PathLength
            {
                [MethodImpl(Inline)]
                get => Name.Length;
            }

            public ReadOnlySpan<char> PathData
            {
                [MethodImpl(Inline)]
                get => Name.View;
            }

            public bool Exists
            {
                [MethodImpl(Inline)]
                get => File.Exists(Name);
            }

            public bool Missing
            {
                [MethodImpl(Inline)]
                get => !Exists;
            }

            public FileName FileName
            {
                [MethodImpl(Inline)]
                get => file(Path.GetFileName(Name));
            }

            public FileExt Ext
            {
                [MethodImpl(Inline)]
                get => FS.ext(Path.GetExtension(Name).TrimStart('.'));
            }

            public FolderPath FolderPath
            {
                [MethodImpl(Inline)]
                get => dir(Path.GetDirectoryName(Name));
            }

            public FolderName FolderName
            {
                [MethodImpl(Inline)]
                get => FolderPath.FolderName;
            }

            public FileInfo Info
            {
                [MethodImpl(Inline)]
                get => new FileInfo(Name);
            }

            /// <summary>
            /// The size of the file in bytes
            /// </summary>
            public ByteSize Size
            {
                [MethodImpl(Inline)]
                get => Info.Length;
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

            /// <summary>
            /// Specifies the file's owning part, if any
            /// </summary>
            public PartId Owner
            {
                [MethodImpl(Inline)]
                get => FileName.Owner;
            }

            /// <summary>
            /// Determines whether the filename is of the form {owner}.{host}.{*}
            /// </summary>
            /// <param name="owner">The owner to test</param>
            [MethodImpl(Inline)]
            public bool IsHost(ApiHostUri host)
                => FileName.IsHost(host);

            /// <summary>
            /// Determines whether the filename is of the form {owner}.{.}.{*}
            /// </summary>
            /// <param name="owner">The owner to test</param>
            [MethodImpl(Inline)]
            public bool IsOwner(PartId part)
                => FileName.IsOwner(part);

            [MethodImpl(Inline)]
            public bool Is(FileExt ext)
                => Name.Text.EndsWith(ext.Name.Text, NoCase);

            [MethodImpl(Inline)]
            public bool Is(FileExt x1, FileExt x2)
                => Is(x1 + x2);

            [MethodImpl(Inline)]
            public bool IsNot(FileExt ext)
                => !Is(ext);

            [MethodImpl(Inline)]
            public bool IsNot(FileExt x1, FileExt x2)
                => !Is(x1,x2);

            public RelativeFilePath Relative(FS.FolderPath src)
                => FS.relative(src, this);

            public FilePath WithoutExtension
                => FolderPath + FileName.WithoutExtension;

            public FilePath ChangeExtension(FileExt ext)
                => WithoutExtension + ext;

            public string ReadText()
                => File.ReadAllText(Name);

            public string ReadUtf8()
                => File.ReadAllText(Name, Encoding.UTF8);

            public string ReadAsci()
                => File.ReadAllText(Name, Encoding.ASCII);

            public string ReadUnicode()
                => File.ReadAllText(Name, Encoding.Unicode);

            public FilePath Timestamped()
                => timestamped(this);

            public RelativeFilePath RelativeTo(FS.FolderPath src)
                => relative(src, this);

            [MethodImpl(Inline)]
            public FilePath Replace(char src, char dst)
                => new FilePath(Name.Replace(src,dst));

            [MethodImpl(Inline)]
            public FilePath Replace(string src, string dst)
                => new FilePath(Name.Replace(src,dst));

            /// <summary>
            /// Determines whether the filename, including the extension, ends with a specified substring
            /// </summary>
            /// <param name="substring">The substring to match</param>
            [MethodImpl(Inline)]
            public bool Contains(string substring)
                => FileName.Contains(substring);

            public bool Equals(FilePath src)
                => Name.Equals(src.Name);

            [MethodImpl(Inline)]
            public string Format()
                => Name.Format();

            [MethodImpl(Inline)]
            public string Format(PathSeparator sep, bool quote = false)
                => quote ? text.enquote(Name.Format(sep)) : Name.Format(sep);

            [MethodImpl(Inline)]
            public FileUri ToUri()
                => new FileUri(this);

            public override string ToString()
                => Format();

            public int CompareTo(FilePath src)
                => Name.CompareTo(src.Name);

            [MethodImpl(Inline)]
            public static FilePath operator +(FilePath a, FileExt b)
                => new FilePath(text.format("{0}.{1}", a.Name, b.Name));

            public static FilePath Empty
            {
                [MethodImpl(Inline)]
                get => new FilePath(PathPart.Empty);
            }
        }
    }
}