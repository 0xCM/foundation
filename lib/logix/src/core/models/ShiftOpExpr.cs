//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a bitwise shift operator expression
    /// </summary>
    public readonly struct ShiftOpExpr<T> : IShiftOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public ApiBitShiftClass ApiClass {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public ILogixExpr<T> Subject {get;}

        /// <summary>
        /// The magnitude of the shift
        /// </summary>
        public ILogixExpr<byte> Offset {get;}

        [MethodImpl(Inline)]
        public ShiftOpExpr(ApiBitShiftClass op, ILogixExpr<T> subject, ILogixExpr<byte> offset)
        {
            ApiClass = op;
            Subject = subject;
            Offset = offset;
        }

        public string Format()
            => ApiClass.Format(Subject,Offset);

        public override string ToString()
            => Format();
    }
}