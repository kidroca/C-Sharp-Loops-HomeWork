using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToDec
{
    /* Using loops write a program that converts a hexadecimal integer number to its decimal form.
     * The input is entered as string. The output should be a variable of type long.
     * Do not use the built-in .NET functionality.
     */
    static void Main(string[] args)
    {
        Console.Write("Enter a hexidecimal number: ");
        string hexNumber = Console.ReadLine();
        long decNumber = 0, curentSymbol = 0;


        for (int i = hexNumber.Length - 1, pow = 0; i >= 0; i--, pow += 4)
        {
            switch (hexNumber[i])
            {
                case '0': curentSymbol = 0; break;
                case '1': curentSymbol = 1; break;
                case '2': curentSymbol = 2; break;
                case '3': curentSymbol = 3; break;
                case '4': curentSymbol = 4; break;
                case '5': curentSymbol = 5; break;
                case '6': curentSymbol = 6; break;
                case '7': curentSymbol = 7; break;
                case '8': curentSymbol = 8; break;
                case '9': curentSymbol = 9; break;
                case 'A':
                case 'a': curentSymbol = 10; break;
                case 'B':
                case 'b': curentSymbol = 11; break;
                case 'C':
                case 'c': curentSymbol = 12; break;
                case 'D':
                case 'd': curentSymbol = 13; break;
                case 'E':
                case 'e': curentSymbol = 14; break;
                case 'F':
                case 'f': curentSymbol = 15; break;                
                default: Console.WriteLine("incorect character detected");
                    break;
            }
            decNumber += curentSymbol << pow;
        }
        Console.WriteLine("To decimal = " + decNumber);
    }
}