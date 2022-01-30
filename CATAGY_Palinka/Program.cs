using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATAGY_Palinka
{
    internal class Program
    {
        static Random rnd = new Random();
        static List<Palinka> palinkak = new List<Palinka>();
        static void Main(string[] args)
        {
            Inicializalas();
            Osszpalinka();
            Palinkavalasztas();
        }

        private static void Palinkavalasztas()
        {
            double bevetel = 0;
            int counter1 = 1;
            Console.WriteLine("Vásárlások: ");
            for (int i = 0; i < 50; i++)
            {
                var kivalasztott = palinkak[rnd.Next(palinkak.Count)];
                if (kivalasztott.Mennyiseg != 0)
                {
                    kivalasztott.Mennyiseg -= kivalasztott.Mennyiseg / 2;
                    bevetel += (kivalasztott.Mennyiseg / 2) * kivalasztott.Ar;
                    Console.WriteLine($"{counter1}. Kiválaszott pálinka: {palinkak.IndexOf(kivalasztott) + 1}. számú {kivalasztott.Gyumolcs} pálinka - Bevétel: {(kivalasztott.Mennyiseg / 2F) * kivalasztott.Ar}");
                    counter1++;
                }
                else
                {
                    i--;
                    continue;
                }               
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Összbevétel: " + bevetel + "Ft\n" + "A pálinkák listája frissítve: \n");
            var counter = 1;
            foreach (var palesz in palinkak)
            {
                Console.WriteLine($"{counter} || Fok: {palesz.Fok} || Gyümölcs: {palesz.Gyumolcs} || Mennyiség: {palesz.Mennyiseg} dl || Készült: {palesz.Keszult} || Ára: {palesz.Ar} Ft/dl ");
                counter++;
            }
        }

        private static void Osszpalinka()
        {
            var osszPalinka = palinkak.Sum(x => x.Mennyiseg) / 10F;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Összpálinka mennyiség: {osszPalinka} liter");
        }

        private static void Inicializalas()
        {
            for (int i = 0; i < 20; i++)
            {
                palinkak.Add(new Palinka(
                    fok: rnd.Next(30, 88),
                    gyumolcs: (Gyumolcs)rnd.Next(Enum.GetNames(typeof(Gyumolcs)).Length),
                    mennyiseg: rnd.Next(0, 51),
                    keszult: rnd.Next(2000, DateTime.Now.Year),
                    ar: rnd.Next(50, 1001)
                    ));
            }

            Console.WriteLine("Pálinkák: ");
            var counter = 1;
            foreach (var palesz in palinkak)
            {
                Console.WriteLine($"{counter} || Fok: {palesz.Fok} || Gyümölcs: {palesz.Gyumolcs} || Mennyiség: {palesz.Mennyiseg} dl || Készült: {palesz.Keszult} || Ára: {palesz.Ar} Ft/dl ");
                counter++;
            }
        }
    }
}
