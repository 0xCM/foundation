//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class text
    {
        /// <summary>
        /// Returns a string of length 1 that corresponds to the specified asci code
        /// </summary>
        /// <param name="code">The asci code</param>
        [MethodImpl(Inline), Op]
        public static unsafe string @string(AsciCode code)
            => new string(gptr<char>((char)code));

        /// <summary>
        /// Returns the content preceeding the first null-termininator, if extant; oterwise, returns the input clamped to a specified maxumim count, if any
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="max">The maximum length of the returned content</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> @string(ReadOnlySpan<char> src, uint? max = null)
        {
            var counter = 0u;
            var count = max == null ? src.Length : min(src.Length, max.Value);
            for(var i=0; i<count; i++)
            {
                if(skip(src,i) == 0)
                    break;
                counter++;
            }

            return core.slice(src,0,counter);
        }
    }
}