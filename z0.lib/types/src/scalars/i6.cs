//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    public struct i6<T> : ISigned<T>
        where T : unmanaged
    {
        public const ulong Width = 6;

        public T Storage;

        BitWidth IBlittable.ContentWidth
            => Width;
    }
}