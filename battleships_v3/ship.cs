using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public int Hits { get; set; }
        public string Identification { get; set; }

        public bool shipSunken
        {
            get { return Hits >= Health; }
        }
    }

}