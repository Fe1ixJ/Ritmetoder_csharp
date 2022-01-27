using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ritmetoder
{
     class Sikte
    {
        private int x = 0;
        private int y = 0;
        private int radie = 0;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Radie
        {
            get { return radie; }
            set { if (value < 0) radie = -value; else radie = value; }
        }
        public void Rita (Graphics f)
        {
            int r = radie;
            Pen penna = new Pen(Color.Green, 4);
            Pen svartPenna = new Pen(Color.Black, 2);
            f.DrawEllipse( penna, x - radie, y - radie, radie * 2, radie * 2);
            f.DrawLine(svartPenna, x, y , x, y+r);
            f.DrawLine(svartPenna, x, y, x, y-r);
            f.DrawLine(svartPenna, x, y, x+r, y);
            f.DrawLine(svartPenna, x, y, x-r, y);
            f.FillEllipse(new SolidBrush(Color.FromArgb(247, 33, 25)), x-3 , y-3 , 6 , 6 );
        }
    }
}
