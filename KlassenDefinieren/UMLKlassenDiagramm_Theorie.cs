using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    public class UMLKlasenDiagramm_Theorie
    {
        /// Video 75 UML Klassendiagramm -Eina Klasse zeichnen 
        /// Klassen:
        ///   ZugriffsModifizierer      (+public, - private)
        ///   Name
        ///   Datentyp
        ///   -------UML KLASSENDIAGRAM:
        ///   
        ///   --------------------------------------      Compartment (jede Kasten hier ist ein Compartment, fuer die 3 verschiedene Inhaelte:
        ///   |  AUTO                              |      NAME
        ///   |-marke:string                       |      ATTRIBUTE
        ///   |-alterInJahren:int                  |      
        ///   |-aktuelleGeschwindigkeitInKM:double |      
        ///   |------------------------------------|
        ///   |+Bremsen():void                     |       METHODEN/OPERATIONEN (): RUECKGABEWERT
        ///   |+BeschleunigeAuf100KmH:void         |                             (Parameter/n)
        ///   |-IstSchnell():bool                  |       ZugriffsModifizierer (+public, - private)
        ///   |------------------------------------|       Namen(parameter):Rueckgabewert
        ///   

        /// Video 76 UML Klassendiagramm - Beziehungen visualisieren
        /// Beziehungen sind sogar wichtiger als die Klassen selber
        /// Beziehungen = ASSOZIAZIONEN
        /// 
        ///  AUTO --------- HERSTELLER
        ///   |            /
        ///   |           /
        ///   |          /
        ///   |         /
        ///  MITARBEITER
        ///  In schema oben werden nicht gemalt aber wichtig sind die Pfeile enden und die Beziehung inzswischen:
        ///  Pfeile werden zeigen die Abhaengigkeiten. Je weniger abhaengigkeiten desto besser und einfacher wird diese Klasse zu evolvieren bzw. AEndern.
        ///  In Beispiel beide Pfeile zeigen nach auto, da die beiden Hersteller und Mitarbeiter sind vom Auto abhaengig.
        ///  Da ist auch wer weiss etwas ueber wer oder was, von Hersteller richtung Auto. 
        ///  Der mitarbeiter hat eine Beziehung zur Auto aber das Auto weiss nichts von Mitarbeiter
        ///  
        ///  

        /// Video 77 Model View Controller (MVC)- Design nach Mustern
        /// .
        /// .
        /// .   Benutzer  ---- interagiert ----  VIEW
        ///                                    /     \
        ///                                   /       \
        ///                         Eingabe/Ausgabe   holt Daten
        ///                                 /            \
        ///                                /              \
        /// .                       CONTROLLER-- aendert--MODEL
        /// 
        /// Um die Klassen besser zu strukturieren in OOP-bzw.OODesign
        /// Der benutzer interagiert grundsaetzlich mit den View (via Ein/Ausgaben)
        /// View zeigt die Daten die von Model geholt werden
        /// Der Controller kennt den View und damit kontrolliert er die Ein/Ausgaben und damit kann er das Model fuettern.
        /// Pfeile von Controller alle aus, von benutzer nach View und von view nach Model.
        /// Dieses Diagramm ist so gut wie eine Philosophie...
        /// Wird aber eigentlich gebraucht um der Design sauberer zu kriegen wenn wir dann entwickeln.
    }

}

