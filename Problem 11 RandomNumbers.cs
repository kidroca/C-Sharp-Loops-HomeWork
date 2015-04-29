using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbers
{
    // Write a program that enters 3 integers n, min and max (min != max) and 
    // prints n random numbers in the range [min...max].

    static void Main(string[] args)
    {
        Console.Write("Enter Low Border ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter Hi Border ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("Enter how many numbers to generate N = ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0, roll = 0; i < n; i++)
        {
            
            roll = rnd.Next(min, max);
            Console.Write(" " + roll);
        }
        Console.WriteLine();
    }
}