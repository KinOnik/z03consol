using System;

namespace _2consol
{
    internal class Program
    {
        static double f(double x)
        {
            if (x<=1) return x*x-1;
            else if (x <=2) return 2* x-1;
            else return Math.Pow(x,5)-1;
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
                for (double i = a; i <= b; i += h)
                    Console.WriteLine($"f({i:f2})={f(Math.Abs(i)):f4}");
            }
            catch (Exception)
            {
                Console.Write("\n\n\t****Введено неверное значение****\n\n");
            }
        }

    }
}
