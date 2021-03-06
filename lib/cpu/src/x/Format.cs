//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class XTend
    {
        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector128<T> src, char sep = Chars.Comma, bool specifier = false)
            where T : unmanaged
                => gcpu.vspan(src).FormatHex(sep, specifier);

        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector256<T> src, char sep = Chars.Comma, bool specifier = false)
             where T : unmanaged
                => gcpu.vspan(src).FormatHex(sep, specifier);

        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector512<T> src, char sep = Chars.Comma, bool specifier = false)
            where T : unmanaged
                => string.Concat(gcpu.vspan(src).FormatHex(sep, specifier), sep, Chars.Space,gcpu.vspan(src).FormatHex(sep, specifier));

        [Op, Closures(Closure)]
        public static string Format<T>(this Vector128<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => gcpu.vspan(src).FormatList(sep,0,pad,true);

        [Op, Closures(Closure)]
        public static string Format<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => gcpu.vspan(src).FormatList(sep, 0, pad, true);

        [Op, Closures(Closure)]
        public static string Format<T>(this Vector512<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => RP.bracket(
                        string.Concat(
                            gcpu.vspan(src).FormatList(sep, 0, pad, false),
                            sep, Chars.Space,
                            gcpu.vspan(src).FormatList(sep, 0, pad, false)
                        )
                    );

        [Op, Closures(Closure)]
        public static string FormatLanes<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => string.Concat(
                    src.GetLower().Format(sep, pad), Chars.Space,
                    src.GetUpper().Format(sep, pad));
   }
}