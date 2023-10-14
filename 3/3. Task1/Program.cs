using System;
namespace _3._Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, b = 0, c = 0;
            Console.WriteLine("Введите количество чисел для последующего ввода:");
                n = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; n > a; a++)
            {
                Console.WriteLine("Введите число:");
                    b = Convert.ToInt32(Console.ReadLine());
                if (b % 2 != 0)
                {
                    c += b;
                }
            }
            Console.WriteLine("Сумма нечетных чисел последовательности: " + c);
                //if (string.IsNullOrWhiteSpace(a)) break;

                
        }
    }
}