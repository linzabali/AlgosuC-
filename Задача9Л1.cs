using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            double s = 0,a;
            int d = 1;
            for (int i=1;i<=6;i=i+1)
            {
                d = d * i;
                a = Math.Pow(-1, i) * Math.Pow(5, i) / d;
                s = s + a;
                Console.WriteLine(s);
            }
        }
    }
}