//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDecrementable<T> : IOrdered<T>
    {
        T Dec();
    }

    [Free]
    public interface IDecrementable<F,T> : IDecrementable<T>
        where F : IDecrementable<F,T>, new()
    {

    }
}