using System;

namespace AssnmntQ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[5, 8];
            int i, j, m = 5, n = 8, min, max;
            double sum = 0;
            Random r = new Random();
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    x[i, j] = r.Next(100, 999);
                    sum = sum + x[i, j];
                    Console.Write(x[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nAverage = " + Math.Round(sum / n, 2));
        }
    }
}