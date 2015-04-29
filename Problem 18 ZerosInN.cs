using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ZeroesInN
{
    /* Write a program that calculates with how many zeroes the factorial of a given number 
     * has at its end.
     * Your program should work well for very big numbers, e.g. n=100000.
     */
    static void Main(string[] args)
    {
        /* 10! = 1*2*3*4*5*6*7*8*9*10
         * 1*2*3*4*5 = 24*5 = 120 = 12 * 10
         * 12 * 6*7*8*9*10*10 = somethig 00
         * 10! has two zeroes.
         * 10 / 5 = 2;
         * 
         * 20 / 5 = 4;
         * 
         * 25 / 5 = 5, wait a minute ! 25! has 6 zeroes, 5 / 5 = 1;
         * 
         * 100 / 25 = 4; 100! has 6 * 4 = 24 zeroes
         * 
         * 125 / 25 = 5; 5 / 5 = 1 ; 125! has 6*5 + 1 = 31 zeroes
         * 
         * And so on...
         */

        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        int zeroes = 0;

        Console.Write("{0}! has ", n);
        while (n > 4)
        {
            zeroes += n / 5;
            n /= 5;
        }
        Console.WriteLine("{0} trailing zeroes",zeroes);
    }
}