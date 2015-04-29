using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class facNXN
{
    /*Write a program that, for a given two integer numbers n and x, calculates 
     * the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n. Use only one loop. 
     * Print the result with 5 digits after the decimal point. */

    static void Main(string[] args)
    {
        
        decimal factorial = 1;

        Console.Write("Enter N = ");
        decimal n = decimal.Parse(Console.ReadLine());

        Console.Write("Enter X = ");
        decimal x = decimal.Parse(Console.ReadLine());

        decimal sum = 1 + 1 / x;
        decimal square = x;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
            square *= x;
            sum += factorial / square;          
        }
        Console.WriteLine("Sum is {0:F5}", sum);
    }
}