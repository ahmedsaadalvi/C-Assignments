using System;

namespace AssnmntQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = { 45, 66, 80, 75, 95, 40, 77 };
            string[] name = { "Joe", "Sam", "May", "Din", "June", "Kay", "Wong" };
            string name2, grade, grade2;
            int i, n, min, max;
            double sum = 0, avg;
            n = mark.Length;
            Console.WriteLine("\tEXAM RESULTS\n");
            Console.WriteLine("No.  Name    Mark    Grade\n");
            min = mark[0];
            max = mark[0];
            for (i = 0; i < n; i++)
            {
                if (mark[i] > 0 && mark[i] < 49)
                    grade = "F";
                else if (mark[i] > 50 && mark[i] < 69)
                    grade = "C";
                else if (mark[i] > 70 && mark[i] < 84)
                    grade = "B";
                else if (mark[i] > 85 && mark[i] < 100)
                    grade = "A";
                else
                    grade = "Invalid Mark";
                if (min > mark[i])
                    min = mark[i];
                if (max < mark[i])
                    max = mark[i];
                sum = sum + mark[i];
                name2 = name[i].PadRight(7);
                grade2 = grade.PadLeft(8);
                Console.WriteLine("{0}    {1}  {2} {3}", i + 1, name2, mark[i], grade2);
            }
            avg = sum / n;
            Console.WriteLine("\nAverage = " + Math.Round(avg, 2));
            Console.WriteLine("Maximum = " + max);
            Console.WriteLine("Minimum = " + min);   
        }
    }
}