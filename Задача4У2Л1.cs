using System;
namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            const double eps = 0.0001;
            double s = 1,a;
            
            int n = 1;
            do
            {
               if (Math.Abs(x) < 1);
                a = Math.Pow(x, 2 * n);
                s = s + a;
                n = n * 2;

            }
            while (a > eps);
            Console.WriteLine(s);


        }
    }
}