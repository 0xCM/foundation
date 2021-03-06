//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class ClrQuery
    {
        [Op]
        public static FieldInfo[] Fields(this Assembly[] src)
            => src.SelectMany(x => x.Fields());
    }
}