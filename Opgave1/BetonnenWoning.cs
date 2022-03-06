using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class BetonnenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            Console.WriteLine("Betonnen dak plaatsen");
        }

        public override void MurenPLaatsen()
        {
            Console.WriteLine("Betonnen muren plaatsen");
        }
    }
}
