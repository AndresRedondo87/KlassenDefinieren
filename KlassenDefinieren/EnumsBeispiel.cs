using System;

namespace Enums
{
    /// <summary>
    /// Enum Definieren:
    /// immer direkt unter namespace, nicht in der Klasse drinnen
    /// immer public, Schluesselwort enum, Name
    /// Die Bezeichnern bekommen ein Wert automatisch zugewiesen, 
    /// kann man aber selber setzen, die folgenden bekommen einfach +1 sequenziell weiter hochgezaehlt
    /// Ein enum ist mit int Werte gebaut
    /// 
    /// Ein Enum wird üblicherweise ausserhalb einer Klasse im Namespace angelegt. 
    /// Dann ist es immer public und der Name der Enum sollte in Pascal-Case-Notation 
    /// (erster Buchstabe und jeder Buchstabe eines Wortes groß) geschrieben sein.
    /// Die einzelnen Bezeichner(porsche und audi) in dieser Enum sind durch Komma getrennt 
    /// und werden automatisch vom Compiler aufsteigend(beginnend bei 0) nummeriert.
    /// </summary>
    public enum AutoMarke
    {
        porsche,
        audi
    }

    public class AutomarkenBeispiel
    {
        const int porsche = 1;
        const int audi = 2;

        public static void Ausfuehren()
        {
            //erstmal eine variable davon anlegen
            AutoMarke meinAuto = AutoMarke.audi;

            //GibAutoMarkeAus(372);
            //dies ist nicht mehr erlaubt da die parameter unter den enum sein muss

            GibAutoMarkeAus(meinAuto);

            Console.WriteLine("Die Marke meines Autos: " + meinAuto.ToString());
        }

        private static void GibAutoMarkeAus(AutoMarke marke)        //hier auch angepasst
        {
            string ausgabe;

            switch (marke)
            {
                case AutoMarke.porsche:                               //hier auch angepasst
                    ausgabe = "Du fährst ein Auto der Marke: Porsche";
                    break;
                case AutoMarke.audi:                                  //hier auch angepasst
                    ausgabe = "Du fährst ein Auto der Marke: Audi";
                    break;
                default:
                    ausgabe = "Deine Automarke kenne ich nicht";
                    break;
            }

            Console.WriteLine(ausgabe);
        }

        private static void Beschleunige(string autoMarke)
        {
            if (autoMarke == "Audi")
            {
                Console.WriteLine("Dein Audi beschleunigt so langsam auf 100km/h.");
            }
            else if (autoMarke == "Porsche")
            {
                Console.WriteLine("Dein Porsche rast auf 100km/h");
            }
            else
            {
                Console.WriteLine("Deine mir nicht bekannte Automarke wird auch irgendwann bei 100km/h sein.");
            }
        }
    }
}
