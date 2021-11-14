//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;


    public static partial class ApiMethodSigs
    {
        public abstract class ApiSig<S,K>
            where K : unmanaged
            where S : ApiSig<S,K>, new()
        {
            public K SigKind {get;}

            protected ApiSig(K kind)
            {
                SigKind = kind;
            }

        }

        public abstract class ApiMethodSig<S,K> : ApiSig<S,K>
            where K : unmanaged
            where S : ApiMethodSig<S,K>, new()
        {

            protected ApiMethodSig(K kind)
                : base(kind)
            {

            }
        }

        public abstract class ApiTypeSig<S,K> : ApiSig<S,K>
            where K : unmanaged
            where S : ApiTypeSig<S,K>, new()
        {
            protected ApiTypeSig(K kind)
                : base(kind)
            {

            }
        }


        public enum MethodSigKind : uint
        {
            None,

            UnaryOperator,

            BinaryOperator,

            TernaryOperator

        }

        public enum TypeSigKind : uint
        {
            None,

            Primitive

        }


        public class BinaryOperator : ApiMethodSig<BinaryOperator,MethodSigKind>
        {
            public BinaryOperator()
                : base(MethodSigKind.BinaryOperator)
            {

            }
        }
    }

}