using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenProd
{
    /* You are given n integers (given in a single line, separated by a space). 
     * Write a program that checks whether the product of the odd elements is equal
     * to the product of the even elements. 
     * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
     */

    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine()
            .Split(' ');

        int oddProd = 1, evenProd = 1;
        
        for (int i = 0, number = 0; i < numbers.Length;i += 2)
        {
            number = int.Parse(numbers[i]);
            oddProd *= number;
        }

        for (int i = 1, number = 0; i < numbers.Length; i += 2)
        {
            number = int.Parse(numbers[i]);
            evenProd *= number;
        }

        if (evenProd == oddProd) Console.WriteLine("Result = Yes , Product = " + oddProd);
        else Console.WriteLine("Result = No. Even Product = {0}; Odd Product = {1}.", evenProd, oddProd);
    }
}