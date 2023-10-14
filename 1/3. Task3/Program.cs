namespace Abube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sm, dm, m;
            Console.WriteLine("Введите значение в сантиметрах:");
                sm = Convert.ToDouble(Console.ReadLine());

            dm = sm / 10;
            m = sm / 100;
            
            Console.WriteLine("Дециметров: " + dm);
            Console.WriteLine("Метров: " + m);


        }
    }
}