using System;
namespace ConsoleApp23
{
    class Program
    { 
        static void Main()
        {
            int p = 1;
            int n = 1;
            int L = 30000;
            while (p <= L)
            {
                n = n + 3;
                p = p * n;
               


            }
            Console.WriteLine(p);

        } 
    }

}