using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameMemory
{
    class Quadrate
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int NumOfColor { set; get; }

        public Quadrate(int X, int Y, int NumOfColor)
        {
            this.X = X;
            this.Y = Y;
            this.NumOfColor = NumOfColor;
        }
    }
}
