using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitja
            Random rndom = new Random();

            string mangija1 = "Sebastian";
            string mangija2 = "Martin";

            int sebastianthrow = rndom.Next(1, 7);
            int martinthrow = rndom.Next(1, 7);

            Console.WriteLine($"{mangija1} threw {sebastianthrow}.");
            Console.WriteLine($"{mangija2} threw {martinthrow}.");
            if (sebastianthrow > martinthrow)
            {
                Console.WriteLine($"{mangija1} võitis!");
            }
            else if (sebastianthrow < martinthrow)
            {
                Console.WriteLine($"{mangija2} võitis!");
            }
            else
            {
                Console.WriteLine($"{mangija1} ja {mangija2} jäid viiki.");
            }
            

        }
    }
}
