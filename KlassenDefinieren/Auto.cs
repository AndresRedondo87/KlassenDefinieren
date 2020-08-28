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

        ///ATTRIBUTEN:
        /// 1 muss zugriffsmodifizierer:
        /// Public muss definiert werden, sonst bleibt es internal als default.
        /// dann variablentyp und dann variablenname, kleingechrieben.
        public string marke;
        public int alterInJahren;

        ///METHODEN
        /// Methode, alle erst grossgeschrieben.
        /// <summary>
        /// BeschleunigeAuf100KmH
        /// </summary>
        public void BeschleunigeAuf100KmH()
        {
            if (this.IstSchnell())       //hier innerhalb Auto Klasse dürfen wir doch IstSchnell aufrufen.
            /// wie ist es mit den this?
            /// Um sicher zu gehen dass es auf die richtige Methode/Attribute bearbeitet/aufgerufen wird, bzw auf DIESE Objekt.
            /// Die Methoden sind grundsaetzlich zu ein Objekt oder eine Klasse aufgerufen(90% auf Objekten).
            /// Hier der Kompiler könnte ohne this arbeiten, aber so ist es viel eindeutiger was wir machen wollen 
            /// und auch um Quellcode zu lesen und verstehen.
            {
                Console.WriteLine("Habe schnell beschleunigt!");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt!!YEAH!!");
            }

        }

        private bool IstSchnell()   //private Methoden wird nur innerhalb von diese Klasse verfügbar!!
        {
            if (marke == "Porsche")
            {
                return true;
            }

            return false;
        }
    }

}

