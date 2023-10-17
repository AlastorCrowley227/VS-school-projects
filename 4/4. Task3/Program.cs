namespace _4._Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double[] a = new double[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 100);
            }
            double b = a.Max();
            double c = a.Min();
            Console.WriteLine("Максимальное значение массива: " + b);
            Console.WriteLine("Минимальное значение массива: " + c);
        }
    }
}