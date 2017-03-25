using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatInLabirinth
{
    class Points
    {
        int x;
        int y;
        char sym;
        public Points(int x, int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            Draw();
        }
        void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
