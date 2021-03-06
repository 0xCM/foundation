//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Defines a linear relationship between two address spaces
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ScaledIndex
    {
        /// <summary>
        /// The displacement of the index from the source base address
        /// </summary>
        public readonly uint Offset;

        /// <summary>
        /// Specifies a scaling factor and restricted to the domain {-8,-4,-2,-1,0,1,2,4,8}
        /// </summary>
        public readonly sbyte Scale;

        /// <summary>
        /// Measures the count of unaligned bits with respect to the offset/scale
        /// </summary>
        public readonly byte Mod;

        /// <summary>
        /// The width of the smallest addressable unit
        /// </summary>
        public readonly ushort CellWidth;

        [MethodImpl(Inline)]
        public ScaledIndex(ushort wCell, sbyte scale, uint index)
        {
            CellWidth = wCell;
            Offset = (uint)(index/scale);
            Scale = scale;
            Mod = (byte)(Offset%scale);
        }

        public bool Aligned
        {
            [MethodImpl(Inline)]
            get => Mod == 0;
        }

        /// <summary>
        ///  The scale sign
        /// </summary>
        public Sign Sign
        {
            [MethodImpl(Inline)]
            get => Scale;
        }


        public string Format()
        {
            var dst = TextTools.buffer();
            dst.Append(Offset.FormatHex());
            dst.AppendSpace();
            dst.Append((char)Sign);
            dst.AppendSpace();
            dst.Append(Chars.x);
            return dst.Emit();
        }

        public override string ToString()
            => Format();
    }
}