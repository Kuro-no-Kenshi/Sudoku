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

            Console.WriteLine("Let's play Sudoku!");

            Console.ReadKey();

        }
        static void InitializeBoard()
        {
            // Inizializza la board con tutti zeri
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
    }
}
