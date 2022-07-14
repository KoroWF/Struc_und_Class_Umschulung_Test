using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Buch
    {

        //Zuweisung der einzelnen Variablen für die Klasse Buch
        private string Nummer;
        private string Titel;
        private uint Seitenzahl;

        public double Preis;

        //Konstrukter für vergabe der gesamten Eigenschaften des Buches
        public Buch(string _Nummer, string _Titel, double _Preis, uint _Seitenzahl)
        {
            Nummer = _Nummer;
            Titel = _Titel;
            Preis = _Preis;
            Seitenzahl = _Seitenzahl;
        }


        //Konstrukter für vergabe der gesamten Eigenschaften des Buches - ohne Preis
        public Buch(string _Nummer, string _Titel, uint _Seitenzahl)
        {
            Nummer = _Nummer;
            Titel = _Titel;
            Preis = 50;
            Seitenzahl = _Seitenzahl;
        }

        //Methode für ausgabe aller Werte eines Produkts
        public string Print()
        {
            return Nummer + "|" + Titel + "|" + Preis + "|" + Seitenzahl;
        }

    }
}