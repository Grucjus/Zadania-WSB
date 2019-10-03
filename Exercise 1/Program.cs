using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do zadania 1");
            Console.Write("Podaj a: ");

            string aIn = Console.ReadLine();

            Console.Write("Podaj b: ");

            string bIn = Console.ReadLine();

            float a = float.Parse(aIn);
            float b = float.Parse(bIn);

            float m, n;

            m = a*a;
            m += b;
            n = a + b;
            n *= n;
            if (n == 0) Console.WriteLine("Nie dziel przez 0!");
            else 
            {
                m /= n;

                Console.WriteLine("Wartość wyrażenia to:" + m);
            }
        }
    }
}
