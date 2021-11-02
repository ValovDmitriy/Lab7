using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону треугольника a:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника b:");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника c:");
            double c = Convert.ToInt32(Console.ReadLine());
            double S;
            TriangArea(a, b, c, out S);

            static void TriangArea(double a, double b, double c, out double S)
            {
                double p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                string Sstr = String.Format("{0:f}", S);
                Console.WriteLine("Площадь треугольника равна {0}", Sstr);
            }
        }
    }
}
