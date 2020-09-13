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
        static void Main()
        {
            /// Video 69, Objekte anlegen und verändern
            /// Uebersetzung: ich will ein neues Objekt der klasse Auto erstellen, mit Name meinAuto. 
            /// Es ist dann ein neue Instanz von der Klasse Auto  erstellt mit erstmal keine "()" besondere eigenschaften
            //Auto meinAuto = new Auto();     //jedes Objekt ist eine neue Instanz von die Auto Klasse: mein und dein Auto
            //Auto deinAuto = new Auto();
            /// Video 73 Konstruktoren: jetzt der Kompiler hat kein standard Konstruktor mehr erzeugt da wir eins definiert haben, 
            /// deswegen sind die alte definitionen nicht mehr brauchbar.
            /// Die Attributen marke und aktuelleGeschwindigkeitInKM sind jetzt auch von aussen nocht mehr zu Aendern moeglich
            Auto meinAuto = new Auto("Audi");     
            Auto deinAuto = new Auto("Porsche");
            Auto andereAuto = new Auto("Renault");

            meinAuto.AlterInJahren = 13;
            //meinAuto.marke = "Audi";
            //meinAuto.aktuelleGeschwindigkeitInKM = 55;

            deinAuto.AlterInJahren = 1;
            //deinAuto.marke = "Porsche";
            //deinAuto.aktuelleGeschwindigkeitInKM = 45;


            andereAuto.AlterInJahren = 25;
            /// Video 74 Eigenschaften -  von ausserhalb von Auto klasse haben wir kein Zugriff mehr auf alterInJahren Attribut
            /// aber wir haben Zugriff auf den Eigenschaft AlterInJahren die es mit get/set aendern kann.


            meinAuto.AktuelleGeschwAnzeigen();
            deinAuto.AktuelleGeschwAnzeigen();
            andereAuto.AktuelleGeschwAnzeigen();

            /// Die Methoden sind grundsaetzlich zu ein Objekt oder eine Klasse aufgerufen(90% auf Objekten).
            /// die methode istSchnell ist nicht unter meinAuto verfügbar, da es private definiert worden ist.
            /// die methode BeschleunigeAuf100KmH ist  unter meinAuto verfügbar, da es public definiert worden ist.
            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();
            andereAuto.BeschleunigeAuf100KmH();

            meinAuto.AktuelleGeschwAnzeigen();
            deinAuto.AktuelleGeschwAnzeigen();
            andereAuto.AktuelleGeschwAnzeigen();
            //Console.ReadKey();

            Console.WriteLine();

            ///Video 104 String im Detail
            {

                //String text = "textooo"; String ist die klasse,string ist der bezeicher von eine objekt von String
                //String text = "textooo";
                string text = "textooo";   // == System.String text2 

                //ein string ist ein Zeichenkette, bzw eine reihenfolge von Zeichen.
                char einzeichen = text[2];

                // Ein String ist inmutable. Kann man nicht ändern.
                // um irgendwie zu ändern, muss man ein neu string definieren
                // INMUTABLE -> NICHT VERÄNDERBAT
                //text[2] = 's'; //geht gar nicht
                // es wird immer ein neuer string generiert.

                string hallo = "Hallo "; 
                string welt = "Welt";
                string halloWelt = hallo + welt;
                Console.WriteLine(halloWelt);

                string neueZeile = "\nin einer neue Zeile";
                Console.WriteLine(neueZeile);

                //Sonderzeichen ausgeben: mit backslash(Escapesequenzen)

                string neueZeile2 = "\nin einer \"neue\" Zeile.";
                Console.WriteLine(neueZeile);

                string pfad = "C:\\temp\\Ordner1zumBeispiel";
                Console.WriteLine(pfad);

                //Oder mit Verbatim string. Ein@ vor dem "" und alles wird direkt so wie sie sind ausgegeben.
                string verbatimPfad = @"C:\temp\Ordner1zumBeispiel";
                Console.WriteLine(verbatimPfad);
            }

            ///Video 105 Datetime
            {
                DateTime einBestimmterTag = new DateTime(1999, 12, 12);
                //wir haben kein Time eingegeben, ist auch ok


                DateTime einBestimmterTag2 = new DateTime(1999, 12, 12, 10, 55, 59);
                Console.WriteLine("Ein Tag: " + einBestimmterTag2);    // DateTime hat ein Tostring Methode, kann man einfach implizit aufgerufen sein

                Console.WriteLine("Ein Tag short: " + einBestimmterTag2.ToShortDateString());
                Console.WriteLine("Ein Tag long: " + einBestimmterTag2.ToLongDateString());
                Console.WriteLine("Ein Time long: " + einBestimmterTag2.ToLongTimeString());

                Console.WriteLine("Ein Tag +5: " + einBestimmterTag2.AddDays(5));   // Das ist eigentlich ein andere string



                DateTime jetzt =  DateTime.Now; //aktuelle Datum und Zeit hier
                Console.WriteLine("Jetzt ist: " + jetzt);
                Console.WriteLine("Jetzt ticks: " + jetzt.Ticks);   //ticks sind...ganz klein, "Einheit 100 Nanosekunden"

                DateTime jetztUTC = DateTime.UtcNow; //aktuelle Datum und Zeit in der UTC bzw koordinierter Weltzeit (Greenwich, bzw Spanien)
                Console.WriteLine("Jetzt in Spanien ist: " + jetztUTC);
            }

            ///Video 106 Timespan
            /// Zeitfenster
            {
                DateTime einBestimmterTag = new DateTime(2019, 12, 12);
                DateTime einAndererTag = new DateTime(2020, 07, 2);

                // Erstellen von TimeSpan Objekten
                Console.WriteLine("###Erstellen von TimeSpan Objekten! ###");

                // 1 - Konstruktor
                TimeSpan zeitSeitTagesBeginn = new TimeSpan(21,46,15);  //Zeitfenster zwischen Eingegebene Zeit und TagesAnfang 00:00... nicht so hilfreich

                // 2 - statische From-Methoden
                TimeSpan zeiVonMitternachtBisFruehstueck = TimeSpan.FromHours(10);

                // 3 - Rechnen mit Datetime Objekte
                TimeSpan zeitSeitDemLetztenVideo = einBestimmterTag - DateTime.Now; //Das hier ist praktischer.
                // addieren und substrahieren geht ohne Probleme
                TimeSpan eineStunde =  TimeSpan.FromHours(1);
                TimeSpan zehnMillisekunde = TimeSpan.FromMilliseconds(10.0);

                //addieren
                TimeSpan summe = eineStunde + zehnMillisekunde;
                TimeSpan summe2 = eineStunde.Add(zehnMillisekunde);

                TimeSpan diff = eineStunde - zehnMillisekunde;
                TimeSpan diff2 = eineStunde.Subtract(zehnMillisekunde);


                Console.WriteLine("Zeit Seit Mitternacht: " + zeitSeitTagesBeginn);
                Console.WriteLine("Zeit Seit Frühstück: " + zeiVonMitternachtBisFruehstueck);
                Console.WriteLine("Zeit Seit einen Tag: " + zeitSeitDemLetztenVideo);

                Console.WriteLine("Zeit summe 1 Stunde und 10 ms: " + summe);
                Console.WriteLine("Zeit summe 1 Stunde und 10 ms: " + summe2);
                Console.WriteLine("Zeit substr 1 Stunde und 10 ms: " + diff);
                Console.WriteLine("Zeit substr 1 Stunde und 10 ms: " + diff2);


                // Minutes vs TotalMinutes  AUFPASSEN: minutes zeigt nur die minuten, aber nicht die Stunden umgerechnet. 
                //TOTALMINUTES wird die Stunden umrechnen, oder die groessere Einheit so zu sage
                Console.WriteLine("Minutes vs TotalMinutes:");

                TimeSpan dauerVonAufstehenBisFruehstueck = new TimeSpan(2, 30, 0);
                Console.WriteLine(dauerVonAufstehenBisFruehstueck.Minutes);         
                Console.WriteLine(dauerVonAufstehenBisFruehstueck.TotalMinutes);

                //String nach Timespan konvertieren AUCH SEHR WICHTIG!!!
                Console.WriteLine("String nach Timespan konvertieren");
                string gueltigeDauerString = "20:35:45";
                string ungueltigeDauerString = "20:35:75"; //75 Sekunde gibt es gar nicht


                // TimeSpan hat auch das TryParse, gibt bool zurück wenn es machbar ist, den string zu konvertieren
                // und auch als out, gibt uns der entsprechende Timespan Wert oder null (00:00:00)
                TimeSpan gueltigeDauer;
                TimeSpan.TryParse(gueltigeDauerString, out gueltigeDauer);         
                TimeSpan ungueltigeDauer;

                TimeSpan.TryParse(ungueltigeDauerString, out ungueltigeDauer);

                Console.WriteLine(gueltigeDauer);
                Console.WriteLine(ungueltigeDauer);

            }


            Console.ReadKey();
        }
    }
}
