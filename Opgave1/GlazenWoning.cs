using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class GlazenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            Console.WriteLine("Glazen dak plaatsen");
        }

        public override void MurenPLaatsen()
        {
            Console.WriteLine("Glazen muren plaatsen");
        }
    }
}
