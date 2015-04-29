using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumMatrix
{
    // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
    // and prints a matrix like in the examples below. Use two nested loops.

    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());
        for (byte i = 0; i < n; i++)
        {
            for (int j = i + 1; j <= n + i; j++)
            {
                Console.Write("{0,-3}", j);
            }
            Console.WriteLine();
        }
    }
}