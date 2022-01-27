using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ritmetoder
{

    class Pil
    {
        private int x = 0;
        private int y = 0;
        private int radie = 0;
        private int avståndx = 0;
        private int avståndy = 0;
        public Pil (int x, int y, int r, int avståndx, int avståndy)
        {
            this.x = x;
            this.y = y;
            this.radie = r;
            this.avståndx = avståndx;
            this.avståndy = avståndy;
        }
        #region Egenskaper
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
        public int Avståndx
        {
            get { return avståndx; }
            set { avståndx = value; }
        }
        public int Avståndy
        {
            get { return avståndy; }
            set { avståndy = value; }
        }

        
        #endregion

        public void Rita(Graphics h)
        {
            
            int r = radie;
            Pen penna = new Pen(Color.Green, 4);
            Pen svartPenna = new Pen(Color.Black, 2);
            h.DrawLine(svartPenna, x-r, y-r, x+r, y+r);
            h.DrawLine(svartPenna, x-r, y+r, x+r, y-r);


        }
        
    }
        
}
