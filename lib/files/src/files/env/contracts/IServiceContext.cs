//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IServiceContext : IEnvProvider
    {
        IEventSink EventSink {get;}

        IAppPaths AppPaths {get;}
    }
}