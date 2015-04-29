using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToHex
{
    /* Using loops write a program that converts an integer number to its hexadecimal representation.
     * The input is entered as long. The output should be a variable of type string.
     * Do not use the built-in .NET functionality.
     */ 
    static void Main(string[] args)
    {
        string hexNum = null;
        Console.Write("Enter decimal number: ");
        long decNum = long.Parse(Console.ReadLine());
        long tempValue = 0;
        Console.Write("The hexidecimal value of " + decNum + " = ");
        while (decNum > 0)
        {
            tempValue = decNum % 16;
            switch (tempValue)
            {
                case 0: hexNum += '0'; break;
                case 1: hexNum += '1'; break;
                case 2: hexNum += '2'; break;
                case 3: hexNum += '3'; break;
                case 4: hexNum += '4'; break;
                case 5: hexNum += '5'; break;
                case 6: hexNum += '6'; break;
                case 7: hexNum += '7'; break;
                case 8: hexNum += '8'; break;
                case 9: hexNum += '9'; break;
                case 10: hexNum += 'A'; break;
                case 11: hexNum += 'B'; break;
                case 12: hexNum += 'C'; break;
                case 13: hexNum += 'D'; break;
                case 14: hexNum += 'E'; break;
                case 15: hexNum += 'F'; break;
                default:
                    break;
            }
            decNum >>= 4;
                // Console.WriteLine(decNum);
        }

        for (int i = hexNum.Length -1; i >= 0; i--)
        {
            Console.Write(hexNum[i]);
        }
        Console.WriteLine();
    }
}
