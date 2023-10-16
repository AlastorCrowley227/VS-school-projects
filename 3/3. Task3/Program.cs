namespace _3._Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 19, n = 0, S = 0;

            Console.WriteLine("Введите количество слагаемых:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                S = 15;
                goto sus;
            }

            else if (n == 2)
            {
                S = 15 + 17;
                goto sus;
            }

            S = 15 + 17;
            n -= 2;

            do
            {
                if (n > 3)
                {
                    S -= c;
                    c += 2;
                    S += c;
                    c += 2;
                    S += c;
                    n -= 3;
                    c += 2;
                }
                else
                {
                    switch (n)
                    {
                        case 0:
                            break;

                        case 1:
                            S -= c;
                            break;

                        case 2:
                            S -= c;
                            c += 2;
                            S += c;
                            break;

                        case 3:
                            S -= c;
                            c += 2;
                            S += c;
                            c += 2;
                            S += c;
                            break;
                    }
                }
            } while (n > 1);
        sus:
            Console.WriteLine("Сумма: " + S);
        }
    }
}

