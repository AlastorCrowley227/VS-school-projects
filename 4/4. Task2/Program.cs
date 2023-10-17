using System.Linq;
namespace _4._Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите количество значений массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите значение массива №" + (i+1) + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int e = a.Max();
            int b = a.Min();
            int c = e - b;
            Console.WriteLine("Разница между максимальным и минимальным - " + c);
        }
    }
}