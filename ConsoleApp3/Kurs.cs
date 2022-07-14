using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Kurs
    {
        //der Counter für das Auto_Increment bei Nummer
        private static uint anzahl = 0;
        public static uint Anzahl
        {
            get { return anzahl; }
        }

        //Eigenschaften mit vergabe von get und set 
        public string Nummer { get; private set;}
        public string Titel { get; set; }
        public decimal Preis { get; set; }

        private const string kurs = "IT";

        //erstellung eines Konstruktors mit der Titel eingabe, festen Preisangabe und einer sich automatisch erweiterten Nummer var (Auto_increment)
        public Kurs(string _titel)
        {
            //anzahl der erzeugten objekte wird addiert +1
            anzahl++;

            //wird automatisch ausgefüllt
            Nummer = "K" + anzahl;

            //der Titel muss festgelegt werden
            this.Titel = _titel;
            Preis = 500.00m;
        }

        //einrichtung eines verweises mit :this (variable) - hier beziehen sich die variablen auf den bestimmten Konstruktor
        public Kurs(string _titel, decimal _preis):this (_titel)
        {
            this.Preis = _preis;
        }


        //ausgabe aller eigenschaften mit einer Methode
        public string Print()
        {
            return Nummer + " | " + Titel + " | " + Preis + " | " + kurs;
        }
    }
}
