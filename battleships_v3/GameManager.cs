using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    class GameManager

    {
        // Creates new objects of my ships.
        Battleship b = new Battleship();
        AirCraftCarrier a = new AirCraftCarrier();
        Cruiser c = new Cruiser();
        Destroyer d = new Destroyer();
        Submarine s = new Submarine();

        public int hitCounter = 0;
        public int missCounter = 0;

        // creates a two Dimensional array
        char[,] Grid = new char[10, 10];

        // method GetgridWithShips gets the returns my Two Dimensional array
        public char [,] GetGridWithShips()
        {

            return Grid;
        }

        // method GetHitCounter returns hitCounter variable
        public int GetHitCounter()
        {
            return hitCounter;
        }

        // method GetMissCounter returns missCounter variable
        public int GetMissCounter()
        {
            return missCounter;
        }

        // this method gets the Coordinates from the user
        // and checks if theres a ship on that position
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
                // this line checks if theres any of the ships identification values on the given x and y coordinate that the user typed.
                if (Grid[coordinateX,coordinateY].Equals(b.Identification) || Grid[coordinateX, coordinateY].Equals(a.Identification) || Grid[coordinateX, coordinateY].Equals(d.Identification) || Grid[coordinateX, coordinateY].Equals(c.Identification) || Grid[coordinateX, coordinateY].Equals(s.Identification))
                {
                    // it will replace the coordinate with a "H"
                    Grid[coordinateX, coordinateY] = 'H';

                    Console.Clear();

                    Console.WriteLine("Hit!\r\n");

                    hitCounter++;

                }

                else
                {
                    // else it will replace the coordinate with an "M"
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

        // method BattleShipToGrid takes an x and y as parameter
        // And it will place battleShips identification attribute on that coordinate
        public void BattleshipToGrid(int x, int y)
        {
            Grid[x, y] = b.Identification;
        }
        public void AirCraftCarrierToGrid(int x, int y)
        {
            Grid[x, y] = a.Identification;
        }
        public void CruiserToGrid(int x, int y)
        {
            Grid[x, y] = c.Identification;
        }
        public void DestroyerToGrid(int x, int y)
        {
            Grid[x, y] = d.Identification;
        }
        public void SubmarineToGrid(int x, int y)
        {
            Grid[x, y] = s.Identification;
        }

        // this Method places the ships on the grid with hard coded x and y coordinates.
        public void PlaceShipsToGrid()
        {
            // this code is written 4 times to symbolize that the battle ship has 4 lives.
            // and it is placed on the grid from (0x, 2y) - (3x, y2)
            BattleshipToGrid(0,2);
            BattleshipToGrid(1,2);
            BattleshipToGrid(2, 2);
            BattleshipToGrid(3, 2);

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



       
    }
}
