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

    public unsafe struct SeqEditor<T>
        where T : unmanaged
    {
        T* Current;

        long Count;

        T* Last;

        [MethodImpl(Inline)]
        internal SeqEditor(T* pSrc, long count)
        {
            Current = pSrc;
            Count = count;
            Last = gptr(skip(@ref(pSrc), count));
        }

        [MethodImpl(Inline)]
        public ref T Next(out bool finished)
        {
            if(Count > 0)
            {
                ref var result = ref Current;
                Current++;
                Count--;
                finished = false;
                return ref @ref(result);
            }
            finished = true;
            return ref @ref(Last);
        }
    }
}