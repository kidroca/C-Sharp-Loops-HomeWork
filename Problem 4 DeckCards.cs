using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DeckCards
{

    /* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers)
     * . The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
     * The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds,
     * hearts and spades. Use 2 nested for-loops and a switch-case statement.
     */

    static void Main(string[] args)
    {
        char paint;

        for (int card = 2; card <= 14; card++)
        {
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    default: paint = 'E';
                        break;
                    case 1: paint = '\u2660';
                        break;
                    case 2: paint = '\u2663';
                        break;
                    case 3: paint = '\u2665';
                        break;
                    case 4: paint = '\u2666';
                        break;
                }

                if (card == 11)
                {
                    Console.Write("Jack of " + paint + "; ");
                    continue;
                }
                if (card == 12)
                {
                    Console.Write("Queen of " + paint + "; ");
                    continue;
                }
                if (card == 13)
                {
                    Console.Write("King of " + paint + "; ");
                    continue;
                }
                if (card == 14)
                {
                    Console.Write("Ace of " + paint + "; ");
                    continue;
                }

                Console.Write(card + " of " + paint + "; ");
            }

            Console.WriteLine();
        }
    }
}
