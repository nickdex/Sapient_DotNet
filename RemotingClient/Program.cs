using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;

using Common;
namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = Activator.GetObject(typeof(Person), "http://localhost:12345/test") as Person;

            Console.WriteLine("Client Ready, Press any key");
            Console.ReadLine();
            
            Console.WriteLine(person.Increment());

            Console.ReadLine();
        }
    }
}
