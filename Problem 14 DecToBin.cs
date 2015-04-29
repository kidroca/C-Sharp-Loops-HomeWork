using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToBin
{
    /* Using loops write a program that converts an integer number to its binary representation.
     * The input is entered as long. The output should be a variable of type string.
     * Do not use the built-in .NET functionality.
     */
    static void Main(string[] args)
    {
        Console.Write("Enter decimal number: ");
        long n = long.Parse(Console.ReadLine());
        string binNumber = null;
        long power = 2;

        while (n - power >= 0)
        {
     
            power <<=  1;
                                     // Console.WriteLine(power);
        }

        power >>= 1;
                                    // Console.WriteLine(power);
        Console.Write(n);

        while (power != 0)
        {
            if (n - power >= 0)
            {
                n -= power;
                power /= 2;
                binNumber += '1';
            }
            else
            {
                power /= 2;
                binNumber += '0';
            }
        }
        Console.WriteLine(" to binary = {0}" , binNumber);
    }
}
