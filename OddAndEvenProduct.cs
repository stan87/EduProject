using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class OddAndEvenProduct
    {
        static void Main()
        {
        Console.WriteLine("Enter your numbers:");
        string numbers = Console.ReadLine();

        string[] tokens = numbers.Split(' ');

        int evenProduct = 1;
        int oddProduct = 1;

        foreach (var item in tokens)
        {
            int newNumber = int.Parse(item);

                if (newNumber % 2 == 0)
                {
                    evenProduct *= newNumber;
                    continue;
                }

                else
                {
                    oddProduct *= newNumber;
                continue;
                }
            }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0} {1}", evenProduct, oddProduct);
        }

        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }

        }
    }

