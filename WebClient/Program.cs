using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator.CalculatorClient client = new Calculator.CalculatorClient("Basic");
            //Calculator.CoolerClient coolerClient = new Calculator.CoolerClient("Basic");
            //var response = client.Operation(new Calculator.Request() { operation = Calculator.Operation.ADD, Value1 = 5, Value2 = 10 });

            Cooler.CoolerClient client = new Cooler.CoolerClient("Basic1");

            var result = client.CalculateCoolnes("nikhil");

        }
    }
}
