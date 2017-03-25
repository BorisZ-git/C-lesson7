using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatInLabirinth
{
    class Wall
    {
        public Wall(int x, int y, int to,char sym)
        {
            Points p1;
            if (y<to)
                for (; y != to; y++)
                {
                    p1 = new Points(x, y, sym);
                }
            else if (y>to)
                for (; y != to; y--)
                {
                    p1 = new Points(x, y, sym);
                }
        }
        public Wall(int x, int to, int y, char sym, string hor)
        {
            Points p1;
            if (x < to)
                for (; x != to; x++)
                {
                    p1 = new Points(x, y, sym);
                }
            else if (x > to)
                for (; x != to; x--)
                {
                    p1 = new Points(x, y, sym);
                }
        }


    }
}
