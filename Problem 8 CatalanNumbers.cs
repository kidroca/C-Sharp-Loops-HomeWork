using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CatalanNumbers
{
    /* In combinatorics, the Catalan numbers are calculated by the following formula: 
     * (2n!) / ((n + 1)!) * n!
     * Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
     */
    static void Main(string[] args)
    {
        Console.Write("Enter N = ");
        double n = double.Parse(Console.ReadLine());
        double result = 1;

        for (double i = n + 1; i <= 2 * n; i++)
        {
            result *= i;
        }

        for (int i = 1; i <= n + 1; i++)
        {
            result /= i;
        }

        Console.WriteLine("Result = " + result);
    }
}
