using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   /* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
    * prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in 
    * the examples below.
    * 
    * n = 2                       n = 4
    *          1 2                            1  2  3  4
    *          4 3                           12  13 14 5  
    *                                        11  16 15 6
    * n = 3                                  10  9  8  7
    *          1 2 3
    *          8 9 4
    *          7 6 5
    */

class SpiralMatrix
{   
    static int row;
    static int col;

    static void WriteHere(int x, int y)
    {
        Console.SetCursorPosition(col + x, row + y);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a nuber (1 to 20): ");
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            int lentgh = n;

            // Set initial position
            row = Console.CursorTop + 1;
            col = Console.CursorLeft;

            // Main cycle
            for (int j = 0; current < n * n + 1; j++)
            {
                if (n < 10) 
                { col = j * 3;}
                else 
                { col = j * 4;}

                // Draw the Top side
                for (int i = 0; i < lentgh; i++, current++)
                {
                    WriteHere(1, 0);
                    Console.Write(current);
                    //I need this because when the numbers get bigere there isn't enough space
                    if (n < 10)
                    { col += 3;}
                    else
                    { col += 4;}
                }
                row++;

                //I need this because when the numbers get bigere there isn't enough space
                if (n < 10)
                { col -= 3;}
                else
                { col -= 4;}

                lentgh--;

                // Draw the Right side
                for (int i = 0; i < lentgh; i++, current++)
                {
                    WriteHere(1, 0);
                    Console.Write(current);
                    row++;
                }
                row--;
                //I need this because when the numbers get bigere there isn't enough space
                if (n < 10)
                { col--;}
                else
                { col -= 2;}

                // Draw The Botom side
                for (int i = lentgh; i > 0; i--, current++)
                {
                    WriteHere(-1, 0);
                    Console.Write(current);
                    //I need this because when the numbers get bigere there isn't enough space
                    if (n < 10)
                    { col -= 3;}
                    else
                    { col -= 4;}
                }
                row--;
                lentgh--;
                //I need this because when the numbers get bigere there isn't enough space
                if (n < 10)
                { col += 2;}
                else
                {col += 3;}

                // Draw The Left side
                for (int i = 0; i < lentgh; i++, current++)
                {
                    WriteHere(0, 0);
                    Console.Write(current);
                    row--;
                }
                row++;
            }
            // Try again or end.
            row = n + 3;
            col = 0;
            WriteHere(0, 0);
            Console.Write("Do you want to do it again? type 'y': ");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
            }
            else
            {
                break;
            }
        }
    }
}
