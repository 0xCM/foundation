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
    /// Defines a typed comparison predicate
    /// </summary>
    public sealed class ComparisonPredExpr<T> : IComparisonPredExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public ApiComparisonClass ComparisonKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogixExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogixExpr<T> RightArg {get;}

        /// <summary>
        /// The variables upon which the operands depend
        /// </summary>
        Index<IVarExpr<T>> _Vars {get;}

        [MethodImpl(Inline)]
        public ComparisonPredExpr(ApiComparisonClass op, ILogixExpr<T> left, ILogixExpr<T> right, params IVarExpr<T>[] vars)
        {
            ComparisonKind = op;
            LeftArg = left;
            RightArg = right;
            _Vars = vars;
        }

        public IVarExpr<T>[] Vars
        {
            [MethodImpl(Inline)]
            get => _Vars.Storage;
        }

        public void SetVars(params ILogixExpr<T>[] values)
        {
            var count = Math.Min(_Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                _Vars[i].Set(values[i]);
        }

        public void SetVars(params T[] values)
        {
            var count = Math.Min(_Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                _Vars[i].Set(values[i]);
        }

        [MethodImpl(Inline)]
        public void SetVar(int index, T value)
            => _Vars[index].Set(value);

        public string Format()
            => ComparisonKind.Format(LeftArg,RightArg);

        public override string ToString()
            => Format();
    }
}