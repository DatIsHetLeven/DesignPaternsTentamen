using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class HPLaptop : Laptop
    {
        public HPLaptop( string _serialNumber):
            base(_serialNumber, ProcessorType.Ryzen3)
        {
        }
    }
}
