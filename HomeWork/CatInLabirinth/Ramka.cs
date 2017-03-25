using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatInLabirinth
{
    class Ramka
    {
        public Ramka()
        {
            Console.BufferHeight = 40;
            Console.BufferWidth = 120;
            int width = Console.BufferWidth / 2;
            int height = Console.BufferHeight / 2;
            Wall ver1 = new Wall(width - width/4, height, height - 10, '|');
            Wall ver2 = new Wall(width + width / 4, height, height - 10, '|');
            Wall hor1 = new Wall((width - width / 4)+2, width + 14, height - height / 2, '_', "hor");
            Wall hor2 = new Wall((width - width / 4) + 2, width + 14, height , '_', "hor");
        }
    }
}
