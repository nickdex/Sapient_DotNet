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
            Calculator.CalculatorClient client = new Calculator.CalculatorClient("Basic");
            var response = client.Operation(new Calculator.Request() { operation = Calculator.Operation.NONE, Value1 = 5, Value2 = 10 });

            //Cooler.CoolerClient client = new Cooler.CoolerClient("Basic1");

            //var result = client.CalculateCoolnes("nikhil");

        }
    }
}
