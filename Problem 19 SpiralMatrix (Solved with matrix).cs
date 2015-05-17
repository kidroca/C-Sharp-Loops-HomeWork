using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int[,] matrix = new int[n, n];

            for (int j = 0; j < n; j++)
            {
                for (int i = j; i < n - j; i++) // top
                {
                    matrix[j, i] = count;
                    count++;
                }

                for (int i = j + 1; i < n - j; i++) // right
                {
                    matrix[i, n - (j + 1)] = count;
                    count++; 
                }

                for (int i = n - (j + 2); i > j - 1; i--) // bottom
                {
                    matrix[n - (j + 1), i] = count;
                    count++;
                }

                for (int i = n - (j + 2); i > j; i--) // left
                {
                    matrix[i, j] = count;
                    count++;
                }
            }

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0,3} ", matrix[j,i]);
                }
                Console.WriteLine();
            }
        }
    }
