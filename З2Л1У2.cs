using System;
namespace ConsoleApp17
{

    class Program
    {
        static void Main()
        {
            int p = 1;
            for (int n = 1; n * p <= 30000; n = n + 3)

            {
                while (n * p <= 30000) 
                p = p * n;

                Console.WriteLine(p);

            }

        }
    }
}