using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Meubel
    {
        private string TypeMeubel { get; set; }
        private int Prijs { get; set; }

        public Meubel(string typeMeubel, int prijs)
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
