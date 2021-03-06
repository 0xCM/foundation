//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static minicore;

    public interface IApiClass : ITextual
    {
        ApiClassKind ClassId {get;}

        string ITextual.Format()
            => ClassId.ToString().ToLower();
    }

    public interface IApiClass<K> : IApiClass
        where K : unmanaged
    {
        K Kind  {get;}

        ApiClassKind IApiClass.ClassId
            => @as<K,ApiClassKind>(Kind);
    }
}