// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.1.1 (commit 92e49e96f461b4496bdab42facbab2c5d39d20f4).

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Internal
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class RawSequenceDefV8
    {
        [DataMember(Name = "sequence_name")]
        public string SequenceName;
        [DataMember(Name = "col_pos")]
        public ushort ColPos;
        [DataMember(Name = "increment")]
        public I128 Increment;
        [DataMember(Name = "start")]
        public I128? Start;
        [DataMember(Name = "min_value")]
        public I128? MinValue;
        [DataMember(Name = "max_value")]
        public I128? MaxValue;
        [DataMember(Name = "allocated")]
        public I128 Allocated;

        public RawSequenceDefV8(
            string SequenceName,
            ushort ColPos,
            I128 Increment,
            I128? Start,
            I128? MinValue,
            I128? MaxValue,
            I128 Allocated
        )
        {
            this.SequenceName = SequenceName;
            this.ColPos = ColPos;
            this.Increment = Increment;
            this.Start = Start;
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;
            this.Allocated = Allocated;
        }

        public RawSequenceDefV8()
        {
            this.SequenceName = "";
        }
    }
}
