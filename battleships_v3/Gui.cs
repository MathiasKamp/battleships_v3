using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_v3
{
    /// <summary>
    /// Gui class to print out ascii art
    /// </summary>
    class Gui
    {
        public void RenderAscii()
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
