using System;
namespace Abeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            const double a = 4.1;
            const double b = -2.3;
            Console.WriteLine("Введите значение x: ");
                x = Convert.ToDouble(Console.ReadLine());

            double w = Math.Pow(x, 3) + Math.Pow(a, 2) * Math.Cos(2 * x) / x + Math.Cbrt(a + b * Math.Sin(3 * x));

            Console.WriteLine(w);
        }
    }
}