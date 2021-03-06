//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class ClrQuery
    {
        [Op]
        public static ClrTypeSigInfo SigInfo(this ParameterInfo src)
            => Clr.siginfo(src);

        [Op]
        public static ClrTypeSigInfo SigInfo(this Type type)
            => Clr.siginfo(type);
    }
}