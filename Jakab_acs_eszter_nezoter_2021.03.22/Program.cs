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
            StreamReader beolvas = new StreamReader(@"C:\Users\Rendszergazda\Desktop\J_Eszter_prog_feladat\foglaltsag.txt");
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                adatok[n].foglaltsag = sor;
                n++;
            }
            beolvas.Close();

            n = 0;
            StreamReader beolvas2 = new StreamReader(@"C:\Users\Rendszergazda\Desktop\J_Eszter_prog_feladat\kategoria.txt");
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
            Console.WriteLine($"Az előadásra eddig {szamlalo} jegyet adtak el, ez a nézőtér {szamlalo  /  n * 100}");
            Console.ReadKey();
        }
    }
}
