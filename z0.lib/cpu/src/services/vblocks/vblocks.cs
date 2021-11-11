//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    [ApiHost]
    public readonly partial struct vblocks
    {
        const NumericKind Closure = UnsignedInts;

        const string inflate = ApiGroupNames.inflate;
    }
}