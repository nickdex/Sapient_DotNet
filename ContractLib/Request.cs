using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ContractDemo
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public Operation operation;
        [DataMember]
        public int Value1 { get; set; }
        [DataMember]
        public int Value2 { get; set; }
    }
}
