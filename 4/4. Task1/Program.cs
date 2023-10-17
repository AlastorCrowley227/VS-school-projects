namespace _4._Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите количество значений массива:");
            int n = Convert.ToInt32(Console.ReadLine()) + 1;
            double[] a = new double[n];
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Введите значение массива №" + i + ":");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (a[i] < 0) {
                    s++;
                }
            }
            Console.WriteLine("Количество отрицательных значений массива: " + s);
        }
    }
}