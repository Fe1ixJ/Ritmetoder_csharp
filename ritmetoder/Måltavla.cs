using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ritmetoder
{
    public class Måltavla 
    {
        private int x = 0;
        private int y = 0;
        private int radie = 0;

        public Måltavla(int x, int y, int radie)
        {
            this.x = x;
            this.y = y;
            if (radie<0)
            {
                this.radie = -radie;
            }
            else
            {
                this.radie = radie;
            }
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
        #endregion
        public void Rita ( Graphics g)
        {
            int r = radie;
            g.FillEllipse(new SolidBrush(Color.White), x-r, y-r, r * 2, r * 2 );
            r = (int)(radie*0.8);
            g.FillEllipse(new SolidBrush(Color.Black), x-r, y-r, r * 2, r * 2);
            r = (int)(radie * 0.6);
            g.FillEllipse(new SolidBrush(Color.Blue), x - r, y - r, r * 2, r * 2);
            r = (int)(radie * 0.4);
            g.FillEllipse(new SolidBrush(Color.IndianRed), x - r, y - r, r * 2, r * 2);
            r = (int)(radie * 0.2);
            g.FillEllipse(new SolidBrush(Color.Yellow), x - r, y - r, r * 2, r * 2);

            g.DrawEllipse(Pens.Black, x - radie, y - radie, radie * 2, radie * 2);
        }
    }
}
