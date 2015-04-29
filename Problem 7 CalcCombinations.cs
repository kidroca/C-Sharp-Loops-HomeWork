using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalcCombinations
{
    /* In combinatorics, the number of ways to choose k different members out of a group of 
     * n different elements (also known as the number of combinations) is calculated by the
     * following formula: formula For example, there are 2598960 ways to withdraw 5 cards
     * out of a standard deck of 52 cards. 
     *    Your task is to write a program that calculates n! / (k! * (n-k)!) for 
     * given n and k (1 < k < n < 100). Try to use only two loops.
     */

    static void Main(string[] args)
    {
        double n;
        double k;
        double result = 1;

        while (true)
        {
            Console.Write("Enter N = ");
            double.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter K = ");
            double.TryParse(Console.ReadLine(), out k);

            if ((n > k) & (k > 1))
            {
                break;
            }
            Console.WriteLine("Wrong data entered, try again");
        }

        for (int i = (int)k + 1; i <= n; i++)
        {
            result *= i;
        }
        for (int i = 1; i <= n - k; i++)
        {
            result /= i;
        }

        Console.WriteLine("Result = " + result);

    }
}