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

    /// <summary>
    /// Represents an application-level/logical event with which data specific to an event class is associated
    /// </summary>
    public readonly struct SourcedEvent<T>
        where T : unmanaged
    {
        public readonly AgentEventId EventId;

        /// <summary>
        /// Data specific to an event class
        /// </summary>
        public readonly T Payload;

        /// <summary>
        /// Reconstitutes an event from a sequence of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public static SourcedEvent<T> materialize(Span<byte> src)
            => MemoryMarshal.Read<SourcedEvent<T>>(src);

        [MethodImpl(Inline)]
        public static implicit operator SourcedEvent(SourcedEvent<T> src)
            => new SourcedEvent(src.EventId);

        [MethodImpl(Inline)]
        public SourcedEvent(AgentEventId id, T data)
        {
            EventId = id;
            Payload = data;
        }

        /// <summary>
        /// Renders the event as a sequence of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Serialize()
            => core.bytes(this);
    }
}