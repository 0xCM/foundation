//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBinaryBitLogicOp<F,T> : IBinaryOpExpr<F,BinaryBitLogicKind,T,T>
        where F : IBinaryBitLogicOp<F,T>
    {

    }
}