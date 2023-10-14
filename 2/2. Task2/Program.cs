namespace _2._Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, S;
            Console.WriteLine("Введите значение a:");
                a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
                b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h:");
                h = Convert.ToDouble(Console.ReadLine());

            if (h == 0)
            {
                S = a * b; 
            }
            
            else if (a == b)
            {
                S = a * a;
            }

            else
            {
                S = ((a + b) / 2) * h;
            }

            Console.WriteLine("Ответ: " + S);
        }
    }
}