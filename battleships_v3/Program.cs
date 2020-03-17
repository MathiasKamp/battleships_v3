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
            Gui gui = new Gui();

            grid gridGameBoard = new grid();

           gui.PlaceShips();


            while (gui.GetHitCounter() < 13)
            {
                gui.renderStartMenu();
                gridGameBoard.MakeBattleBoard(gui.getGridWithShips());
                gui.GetCoordinatesFromUser();

            }

        }
    }
}