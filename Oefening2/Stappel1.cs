using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Stappel1<T>
    {
        private List<T> Stapellijst = new List<T>();
        private List<T> Stapellijst2 = new List<T>();

        public void DeStapel(T toevoegen)
        {
            Stapellijst.Add(toevoegen);
        }

        public T Delete()
        {
            if (Stapellijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            T updatedLijst = Stapellijst[Stapellijst.Count - 1];
            Stapellijst.RemoveAt(Stapellijst.Count - 1);

            return updatedLijst;
        }

        public void Stapelleegmaken()
        {
            Stapellijst.Clear();
        }

        public bool Aanwezig(T tezoeken)
        {
            foreach (T elements in Stapellijst)
            {
                if (elements.ToString() == tezoeken.ToString())
                {
                    return true;
                }
            }
            return false;

        }
        public override string ToString()
        {
            string lijst = "";

            foreach (T t in Stapellijst)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<T> lijstCopy()
        {
            Stapellijst2 = Stapellijst.GetRange(0, Stapellijst.Count);
            return Stapellijst2;
        }
    }
}
