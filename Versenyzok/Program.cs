using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Versenyzok
{
    class Program
    {
        static List<Pilota> pilotak = new List<Pilota>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat03();
            Feladat04();
            Feladat05();
            Feladat06();
            Feladat07();

            Console.WriteLine();
            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }

        private static void Feladat07()
        {
            Dictionary<byte, int> rajtszamok = new Dictionary<byte, int>();
            foreach (Pilota pilota in pilotak)
            {
                if (pilota.Rajtszam != 0)
                {
                    if (rajtszamok.ContainsKey(pilota.Rajtszam))
                    {
                        rajtszamok[pilota.Rajtszam]++;
                    }
                    else
                    {
                        rajtszamok.Add(pilota.Rajtszam, 1);
                    }
                }
            }
            //Key    - rajtszám értéke
            //Value  - rajtszám daraszáma
            Console.Write("7. Feladat: ");
            foreach (var rajtszam in rajtszamok)
            {
                if (rajtszam.Value > 1)
                {
                    Console.Write($" {rajtszam.Key},");
                }
            }

        }

        private static void Feladat06()
        {
            Pilota legkisebbRajtszamupilota = pilotak.First();
            foreach  (Pilota pilota in pilotak)
            {
                if (pilota.Rajtszam != 0 && pilota.Rajtszam < legkisebbRajtszamupilota.Rajtszam)
                {
                    legkisebbRajtszamupilota = pilota;
                }
            }
            Console.WriteLine($"6. feladat: {legkisebbRajtszamupilota.Nemzetiseg}");
        }

        private static void Feladat05()
        {
            Console.WriteLine("5. feladat: ");
            foreach (Pilota pilota in pilotak)
            {
                if (pilota.Szuletesi_datum.Year < 1901)
                {
                    Console.WriteLine($"\t{pilota.Nev} ({pilota.Szuletesi_datum.ToShortDateString()})");
                }
            }
        }

        private static void Feladat04()
        {
            // listában tudok első és utolsót kiválasztani, plusz lehetősgéem van indexelni is, ha mondjuk a 10. versenyző adatai kellenek!
            Pilota utolsoPilota = pilotak.Last();
            string utolsoPilotaNeve = pilotak.Last().Nev;
            Console.WriteLine($"4. feladat: {utolsoPilotaNeve}");

            //Console.WriteLine(pilotak[0].Nev); első név
            //Console.WriteLine(pilotak[pilotak.Count -1].Nev); utolsó neve indexeléssel || -1 mert a 0-ról indul!!
        }

        private static void Feladat03()
        {
            Console.WriteLine($"3. Feladat: {pilotak.Count}");
        }

        private static void Beolvasas()
        {
            foreach (string pilota in File.ReadAllLines("pilotak.csv").Skip(1))
            {
                pilotak.Add(new Pilota (pilota));
            }
        }
    }
}
