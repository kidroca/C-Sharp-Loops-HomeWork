using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Напишете програма, която отпечатва на конзолата числата от 1 до N,
        // които не се делят едновременно на 3 и 7. Числото N да се чете от стандартния вход.

        Console.Write("Enter Number n = ");
        int n = 
            int.Parse
            (Console.ReadLine());

        int startInt = 1;

        while (startInt <= n)
        {
            if (startInt % 3 == 0)
            {
                startInt++;
                continue;
            }
            else if (startInt % 7 == 0)
            {
                startInt++;
                continue;
            }

            Console.Write(startInt + " ");
            startInt++;
        }

    }
}

