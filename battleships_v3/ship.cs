using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    /// <summary>
    /// Ship class that i can inherit from to my battleship, cruiser, destroyer, submarine and aircraftcarrier
    /// </summary>
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public char Identification { get; set; }
    }
}