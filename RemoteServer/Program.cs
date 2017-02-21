using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

using Common;

namespace RemoteServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server started");
            HttpChannel channel = new HttpChannel(12345);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Person), "test", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server is ready");
            Console.ReadLine();
        }
    }
}
