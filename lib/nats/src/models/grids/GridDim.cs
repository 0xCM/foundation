//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static CharText;
    using static core;

    using api = CellCalcs;

    /// <summary>
    /// Defines grid dimensions based on specification without parametrization
    /// </summary>
    [StructLayout(LayoutKind.Sequential), DataType]
    public readonly struct GridDim : IDataTypeEquatable<GridDim>
    {
        public static bool Parse(string s, out GridDim dst)
        {
            dst = GridDim.Empty;

            var n = 0u;
            var parts = @readonly(s.Split('x'));
            var parser = NumericParser.create<uint>();
            dst = default;
            if(parts.Length == 2)
            {
                if(parser.Parse(skip(parts,0), out var m) && parser.Parse(skip(parts,1), out n))
                {
                    dst = new GridDim(m, n);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public readonly uint M;

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public readonly uint N;

        [MethodImpl(Inline)]
        public GridDim(uint rows, uint cols)
        {
            M = rows;
            N = cols;
        }

        [MethodImpl(Inline)]
        public uint Offset(uint row, uint col)
            => api.offset(this, row, col);

        /// <summary>
        /// Formats the dimension in canonical form
        /// </summary>
        public string Format()
            => $"{M}x{N}";

        [MethodImpl(Inline)]
        public void Deconstruct(out uint rows, out uint cols)
        {
            rows = M;
            cols = N;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridDim src)
            => src.M == M
            && src.N == N;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)FastHash.combine(M, N);

        public override bool Equals(object obj)
            => obj is GridDim d && Equals(d);

        public static bool operator ==(GridDim d1, GridDim d2)
            => d1.Equals(d2);

        public static bool operator !=(GridDim d1, GridDim d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public static implicit operator GridDim((int rows, int cols) src)
            => new GridDim((uint)src.rows,(uint)src.cols);

        [MethodImpl(Inline)]
        public static implicit operator GridDim((uint rows, uint cols) src)
            => new GridDim(src.rows,src.cols);

        public static GridDim Empty
            => default;

        public static RenderTemplate RT =>
             fLT + nameof(GridDim.M) + RT + x +
             fLT + nameof(GridDim.N) + RT;
    }
}