using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CalculateFactorials
    {
        static void Main()
        {

        while (true)
        {
            Console.WriteLine("Enter number N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number X:");
            int x = int.Parse(Console.ReadLine());

            double power = 1;
            double factorial = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power *= x;
                sum += (factorial / power);
            }

            Console.WriteLine("{0:F5}", sum);
        }

        }
    }

