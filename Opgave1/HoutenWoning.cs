using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class HoutenWoning : BasisWoning
    {
        public override void DakPlaatsen()
        {
            Console.WriteLine("Houten dak plaatsen");
        }

        public override void MurenPLaatsen()
        {
            Console.WriteLine("Houten muren paatsen");
        }
    }
}
