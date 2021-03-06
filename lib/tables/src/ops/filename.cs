//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Tables
    {
        public static FS.FileName filename(TableId id)
            => filename(id, FS.Csv);

        public static FS.FileName filename(TableId id, FS.FileExt ext)
            => FS.file(id.Format(), ext);


        public static FS.FileName filename<T>()
            where T : struct
                => filename<T>(FS.Csv);

        public static FS.FileName filename<T>(FS.FileExt ext)
            where T : struct
                => filename(identify<T>());
    }
}