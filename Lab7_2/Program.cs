using System;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            double a = Convert.ToInt32(Console.ReadLine());
            double S;
            double V;
            KubeVolume(a, out S, out V);

            static void KubeVolume(double a, out double S, out double V)
            {
                V = a*a*a;
                S = 6*a*a;
                string Sstr = String.Format("{0:f}", S);
                string Vstr = String.Format("{0:f}", V);
                Console.WriteLine("Площадь поверхности куба равна {0}", Sstr);
                Console.WriteLine("Объем куба равна {0}", Vstr);
            }
        }
    }
}
