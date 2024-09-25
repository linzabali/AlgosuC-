using System;
namespace ConsoleApp26;

class Program
{ 
    static void Main()
    {
         double i = 10;
        double s = 0;
        int days = 7;
        for (int p=1;p<=days;p++)
        {
            s = s + i;
            i=i*1.1;
        }
        Console.WriteLine(s);

    }
}

