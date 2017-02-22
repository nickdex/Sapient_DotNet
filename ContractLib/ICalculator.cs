using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;



namespace ContractDemo
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        [FaultContract(typeof(Response))]
        Response Operation(Request request);
    }
}
