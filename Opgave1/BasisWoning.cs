using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    abstract class BasisWoning
    {
        public void WoningBouwen()
        {
            FunderingPlaatsen();
            MurenPLaatsen();
            DakPlaatsen();
            RamenPLaatsen();
        }

        public void FunderingPlaatsen()
        {
            Console.WriteLine("Fundering met beton en ijzer plaatsen");
        }
        public abstract void MurenPLaatsen();

        public abstract void DakPlaatsen();

        public void RamenPLaatsen()
        {
            Console.WriteLine("Glazen Ramen plaatsen");
        }
    }
}
