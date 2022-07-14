using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Aufgabe 1----------------");
            Console.WriteLine(" ");

            //erstellung eines Objektes ohne Preisangabe - da vorgegeben
            Buch Buch1 = new Buch("B1", "Herr der Ringe", 244);

            Console.WriteLine(Buch1.Print());


            //erstellung eines Objektes mit allen Eigenschaften
            Buch Buch2 = new Buch("B2", "Herr der Ringe", 255.22, 244);
            Console.WriteLine(Buch2.Print());


            Console.WriteLine(" ");
            Console.WriteLine("---------------Aufgabe 2----------------");
            Console.WriteLine(" ");

            //erstellung von obj mit nur einer Titel Eigenschaftsangabe
            Kurs Kurs1 = new Kurs("Programmierung");

            Console.WriteLine(Kurs1.Print());

            Console.WriteLine("-----------------------------------");

            //erstellung von obj wo Werte von anderem Konstruktor übernommen werden (_titel)
            Kurs Kurs2 = new Kurs("Netzwerke", 350m);
            Console.WriteLine(Kurs2.Print());


            Console.WriteLine("-----------------------------------");

            //weitere erstellung zum Testen der Automatischen Nummervergabe
            Kurs Kurs3 = new Kurs("C# ist geil", 999m);
            Console.WriteLine(Kurs3.Print());


            //Damit die Console offenbleibt und ich nicht immer Strg+F5 drücken muss.
            Console.ReadLine();
        }
    }
}
