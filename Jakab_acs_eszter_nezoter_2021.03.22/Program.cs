using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jakab_acs_eszter_nezoter_2021._03._22
{
    class Program
    {
        struct Adat
        {
            public string foglaltsag;
            public string kategoria;
        }

        /*struct Adat_uj
        {

        }*/
        static void Main(string[] args)
        {
            Adat[] adatok = new Adat[15];
            int n = 0;
            StreamReader beolvas = new StreamReader(@"E:\OneDrive - Kisvárdai SZC Móricz Zsigmond Szakgimnáziuma és Szakközépiskolája\Oktatas\Programozas\Jakab_Acs_Eszter\Erettsegi_feladatok\2014-oktober_uj\foglaltsag.txt");
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                adatok[n].foglaltsag = sor;
                n++;
            }
            beolvas.Close();

            n = 0;
            StreamReader beolvas2 = new StreamReader(@"E:\OneDrive - Kisvárdai SZC Móricz Zsigmond Szakgimnáziuma és Szakközépiskolája\Oktatas\Programozas\Jakab_Acs_Eszter\Erettsegi_feladatok\2014-oktober_uj\kategoria.txt");
            while (!beolvas2.EndOfStream)
            {
                string sor = beolvas2.ReadLine();
                adatok[n].kategoria = sor;
                n++;
            }
            beolvas2.Close();
            Console.WriteLine("1.feladat\nBeolvasás kész!");

            //2.feladat
            Console.WriteLine("Kérem adja meg a sor számát: ");
            int sorszam = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a szék számát: ");
            int szekszam = int.Parse(Console.ReadLine());
            for (int i = 0; i<=sorszam; i++)
            {
                if (i+1 == sorszam)
                {
                    
                }
            }
            Console.ReadKey();
        }
    }
}
