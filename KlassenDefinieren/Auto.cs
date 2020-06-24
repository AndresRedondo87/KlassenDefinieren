using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    public class Auto
    {
        public string marke;
        public int alterInJahren;

        public void BeschleunigeAuf100KmH()
        {
            if (this.IstSchnell())       //hier innerhalb Auto Klasse dürfen wir doch IstSchnell aufrufen.
            {
                Console.WriteLine("Habe schnell beschleunigt!");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt!!YEAH!!");
            }

        }

        private bool IstSchnell()   //private Methoden wird nur innerhalb von diese Klasse verfügbar
        {
            if (marke == "Porsche")
            {
                return true;
            }

            return false;
        }
    }

}

