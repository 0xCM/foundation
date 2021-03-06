//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using G = WyHash16;

    /// <summary>
    /// Implements a 16-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://lemire.me/blog/2019/07/03/a-fast-16-bit-random-number-generator/</remarks>
    [Rng(nameof(WyHash16))]
    public struct WyHash16 : IRandomSource<WyHash16,ushort>
    {
        [MethodImpl(Inline), Op]
        public static ushort hash16(uint input, uint key)
        {
            var hash = input * key;
            return (ushort) (((hash >> 16) ^ hash) & 0xFFFF);
        }

        [MethodImpl(Inline), Op]
        public static ushort next(ref G rng)
            => hash16(rng.State += rng.Index, 0x2ab);

        [MethodImpl(Inline)]
        internal WyHash16(ushort state, ushort? index = null)
        {
            State = state;
            Index = index ?? 0xfc15;
        }

        ushort State;

        readonly ushort Index;

        public Label Name => nameof(WyHash16);

        [MethodImpl(Inline)]
        public ushort Next()
            => next(ref this);

            //=> hash16(State += Index, 0x2ab);

        public ushort Next(ushort max)
        {
            var x = Next();
            var m = (uint)x * (uint)max;
            var l = (ushort)m;
            if (l < max)
            {
                var t = math.mod(math.negate(max), max);
                while (l < t)
                {
                    x = Next();
                    m = (uint)x * (uint)max;
                    l = (ushort)m;
                }
            }
            return (ushort) (m >> 16);
        }

        [MethodImpl(Inline)]
        public ushort Next(ushort min, ushort max)
            => math.add(min, Next((ushort)(max - min)));
    }
}