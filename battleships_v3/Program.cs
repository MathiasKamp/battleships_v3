using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a new object of gameManager class
            GameManager game = new GameManager();

            // creates new object of grid class
            grid gridGameBoard = new grid();

            // creates new object of gui class
            Gui gui = new Gui();

            // class method PlaceShipsToGrid from GameManager
           game.PlaceShipsToGrid();

            // this code runs while the hit count is less 17 (the ships lives added together)
            while (game.GetHitCounter() < 17)
            {
                // runs my Renderasccii method
                gui.RenderAscii();
                // runs my makeBattleBoard and GetGridWithShips method
                gridGameBoard.MakeBattleBoard(game.GetGridWithShips());
                // runs my GetCoordinatesFromUser which gets a x and y coordinate 
                game.GetCoordinatesFromUser();

            }

            Console.WriteLine($"you have missed :{game.GetMissCounter()}");

        }
    }
}