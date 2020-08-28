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
        private double aktuelleGeschwindigkeitInKM;
        ///aktuelle geschw. als private weil wir es nur innen brauchen, wird nur von innen geaendert, nie von ausserhalb von der klasse.
        /// Video 72 - Das waere ein Beispiel fuer Datenkapselung.
        /// Wenn von extern den Attribut geaendert worden ist und wir muessen es zum Beispiel entfernen, müssen wir viel mehr aendern als wenn es nur gekapselt waere...
        /// So vermeiden wir dass es von aussen geaendert wird und wird flexibler wenn wir irgendwie die Inhaelte nur durch Methoden Aendern können
        /// Ich vermute hier kommen alle die get set erklaerungen... mal sehen.

        /// Video 70 - MiniUEbung, erweitere die Klasse Auto.
        /// -Aktuelle Geschwindigkeit speichern--DATEN
        /// -BeschleunigeAuf100KmH erhoeht die Geschw ---VERHALTEN
        /// -aktuelle Geschwindigkeit ausgeben---VERHALTEN

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
                aktuelleGeschwindigkeitInKM = 100;
                Console.WriteLine("Habe schnell beschleunigt!");
            }
            else
            {
                if (aktuelleGeschwindigkeitInKM <90)
                {
                    aktuelleGeschwindigkeitInKM += 10;
                }
                else
                {
                    aktuelleGeschwindigkeitInKM = 100;
                }
                Console.WriteLine("Habe normal beschleunigt!!YEAH!!");
            }

        }

        /// <summary>
        /// Aktuelle Geschwindigkeit Anzeigen
        /// </summary>
        public void AktuelleGeschwAnzeigen()
        {
            Console.WriteLine("Die aktuelle Geschwindigkeit ist: {0}", this.aktuelleGeschwindigkeitInKM);
            return;
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

