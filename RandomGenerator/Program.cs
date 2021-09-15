using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //programm kontrollib, kas genereeritud number on 
            //suurem, kui 5
            //kui number on suurem, kui 5, siis konsool kuvab
            //"juhuslik number on {MyRandomNumber}, see on suurem,
            //kui 5";
            //kui number on väiksem, kui 5, konsool kuvab
            //juhuslik number on {MyRandomNumber}, see on väiksem
            //kui 5";
            //kui number on 5, siis konsool kuvab "juhuslik number on 5"

            Random rndom = new Random();

            int RandomNumber = rndom.Next(1, 11);

            Console.WriteLine(RandomNumber);

            if (RandomNumber > 5)

            {
                Console.WriteLine($"Juhuslik number on {RandomNumber}, see on suurem, kui 5.");
            }

            else if (RandomNumber < 5)

            {
                Console.WriteLine($"Juhuslik number on {RandomNumber}, see on väiksem, kui 5.");
            }

            else

            {
                Console.WriteLine("Juhuslik number ongi 5.");
            }
        }
    }
}
