using System;

namespace AssnmntQ7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890@$#?%&*";
            string[] ss = s.Split();
            int rn, i, m = 7, n = s.Length;
            string pwd = " ";
            Random r = new Random();
            for (i = 0; i < m; i++)
            {
                rn = r.Next(0, n);
                pwd = pwd + s[rn];
            }
            Console.WriteLine("\nPassword = " + pwd);
        }
    }
}