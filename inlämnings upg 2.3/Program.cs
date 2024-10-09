using System;
namespace inlämnings_upg_2._3
{
    class Program
    {
        static void Main(string[] args)
        {

             decimal Startavgift = 300m;
             decimal perkm = 1m;
             decimal perdag = 500m;

            Console.Write("skriv Hur många dagar du vill hyra bilen: ");
            int Hyrdagar = int.Parse(Console.ReadLine());

            Console.Write("Skriv hur många km du tänker köra: ");
            int km = int.Parse(Console.ReadLine());

            decimal totalCost = Startavgift + (km * perkm) + ((Hyrdagar - 1) * perdag);

            Console.WriteLine("Totala kostnaden kommer vara: " + totalCost);

        }
    }
}
