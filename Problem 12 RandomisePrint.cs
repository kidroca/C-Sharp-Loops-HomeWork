using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomisePrint
{
    // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        List<int> myList = new List<int>();
        int number = 0;
        bool check = true;

        for (int i = 0; i < n; i++)
        {
            number = rnd.Next(1, n + 1);
            check = myList.Contains(number);
           // Console.Write(number + " ");
           // Console.WriteLine(check);
            if (check)
            {
                i--;
                continue;
            }
            myList.Add(number);
            Console.Write(" " + myList[i]);
        }
        Console.WriteLine();


    }
}
