using System;

namespace AssnmntQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] r = { 5.5, 6.6, 7.7, 8.8, 9.9 };
            int i, n = r.Length;
            double a, c;
            Console.WriteLine("\nNo  Radius    Area     Circumference\n");
            for (i = 0; i < n; i++)
            {
                a = Math.Round(area(r[i]), 4);
                c = Math.Round(circum(r[i]), 4);
                Console.WriteLine("{0}    {1}    {2}      {3}", i + 1, r[i], a, c);

            }
        }

        static double area(double r)
        {
            return (3.1416 * r * r);
        }

        static double circum(double r)
        {
            return (2.0 * 3.1416 * r);
        }
    }
}