using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class point
    {   public int X;
        public int Y;
        public char sym;
        public void Draw()
        {Console.SetCursorPosition(X, Y);
   Console.Write(sym);
        }
    }
}
    

