using System;

namespace _3consol
{
    internal class Program
    {
        static double f(double x)
        {
            double y;
            if (x <= 1) y = x * x - 1;
            else if (x <= 2) y = 2 * x - 1;
            else y = Math.Pow(x, 5) - 1;
            return y;
        }
        
        static void f(double x, out double y)
        {
            if (x <= 1) y = x * x - 1;
            else if (x <= 2) y = 2 * x - 1;
            else y = Math.Pow(x, 5) - 1;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("\t Начальное значение a= ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("\t Конечное значение b= ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("\t шаг h= ");
                double h = double.Parse(Console.ReadLine());
                double y = 0;

                Console.WriteLine("\n\t Старая функция:");
                for (double i = a; i <= b; i += h)
                {
                    Console.WriteLine($"f({i:f2})={f(Math.Abs(i)):f4}");
                }

                Console.WriteLine("\n\t Перегруженная:");
                for (double i = a; i <= b; i += h)
                {
                    f(Math.Abs(i), out y);
                    Console.WriteLine($"f({i:f2})={y:f4}");
                }
            }
            catch (Exception)
            {
                Console.Write("\n\n\t****Введено неверное значение****\n\n");
            }
        }
    }
}
