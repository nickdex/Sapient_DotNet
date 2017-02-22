using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ContractDemo
{
    [ServiceContract]
    interface ICooler
    {
        [OperationContract]
        bool CalculateCoolnes(string name);
    }
}
