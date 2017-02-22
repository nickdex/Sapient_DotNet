using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ContractDemo
{
    [ServiceBehavior(InstanceContextMode= InstanceContextMode.PerSession)]
    public class CalculatorService : ICalculator
    {
        public int Count { get; set; }

        public Response Operation(Request request)
        {
            Response result = new Response();
           switch(request.operation)
           {
               case ContractDemo.Operation.ADD:
                   result.Result = request.Value1 + request.Value2;
                   result.status = Status.SUCCESS;
                   result.Count = ++Count;
                   break;
               case ContractDemo.Operation.SUB:
                   result.Result = request.Value1 - request.Value2;
                   result.status = Status.SUCCESS;
                   break;
               case ContractDemo.Operation.DIV:
                   result.Result = request.Value1 / request.Value2;
                   result.status = Status.SUCCESS;
                   break;
               case ContractDemo.Operation.MUL:
                   result.Result = request.Value1 * request.Value2;
                   result.status = Status.SUCCESS;
                   break;
               case ContractDemo.Operation.NONE:
                   result.status = Status.FAILURE;
                   throw new FaultException<Response>(result, new FaultReason("None is selected"));
               default:
                   result.status = Status.FAILURE;
                   break;

           }

           return result;
        }

    }
}
