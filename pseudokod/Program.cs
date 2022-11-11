using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int svar = 0;
            while (svar != 2)
            {
                Console.WriteLine("Vad vill du köpa?");
                Console.WriteLine("1. Tomat");
                Console.WriteLine("2. Gurka");
                Console.WriteLine("3. Majs");

                string vara = "1";

                switch (vara)
                {
                    case "1":
                        Console.WriteLine("Tomat kostar 80 kr/kg");
                        Console.WriteLine("Vill du fortfarande köpa tomat?");
                        Console.WriteLine("1. Ja");
                        Console.WriteLine("2. Nej");
                        svar = int.Parse(Console.ReadLine());
                        break;
                }

            }
        }
    }
}
