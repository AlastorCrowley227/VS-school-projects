namespace _2._Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int u;
            double a = 0, c = 0, h = 0, S = 0, d = 0;

            Console.WriteLine("Введите номер элемента(от 1 до 4):");
                u = Convert.ToInt32(Console.ReadLine());

            while (u > 4 || u < 1)
            {
                Console.WriteLine("Значение не попадает в диапазон. Повторите ввод:");
                    u = Convert.ToInt32(Console.ReadLine());
            }

            switch (u) 
            {
                case 1:
                    Console.WriteLine("Введите значение катета a:");
                        a = Convert.ToDouble(Console.ReadLine());

                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    S = c * (h / 2);
                break;

                case 2:
                    Console.WriteLine("Введите значение гипотенузы:");
                        c = Convert.ToDouble(Console.ReadLine());

                    h = c / 2;
                    a = (h * 2) / Math.Sqrt(2);
                    S = c * (h / 2);
                break;

                case 3:
                    Console.WriteLine("Введите значение высоты:");
                        h = Convert.ToDouble(Console.ReadLine());

                    a = (h * 2) / Math.Sqrt(2);
                    c = a * Math.Sqrt(2);
                    S = c * (h / 2);
                break;

                default:
                    Console.WriteLine("Введите значение площади:");
                        S = Convert.ToDouble(Console.ReadLine());

                    c = Math.Sqrt(S * 4);
                    h = c / 2;
                    a = (h * 2) / Math.Sqrt(2);
                break; 
            }

            Console.WriteLine("\nКатет a: " + a);
            Console.WriteLine("Гипатенуза: " + c);
            Console.WriteLine("Высота: " + h);
            Console.WriteLine("Площадь: " + S);


        }
    }
}