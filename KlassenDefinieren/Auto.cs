using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    public class Auto
    {
        /// 1 muss zugriffsmodifizierer:
        /// Public muss definiert werden, sonst bleibt es internal als default.
        /// 2 muss class und dann Klassenname(grossgeschrieben)
        /// 

        ///Attribute:
        /// 1 muss zugriffsmodifizierer:
        /// Public muss definiert werden, sonst bleibt es internal als default.
        /// dann variablentyp und dann variablenname, kleingechrieben.
        public string marke;
        public int alterInJahren;       

        /// <summary>
        /// Methode, alle erst grossgeschrieben.
        /// </summary>
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

