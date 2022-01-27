using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritmetoder
{
    public partial class Form1 : Form

    {
        private Måltavla mål;
        private Sikte scope = new Sikte();
        private Pil[] pilar;
        private int antalPilar = 0;
        Random generatorX = new Random();
        private readonly int MAX_PILLAR = 50;

        public Form1()
        {
            InitializeComponent();

            mål = new Måltavla(ClientSize.Width/2, ClientSize.Height/2, 69);


            scope.X = ClientSize.Width / 4;
            scope.Y = ClientSize.Height / 4;
            scope.Radie = ClientSize.Height/12;
            pilar = new Pil[MAX_PILLAR];
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            mål.Rita(g);
            scope.Rita(g);
            for (int i = 0; i <antalPilar; i++)
            {
                if (pilar[i] != null) pilar[i].Rita(e.Graphics);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            scope.X = e.X;
            scope.Y = e.Y;
            Invalidate();

        }
        protected override void OnMouseClick(MouseEventArgs e)
        {


            int förflyttingX = generatorX.Next(138, ClientSize.Width-138);
            int förflyttingY = generatorX.Next(138, ClientSize.Height-138);


            for (int i = 0; i <antalPilar; i++)
            {

                pilar[i].X = förflyttingX - pilar[i].Avståndx;
                pilar[i].Y = förflyttingY - pilar[i].Avståndy;

                Console.WriteLine("PilX" + pilar[i].X);
                Console.WriteLine("PilY" + pilar[i].Y);
                Console.WriteLine("AvståndX" + pilar[i].Avståndx);
                Console.WriteLine("AvståndY" + pilar[i].Avståndx);
                Console.WriteLine("målX" + mål.X);
                Console.WriteLine("MålY" + mål.X);

                mål.X = förflyttingX;
                mål.Y = förflyttingY;
                Invalidate();

            }

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (antalPilar > (MAX_PILLAR - 1))
            {
                labelRäkna.Text = "Pilarna är slut";
                return;
            }

            pilar[antalPilar++] = new Pil(e.X, e.Y, 5, 0, 0);

            for (int i = 0; i < antalPilar; i++)
            {
                pilar[i].Avståndx = mål.X - pilar[i].X;
                pilar[i].Avståndy = mål.Y - pilar[i].Y;
                labelRäkna.Text = $"{pilar[i].Avståndx} + {pilar[i].Avståndy}";
            }

            labelRäkna.Text = (MAX_PILLAR - antalPilar).ToString();

            Invalidate();
        }
    }
}
