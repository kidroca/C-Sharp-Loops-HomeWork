using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalcGCD
{
    /* Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
     * Use the Euclidean algorithm (find it in Internet).
     */ 
    static void Main(string[] args)
    {
        int a = Math
            .Abs(int.Parse(Console.ReadLine()));
        int b = Math
            .Abs(int.Parse(Console.ReadLine()));

        int gcd = 0;

        while (a != 0 & b != 0)
        {
            if (a >= b)
            {
                a -= b;
            }
            else if (a < b)
            {
                b -= a;
            }          
        }
        if (a != 0)
        {
            gcd = a;
            Console.WriteLine(a);
        }
        else if (b != 0)
        {
            gcd = b;
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
