using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KlassenDefinieren
{
    public class Auto
    {
        /// 1 muss zugriffsmodifizierer:
        /// Public muss definiert werden, sonst bleibt es internal als default.
        /// 2 muss class und dann Klassenname(grossgeschrieben)

        ///ATTRIBUTEN: ---> PROPERTIES (EIGENSCHAFTEN)
        /// 1 muss zugriffsmodifizierer:
        /// Public muss definiert werden, sonst bleibt es internal als default.
        /// dann variablentyp und dann variablenname, kleingechrieben.
        /// private string marke;   //Updated in Video 73, da es nicht geandert sein konnen sollte
        ///public int alterInJahren;
        ///private double aktuelleGeschwindigkeitInKM;
        ///aktuelle geschw. als private weil wir es nur innen brauchen, wird nur von innen geaendert, nie von ausserhalb von der klasse.
        /// Video 72 - Das waere ein Beispiel fuer Datenkapselung.
        /// Wenn von extern den Attribut geaendert worden ist und wir muessen es zum Beispiel entfernen, müssen wir viel mehr aendern als wenn es nur gekapselt waere...
        /// So vermeiden wir dass es von aussen geaendert wird und wird flexibler wenn wir irgendwie die Inhaelte nur durch Methoden Aendern können
        /// Ich vermute hier kommen alle die get set erklaerungen... mal sehen.
        /// Video 74 Properties oder Eigenschaften - Kein direkter Zugriff auf attributen bitte!! -->get und set.
        /// Propfull+tab+tab
        /// dann Attribut umbenennen und Eigenschaft Name ist das gleiche mit erste Grossgeschrieben.
        ///private int alterInJahren;  //Attribut, ist private.
        ///public int AlterInJahren    //Eigenschaft, ist Public
        ///{
        ///    get { return alterInJahren; }   //von aussen lesen
        ///    set { alterInJahren = value; }  //von aussen aendern
        ///}
        /// extra auf Video 74 - Property auch fuer aktuelleGeschwindigkeitInKM
        ///Video 74 KURZSCHREIBWEISE mit prop+tab+tab, Enorme Vorteile, kann man hier einfacher aendern als ein Attribut,
        ///so immer viel besser Eigenschaften verwenden anstatt direkte Attributen um besser arbeiten zu koennen.
        ///dannach koennen auch besser die grenzen und generell alles bearbeiten von der Attribut via seine Property(Eigenschaft)
        ///immer nur in die entsprechende klasse rein, und nicht ueberall in unserer Programm
        public int AlterInJahren { get; set; }
        public double aktuelleGeschwindigkeitInKM { get; set; }

        private string marke;

        public string Marke
        {
            get { return marke; }
            set
            { // wir koennen auch die eingegebenen werte ueberpruefen, zB. hier akzeptieren wir nur Audi und Prosche als akzeptierte Marken:
                if ((value == "Porsche") || (value == "Audi"))
                {
                    marke = value;
                }
                else
                {
                    marke = "nicht unterstütze Marke";
                }
            }
        }


        /// Video 70 - MiniUEbung, erweitere die Klasse Auto.
        /// -Aktuelle Geschwindigkeit speichern--DATEN
        /// -BeschleunigeAuf100KmH erhoeht die Geschw ---VERHALTEN
        /// -aktuelle Geschwindigkeit ausgeben---VERHALTEN

        ///METHODEN
        /// Methode, alle erst grossgeschrieben.
        /// 

        /// <summary>
        /// Video 108 ToString() Methode - Objekte in String umwandeln
        /// </summary>
        /// 
        public override string ToString()   // mit den override aendern wir das original ToString zu unsere Wuensche.
            // Diese ToString wird auch die Private Eigenschaften ausgeben koennen
        {
            //Console.WriteLine($"Marke: {this.Marke}");
            //Console.WriteLine($"Alter In Jahren: {this.AlterInJahren}");
            //Console.WriteLine($"aktuelle Geschwindigkeit InKM: {this.aktuelleGeschwindigkeitInKM}");
            //return base.ToString(); //base ist von vererbung usw...
            //Diese oben fuer die Darstellung direkt in Konsole

            // um dieses string so intern zu benutzen aber nicht direkt in cw zu verwenden
            string resultat = $"Marke: {this.Marke}" + Environment.NewLine;
            resultat += $"Alter In Jahren: {this.AlterInJahren}" + Environment.NewLine;
            resultat += $"aktuelle Geschwindigkeit InKM: {this.aktuelleGeschwindigkeitInKM}" + Environment.NewLine;
            return resultat;


            //// Composite formatting:
            //Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            //// String interpolation:
            //Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            //// Both calls produce the same output that is similar to:
            //// Hello, Mark! Today is Wednesday, it's 19:40 now.

        }


        /// Video 114 Folge 5 Objekte Speichern und laden.
        /// Erster Versuch zu speichern Eigentlich hier ist es zum laden :/
        public Auto(string csvString)
        {
            string[] csvEntries = csvString.Split(',');

            Marke = csvEntries[0];
            aktuelleGeschwindigkeitInKM = Convert.ToInt32(csvEntries[1]);
            AlterInJahren = Convert.ToInt32(csvEntries[2]);
        }

        /// <summary>
        /// Video 73 Konstruktoren: Um den Inhalt von Atributen zu schuetzen von falschen eingaben, Datenkapselung
        /// </summary>
        /// 
        //public Auto(string autoMarke)     //Veraltet seit video 114
        //{
        //    Marke = autoMarke;
        //    AlterInJahren = 0;
        //    aktuelleGeschwindigkeitInKM = 0;
        //}


        /// <summary>
        /// BeschleunigeAuf100KmH
        /// </summary>
        /// 
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
                Console.WriteLine("Der {0} hat schnell beschleunigt!!YEAH!!!", this.marke);
            }
            else
            {
                if (aktuelleGeschwindigkeitInKM < 90)
                {
                    aktuelleGeschwindigkeitInKM += 10;
                }
                else
                {
                    aktuelleGeschwindigkeitInKM = 100;
                }
                Console.WriteLine("Der {0} hat normal beschleunigt", this.marke);
            }

        }

        /// <summary>
        /// Aktuelle Geschwindigkeit Anzeigen
        /// </summary>
        public void AktuelleGeschwAnzeigen()
        {
            Console.WriteLine("Die aktuelle Geschwindigkeit von der {1} ist: {0}", this.aktuelleGeschwindigkeitInKM, this.marke);
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

        ///
        /// Video 114 Folge 5 Objekte Speichern und laden.
        /// Erster Versuch zu speichern
        public string ToCsvString()
        {
            return $"Marke:{Marke}, Geschw.InKmH:{aktuelleGeschwindigkeitInKM},AlterJahre{AlterInJahren}";//funktioniert
        }



    }


}

