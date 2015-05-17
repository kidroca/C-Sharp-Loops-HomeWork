using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Print1toN
{
    static void Main(string[] args)
    {
        // Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.

        Console.Write("Enter Number n= ");

        int n = 
            int.Parse
            (Console.ReadLine());
        
        while (n >= 1)
        {
            Console.Write(n + " ");
            n--; 
        }
    }
}

