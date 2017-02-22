using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ContractDemo
{
    [DataContract]
    public enum Operation
    {
        [EnumMember]
        NONE,
        [EnumMember]
        ADD,
        [EnumMember]
        SUB,
        [EnumMember]
        DIV,
        [EnumMember]
        MUL
    }
}
