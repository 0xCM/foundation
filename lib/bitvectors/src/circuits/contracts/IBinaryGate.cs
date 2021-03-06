//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Intrinsics;

    partial class LegacyCircuits
    {
        /// <summary>
        /// Characterizes a logic gate that receives 2 bits
        /// </summary>
        public interface IBinaryGate : ILogicGate
        {
            bit Invoke(bit a, bit b);
        }

        /// <summary>
        /// Characterizes a set of logic gates where each member accepts 2 bits of input
        /// </summary>
        /// <typeparam name="T">A type that defines a finite sequence of bits</typeparam>
        public interface IBinaryGate<T> : IBinaryGate, IBinaryOp<T>
            where T : unmanaged
        {

        }

        public interface IBinaryGateIn<T> : IBinaryOpIn<T>
            where T : unmanaged
        {

        }

        public interface IBinaryGate128<T> : IBinaryGate<Vector128<T>>
            where T : unmanaged
        {

        }

        public interface IBinaryGate256<T> : IBinaryGate<Vector256<T>>
            where T : unmanaged
        {

        }

        public interface IBinaryGate512<T> : IBinaryGateIn<Vector512<T>>
            where T : unmanaged
        {

        }

    }

}