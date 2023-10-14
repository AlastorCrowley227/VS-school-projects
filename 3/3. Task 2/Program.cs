namespace _3._Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, n, b, c = 0, k;
            Console.WriteLine("Введите количество чисел для последующего ввода:");
                n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число K:");
                k = Convert.ToInt32(Console.ReadLine());

            while (n > a)
            {
                a++;
                Console.WriteLine("Введите число:");
                    b = Convert.ToInt32(Console.ReadLine());
                if (b % k==0)
                {
                    c++;
                }
            }

            Console.WriteLine("Количество элементов кратных числу K: " + c);
        }
    }
}