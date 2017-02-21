using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ContractDemo
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public Status status;
        [DataMember]
        public int Result { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}
