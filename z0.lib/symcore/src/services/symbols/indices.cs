//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Symbols
    {
        public static Index<SymIndex> indices(Type[] src)
            => SymIndexBuilder.create(src);
    }
}