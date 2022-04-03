using System;

namespace AssnmntQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emp = { "Ahmed", "Saad", "Alvi", "Samir", "Azmi", "Ali", "Shirin", "Shafiq", "Ferdous", "Sumaiyyah", "Adeelah", "Alisha" };
            int[] hours = { 10, 20, 50, 30, 25, 45, 60, 15, 25, 35, 40, 50 };
            double rate = 9.5;
            int i, n = emp.Length;
            Employee e = new Employee();
            Console.WriteLine("No    Name         Hours   Rate     Salary(RM)");
            for (i = 0; i < n; i++)
            {
                e.assign_values(i, emp[i], hours[i], rate);
                e.compute_pay();
                e.gen_report();
            }
        }
    }
    class Employee
    {
        string emp, femp, fpay;
        double rate, pay;
        int i, hours;

        public void assign_values(int i2, string emp2, int hours2, double rate2)
        {
            i = i2;
            emp = emp2;
            hours = hours2;
            rate = rate2;
        }

        public void compute_pay()
        {
            pay = hours * rate;
            pay = Math.Round(pay, 2);
            fpay = String.Format("{0:0.00}", pay);
        }

        public void gen_report()
        {
            femp = String.Format("{0, -12}", emp);
            Console.WriteLine("{0}    {1}   {2}      {3}       {4}", i + 1, femp, hours, rate, fpay);
        }
    }
}