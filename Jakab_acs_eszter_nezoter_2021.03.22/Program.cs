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
            for (int i = 0; i<n; i++)
            {
                if (i == sorszam-1)
                {
                    if(adatok[i].foglaltsag.Substring(szekszam-1,1) == "x")
                    {
                        Console.WriteLine("A hely nem szabad.");
                    }
                    else
                    {
                        Console.WriteLine("A hely még szabad.");
                    }
                }
            }

            //3.feladat
            const int nezoszam = 15 * 20;
            //Console.WriteLine(nezoszam);
            int szamlalo = 0;
            for (int i=0; i<n; i++)
            {
                for (int k=0; k<adatok[i].foglaltsag.Length;k++)
                {
                    if (adatok[i].foglaltsag[k] == 'x')
                    {
                        szamlalo++;
                    }  
                }
            }
            Console.WriteLine($"Az előadásra eddig {szamlalo} jegyet adtak el, ez a nézőtér {Math.Round((double)szamlalo  /  nezoszam * 100,0)}%-a.");

            //4.feladat
            int leg = 0;
            int egy = 0, ketto = 0, harom = 0, negy = 0, ot = 0;
            for (int i = 0;i<n;i++)
            {
                for (int k = 0;k<adatok[i].foglaltsag.Length;k++)
                {
                    if (adatok[i].foglaltsag[k] == 'x')
                    {
                        if (adatok[i].kategoria[k] == '1')
                        {
                            egy++;
                        }
                        if (adatok[i].kategoria[k] == '2')
                        {
                            ketto++;
                        }
                        if (adatok[i].kategoria[k] == '3')
                        {
                            harom++;
                        }
                        if (adatok[i].kategoria[k] == '4')
                        {
                            negy++;
                        }
                        if (adatok[i].kategoria[k] == '5')
                        {
                            ot++;
                        }
                    }
                }

            }
            int[] legnagyobb = { egy, ketto, harom, negy, ot };
            int j = 0;
            for (int i = 0; i<legnagyobb.Length; i++)
            {
                if (legnagyobb[i] > leg)
                {
                    leg = legnagyobb[i];
                    j = i;
                }
            }
            Console.WriteLine($"A legtöbb jegyet a(z) {j+1}. árkategóriában értékesítették.");

            //5.feladat

            Console.ReadKey();
        }
    }
}
