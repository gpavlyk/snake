using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public Point()
        {
            
        }

        public Point(int _x, int _y, char _c)
        {
            x = _x;
            y = _y;
            c = _c;        
        }


        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
