//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static bool available(MemoryBlock src, uint offset, ByteSize wanted)
        {
            if (unchecked((ulong)(uint)offset + (uint)wanted) > (ulong)src.Length)
                return false;
            else
                return true;
        }
    }
}