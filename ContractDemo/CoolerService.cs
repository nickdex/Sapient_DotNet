using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractDemo
{
    
    class CoolerService : ICooler
    {

        public bool CalculateCoolnes(string name)
        {
            return name.Equals("nikhil");
        }
    }
}
