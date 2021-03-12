using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar
{
    class Program
    {
        static List<Fuvar> fuvarok;
        static void Main(string[] args)
        {
            Beolvas();
            Feladat3();
            Feladat4(6185);
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();

            Console.WriteLine("program vége");
            Console.ReadKey();
        }

        private static void Feladat8()
        {
            
        }

        private static void Feladat7()
        {
            int leghosszabb_fuvar = fuvarok[0].Idotartam;
            int index = 0;
            for (int i = 0; i < fuvarok.Count; i++)
            {
                if (fuvarok[i].Idotartam > leghosszabb_fuvar)
                {
                    leghosszabb_fuvar = fuvarok[i].Idotartam;
                    index = i;
                }
            }

            Console.WriteLine($"7. Feladat: Leghosszabb fuvar:\n\tFuvar hossza: {fuvarok[index].Idotartam} másodperc" +
                $"\n\tTaxi azonosító: {fuvarok[index].Taxi_id}\n\tMegtett távolság: {fuvarok[index].Tavolsag * 1.6} km\n\tViteldíj: {fuvarok[index].Viteldij}$");
        }

        private static void Feladat6()
        {
            double ossz_km = 0;
            foreach (var fuvar in fuvarok)
            {
                ossz_km += fuvar.Tavolsag;
            }

            Console.WriteLine($"6. feladat: {Math.Round(ossz_km * 1.6, 2)}km");
        }

        private static void Feladat5()
        {
            Console.WriteLine($"5. feladat: ");
        }

        private static void Feladat4(int taxi_id)
        {
            double bevetel = 0;
            int fuvarok_szama = 0;
            foreach (var fuvar in fuvarok)
            {
                if (fuvar.Taxi_id == taxi_id)
                {
                    bevetel += fuvar.Borravalo + fuvar.Viteldij;
                    fuvarok_szama++; 
                }
            }

            Console.WriteLine($"4. feladat: {fuvarok_szama} alatt: {bevetel}$");
        }

        private static void Feladat3()
        {
            Console.WriteLine($"3. Feladat: {fuvarok.Count()} fuvar");
        }

        private static void Beolvas()
        {
            fuvarok = new List<Fuvar>();
            using (StreamReader sr = new StreamReader("fuvar.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    int taxi_id = int.Parse(sor[0]);
                    DateTime indulas = DateTime.Parse(sor[1]);
                    int idotartam = int.Parse(sor[2]);
                    double tavolsag = double.Parse(sor[3]);
                    double viteldij = double.Parse(sor[4]);
                    double borravalo = double.Parse(sor[5]);
                    string fizetes_modja = sor[6];

                    Fuvar fuvar = new Fuvar(taxi_id, indulas, idotartam, tavolsag, viteldij, borravalo, fizetes_modja);
                    fuvarok.Add(fuvar);
                }
            }
        }
    }
}
