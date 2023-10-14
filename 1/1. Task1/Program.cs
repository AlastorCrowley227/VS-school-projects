using System;
namespace sus
{
    class sus
    {
        static void Main()
        {
            double x, y;
            bool p = false;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            if (x >= -7 && x <= 0 && y <= 0 && y >= -1)
            {
                p = true;
            }
            Console.WriteLine(p);
        }
    }
}
