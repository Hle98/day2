using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            double a, b, c, d,x1,x2,x;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            d = b*b - 4*a*c;
           
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2*a;
                x2 = (-b - Math.Sqrt(d)) / 2*a;
                Console.WriteLine($"The equation has 2 solutions: {x1} and {x2}");
            }
            else if (d == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine($"The equation has one solution: {x}");
            }
            else
            { 
                
            }

            
        }
    }
}
