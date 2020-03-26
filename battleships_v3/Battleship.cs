using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Health = 4;
            Identification = 'B';
        }
    }
}