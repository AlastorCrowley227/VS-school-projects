namespace _2._Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, y;
            const double a = 2.2;
            const double b = 0.3;

            Console.WriteLine("Введите занчение i:");
                i = Convert.ToDouble(Console.ReadLine());

            while (i > 12 || i < 7)
            {
                Console.WriteLine("Значение не попадает в диапазон. Повторите ввод:");
                    i = Convert.ToDouble(Console.ReadLine());
            }

            if (i <10)
            {
                y = a * Math.Pow(i, 4) + b * i;
            }

            if (i == 10)
            {
                y = Math.Tan(i + 0.5);
            }

            else
            {
                y = Math.Pow(Math.E, 2 * i) + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(i, 2));
            }
            
            Console.WriteLine("Ответ: " +  y);
        }
    }
}