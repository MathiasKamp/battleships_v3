using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    class Gui
    {
        public int hitCounter = 0;
        public int missCounter = 0;

        char[,] Grid = new char[10, 10];

        public char [,] getGridWithShips()
        {
            return Grid;
        }

        public int GetHitCounter()
        {
            return hitCounter;
        }

        public int GetMissCounter()
        {
            return missCounter;
        }

        public void GetCoordinatesFromUser()
        {
            int coordinateX = 0;
            int coordinateY = 0;
            
            int value = 0;
            Console.Write("Enter your coordinate of X: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out value))
            {
                coordinateX = value;
            }

            else
            {
                Console.Write("please enter a number for X coordinate ");
            }

            Console.Write("Enter your coordinate of Y: ");

            line = Console.ReadLine();

            if (int.TryParse(line, out value))
            {
                coordinateY = value;
            }

            else
            {
                Console.Write("please enter a number for Y coordinate ");
            }

            try
            {
                if (Grid[coordinateX,coordinateY].Equals('B') || Grid[coordinateX, coordinateY].Equals('C') || Grid[coordinateX, coordinateY].Equals('D') || Grid[coordinateX, coordinateY].Equals('S') || Grid[coordinateX, coordinateY].Equals('A'))
                {
                    Grid[coordinateX, coordinateY] = 'H';

                    Console.Clear();

                    Console.WriteLine("Hit!\r\n");

                    hitCounter++;
                }

                else
                {
                    Grid[coordinateX, coordinateY] = 'M';
                    
                    Console.Clear();

                    Console.WriteLine("Miss! Try again\r\n");

                    missCounter++;
                }
            }
            catch 
            {
                Console.Clear();
                Console.WriteLine("Error: enter a number between 0 and 9");
            }

        }

        public void BattleshipToGrid(int x, int y)
        {
            Grid[x, y] ='B';
        }
        public void AirCraftCarrierToGrid(int x, int y)
        {
            Grid[x, y] = 'A';
        }
        public void CruiserToGrid(int x, int y)
        {
            Grid[x, y] = 'C';
        }
        public void DestroyerToGrid(int x, int y)
        {
            Grid[x, y] = 'D';
        }
        public void SubmarineToGrid(int x, int y)
        {
            Grid[x, y] = 'S';
        }

        public void PlaceShips()
        {
            BattleshipToGrid(1,2);
            BattleshipToGrid(2,2);

            DestroyerToGrid(1,8);
            DestroyerToGrid(2, 8);

            CruiserToGrid(4,3);
            CruiserToGrid(4, 4);
            CruiserToGrid(4, 5);

            AirCraftCarrierToGrid(7,4);
            AirCraftCarrierToGrid(7, 5);
            AirCraftCarrierToGrid(7, 6);
            AirCraftCarrierToGrid(7, 7);
            AirCraftCarrierToGrid(7, 8);

            SubmarineToGrid(5,0);
            SubmarineToGrid(6,0);
            SubmarineToGrid(7,0);
        }

        public void renderStartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string title = @"

              ____       _______ _______ _      ______  _____ _    _ _____ _____   _____ 
             |  _ \   /\|__   __|__   __| |    |  ____|/ ____| |  | |_   _|  __ \ / ____|
             | |_) | /  \  | |     | |  | |    | |__  | (___ | |__| | | | | |__) | (___  
             |  _ < / /\ \ | |     | |  | |    |  __|  \___ \|  __  | | | |  ___/ \___ \ 
             | |_) / ____ \| |     | |  | |____| |____ ____) | |  | |_| |_| |     ____) |
             |____/_/    \_\_|     |_|  |______|______|_____/|_|  |_|_____|_|    |_____/ 
            ";

            Console.WriteLine(title);

        }
    }
}
