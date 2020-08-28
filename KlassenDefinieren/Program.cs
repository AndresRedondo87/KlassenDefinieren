/*****************************************
 
            //Video 32 Versionskontrolle (Git) - Das Sicherheitsnetz für deinen Taschenrechner
            // das habe ich schon eigentlich selber erledigt!!!
            
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
    /// Video 68 auto Klasse haben wirvon hier rausgeschnitten, dann rechte maus auf Klassendefinieren/Hinzufügen/Klasse und da die klasse einfach umbennant. 
    ///Jetzt ist ein getrennte Klassen Datei Auto.cs
    /// Am besten immer nur eine Klase Pro datei. so bleit alles sauberer und mit bessere Nachverfolgbarkeit
    class Program
    {
        static void Main(string[] args)
        {
            /// Video 69, Objekte anlegen und verändern
            /// Uebersetzung: ich will ein neues Objekt der klasse Auto erstellen, mit Name meinAuto. 
            /// Es ist dann ein neue Instanz von der Klasse Auto  erstellt mit erstmal keine "()" besondere eigenschaften
            Auto meinAuto = new Auto();     //jedes Objekt ist eine neue Instanz von die Auto Klasse: mein und dein Auto
            Auto deinAuto = new Auto();
            
            meinAuto.alterInJahren = 13;
            meinAuto.marke = "Audi";

            deinAuto.alterInJahren = 1;
            deinAuto.marke = "Porsche";

            /// Die Methoden sind grundsaetzlich zu ein Objekt oder eine Klasse aufgerufen(90% auf Objekten).
            /// die methode istSchnell ist nicht unter meinAuto verfügbar, da es private definiert worden ist.
            /// die methode BeschleunigeAuf100KmH ist  unter meinAuto verfügbar, da es public definiert worden ist.
            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();
        }
    }
}
