using System;
using System.IO;

namespace AssnmntQ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, tel, n = 0;
            string line, name, sex, email;
            string[] sarray;
            FileStream fs = new FileStream(@"C:\Users\ahmed\Documents\University\Semester 4 (long)\Intermediate Programming (DIT2024)\Visual Studio\AssnmntQ6.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            line = sr.ReadLine();
            Console.WriteLine("\n\t\t\t\tCONTACTS");
            Console.WriteLine("\nNo   Name          Sex       Age       Tel.                Email\n");
            while (line != null)
            {
                n = n + 1;
                sarray = line.Split(',');
                tel = Convert.ToInt32(sarray[3]);
                sex = String.Format("{0, -10}", sarray[1]);
                name = String.Format("{0, -10}", sarray[0]);
                age = Convert.ToInt32(sarray[2]);
                email = String.Format("{0, -10}", sarray[4]);
                Console.WriteLine("{0}    {1}  {2}  {3}     {4}       {5}", n, name, sex, age, tel, email);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}