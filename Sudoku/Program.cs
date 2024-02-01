using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
    
        static int[,] board = new int[9, 9];

        static void Main(string[] args)
        {
            for (int i=0;i<9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"|{board[i, j]}|");

                }

                Console.WriteLine("");
                for (int k = 0; k < 27; k++)
                {
                    Console.Write("=");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        static void InitializeBoard()
        {
            // Inizializza la board con tutti zeri
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine();
                    board[i, j] = 0;
                }
                Console.WriteLine();    
            }
        }

        static void AddRandomNumbers()
        {
            Random random = new Random();

            // Numero di numeri casuali da inserire
            int randomNumbersCount = 15;

            for (int i = 0; i < randomNumbersCount; i++)
            {
                int randomRow = random.Next(0, 9);
                int randomCol = random.Next(0, 9);
                int randomValue = random.Next(1, 10);

                // Verifica che la cella sia vuota prima di inserire un numero casuale
                while (board[randomRow, randomCol] != 0)
                {
                    randomRow = random.Next(0, 9);
                    randomCol = random.Next(0, 9);
                }

                board[randomRow, randomCol] = randomValue;
            }
        }
    }
}
