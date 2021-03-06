//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a concreate <see cref='ICmdSpec'/> realization
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class BlittableAttribute : Attribute
    {
        public BlittableAttribute(uint size)
        {
            Size = size;
        }

        public BlittableAttribute()
        {
            Size = 0;
        }

        public uint Size {get;}
    }
}
