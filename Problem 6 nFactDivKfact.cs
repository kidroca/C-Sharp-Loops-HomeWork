using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class nFactDivKfact
{
    /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
     * Use only one loop. */

    static void Main(string[] args)
    {
        decimal n;
        decimal k;
        // decimal factorialN = 1;
        // decimal factorialK = 1;
        decimal result;

        while (true)
        {
            Console.Write("Enter N = ");
            decimal.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter K = ");
            decimal.TryParse(Console.ReadLine(), out k);

            if ((n > k) & (k > 1))
            {
                break;
            }
            Console.WriteLine("Wrong data entered, try again");
        }

            /*for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i > k) continue; 
                factorialK *= i;
            }
            result = factorialN / factorialK;
            Console.WriteLine("Result = " + result);
             */

        result = 1;

        for (int i = (int)k + 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine("Result = " + result);
    }
}
