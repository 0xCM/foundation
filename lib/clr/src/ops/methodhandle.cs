//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle methodhandle(Module src, CliToken token)
            => src.ModuleHandle.GetRuntimeMethodHandleFromMetadataToken((int)token);
    }
}