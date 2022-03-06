using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class MacBook : Laptop
    {
        public MacBook( string _serialNumber ):
            base(_serialNumber, ProcessorType.i5)
        {
        }
    }
}
