//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XApi
    {
        /// <summary>
        /// Clears an attached immediate suffix, if any
        /// </summary>
        [Op]
        public static OpIdentity WithoutImm8(this OpIdentity src)
        {
            var perhaps = src.ExtractImm8();
            if(!perhaps)
                return src;
            return ApiUri.opid(src.IdentityText.Remove(ApiUri.Imm8Suffix(perhaps.Value)));
        }
    }
}