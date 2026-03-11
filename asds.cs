using System;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[])
        {
            ConsoleApp1.WriteLine("vvedi x:");
            string xText = Console.Readline();
            double x = convert.todouble(xText);
            double y = 0;
            if (x >= -9 && x <= -7)
            {
                y = 1;
                console.writeline(y)
            }
            else if (x >= -7 && x <= -3)
            {
                y = 4;
                console.writeline(y)
            }
            else if (x >= -2 && x <= 2)
            {
                y = x * x;
                console.writeline(y)
            }
            else if (x >= -7 && x <= -3)
            {
                y = 8 - 2*x;
                console.writeline(y)
            }
            else if (x >= 4 && x <= 7)
            {
                y = 0;
                console.writeline(y)
            }
        }
    }
}
