using ContractDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DyanmicClient
{
    class CustomProxy: ClientBase<ICalculator>, ICalculator
    {
        public CustomProxy() : base(new BasicHttpBinding(), new EndpointAddress(new Uri("http://localhost:33333/basic")))
        {

        }

        public Response Operation(Request request)
        {
            return base.Channel.Operation(request);
        }
    }
}
