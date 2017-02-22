using ContractDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DyanmicClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChannelFactory<ContractDemo.ICalculator> channelFactory = new ChannelFactory<ContractDemo.ICalculator>(
            //    new BasicHttpBinding(), "http://localhost:33333/basic");
            //ContractDemo.ICalculator proxy = channelFactory.CreateChannel();

            CustomProxy proxy = new CustomProxy();

            try
            {
                var result = proxy.Operation(new ContractDemo.Request() { operation = ContractDemo.Operation.NONE, Value2 = 5, Value1 = 10 });
                Console.WriteLine(result.Result);
                Console.WriteLine(result.Count);
            }
            catch (FaultException<Response> exception)
            {
                
                throw;
            }
            catch (Exception exception)
            {

            }
            

            var result2 = proxy.Operation(new ContractDemo.Request() { operation = ContractDemo.Operation.ADD, Value2 = 5, Value1 = 10 });
            Console.WriteLine(result2.Count);

            CustomProxy proxy2 = new CustomProxy();
            var result3 = proxy2.Operation(new ContractDemo.Request() { operation = ContractDemo.Operation.ADD, Value2 = 5, Value1 = 10 });
            Console.WriteLine(result3.Count);

            Console.ReadLine();
        }
    }
}
