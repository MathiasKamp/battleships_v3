using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    class grid
    {
        // makes a two dimensional array of type char with 10 spots in each row.
        char[,] Grid = new char[10, 10];

        // method makeBattleBoard creates my grid
        public void MakeBattleBoard(char[,] grid)
        {
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9 \n--+--------------------");

            for (int row = 0; row <= 9; row++)
            {
                Console.Write((row).ToString() + " ¦ ");
                for (int column = 0; column <= 9; column++)
                {
                    Console.Write(grid[column, row] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }

    }
}
