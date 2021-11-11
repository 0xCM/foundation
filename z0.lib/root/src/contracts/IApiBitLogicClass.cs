//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using K = ApiBitLogicClass;

    /// <summary>
    /// Characterizes a bitlogic operation classifier
    /// </summary>
    [Free]
    public interface IApiBitLogicClass : IApiClass<K>
    {
        new K Kind {get;}

        K IApiClass<K>.Kind
            => Kind;

        NumericKind NumericKind
            => default;
    }
}