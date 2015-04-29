using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToDec
{
    /* Using loops write a program that converts a binary integer number to its decimal form.
     * The input is entered as string. The output should be a variable of type long.
     * Do not use the built-in .NET functionality.
     */
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number (spaces are ignored): ");
        string binNumber = Console.ReadLine();
        long toDecimal = 0;
        int power = 0 , current = 0;
        bool binCheck = true; 

        for (int i = binNumber.Length - 1; i >= 0; i--, power++)
        {
            if (binNumber[i] == ' ')
            {
                power--;
                continue;
            }
            if (binNumber[i] != '0' & binNumber[i] != '1')
            {
                Console.WriteLine("Incorect digits only 0,1 and space are allowed");
                binCheck = false;
                break;
            }
            current = (int)char.GetNumericValue(binNumber[i]); //  Get the current digit of the binary number
            toDecimal += current << power; // Multiply the current digit by 2 on power of it's position in the binary number and keep a sum.
        }
        if (binCheck)
        {
            Console.WriteLine("{0} to decimal is {1}", binNumber, toDecimal);
        }


    }
}
