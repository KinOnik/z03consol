using System;

namespace _1console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tВведите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write($"\n\tРезультат: {func(x, 2) + func(x, 4) + func(x, 6)}\n\n");
            }
            catch (Exception)
            {
                Console.Write("\n\n\t**** Введено некорректное значение ****\n\n");
            }
        }
        
        static double func(double x, double n)
        {
            return (Math.Pow(x, n)) / n;
        }
    }
}
