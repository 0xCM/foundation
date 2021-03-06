//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = Pow2;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,2
    /// </summary>
    [Flags, LiteralSet(typeof(Pow2))]
    public enum Pow2x3 : byte
    {
        /// <summary>
        /// 2^0 = 1
        /// </summary>
        [Symbol("2^0")]
        P2ᐞ00 = K.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        [Symbol("2^1")]
        P2ᐞ01 = K.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        [Symbol("2^2")]
        P2ᐞ02 = K.T02,
    }
}