using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Person : MarshalByRefObject
    {
        private int _count;

        public Person()
        {
            Console.WriteLine("Constructor Called");
        }

        public string Increment()
        {
            _count++;

            return String.Format("Value of count is {0}", _count);
        }
    }
}
