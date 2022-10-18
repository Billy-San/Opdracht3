using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    internal class Meubel1
    {
        private string TypeMeubel { get; set; }
        private int Prijs { get; set; }

        public Meubel1(string typeMeubel, int prijs)
        {
            TypeMeubel = typeMeubel;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return TypeMeubel + Prijs;
        }
    }
}
