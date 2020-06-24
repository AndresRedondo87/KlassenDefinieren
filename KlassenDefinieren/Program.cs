/*****************************************
 TIC-TAC-TOE
  A   B   C
0   |   |
 ---+---+---
1   |   |
 ---+---+---
2   |   |
     

  A   B   C
0 X |   |
 ---+---+---
1   | O |
 ---+---+---
2   |   |

     
    Klassen - Kandidaten: Spieler, SpielKoordinaten, Feld, Spielstein, Spielbrett, Zug
    Attribute Kandidaten: Symbol des Spielsteins

    Verhalten: Spielstarten, ziehen im Wechsel, Platzieren, Anzeigen, Neuanzeigen, NeuesSpielBeginnen(neu), ProgrammVerlassen(Ende), MeldungFuerSpielEnde.

    Erste Klasse aus den Kandidaten: Spielbrett
    .... Beispiel Abgebrochen?

*****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    //auto Klasse haben wirvon hier rausgeschnitten, dann rechte maus auf Klassendefinieren/Hinzufügen/Klasse und da die klasse einfach umbennant. 
    //Jetzt ist ein getrennte Klassen Datei Auto.cs

    class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto();     //jedes Objekt ist eine neue Instanz von die Auto Klasse: mein und dein Auto
            Auto deinAuto = new Auto();

            //die methode istSchnell ist nicht unter meinAuto verfügbar, da es private definiert worden ist.
            meinAuto.alterInJahren = 13;
            meinAuto.marke = "Audi";

            deinAuto.alterInJahren = 1;
            deinAuto.marke = "Porsche";

            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();
        }
    }
}
