using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
 * the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
 * The output is like in the examples below. */

class MinMaxAvg
{
    static void Main(string[] args)
    {
        float min = float.MaxValue, max = float.MinValue, sum = 0f, avg = 0f, currentNum = 0f;

        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers: ", n);
        for (int i = 0; i < n; i++)
        {
            currentNum = float.Parse(Console.ReadLine());
            sum += currentNum;

            if (currentNum < min )
            {
                min = currentNum;
            }

            if (currentNum > max)
            {
                max = currentNum;
            }
        }
        avg = sum / n;

        Console.WriteLine("Min = {0:F2}", min);
        Console.WriteLine("Max = {0:F2}", max);
        Console.WriteLine("Sum = {0:F2}", sum);
        Console.WriteLine("Avg = {0:F2}", avg);
    }
}
