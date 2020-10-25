using System;

namespace черновик
{
    class Program
    {
        static void TP(ref double a)
        {
            string str = Console.ReadLine();
            bool conv = double.TryParse(str, out a);
            while (!conv)
            {
                str = Console.ReadLine();
                conv = double.TryParse(str, out a);
            }
            a = int.Parse(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тохсыров Константин Асланович ИУ5-32Б");
            double a = 0, b = 0, c = 0, d, x1, x2;
            Console.WriteLine("введите кэфф. А");
            TP(ref a);
            Console.WriteLine("введите кэфф. B");
            TP(ref b);
            Console.WriteLine("введите кэфф. C");
            TP(ref c);
            d = b * b - 4 * a * c;
            if (d >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                x1 = -b + Math.Sqrt(d);
                Console.WriteLine($"x1 = {x1}");
                if (d > 0)
                {
                    x2 = -b - Math.Sqrt(d);
                    Console.WriteLine($"x2 = " + x2);
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("нет корней");
            }
            Console.ResetColor();

        }

    }
}
