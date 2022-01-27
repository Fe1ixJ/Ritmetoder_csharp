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

    //Ändra så att man anger x, y kordianater med pos
    //KOlla om du kan manipulera det i pil.cs
    {
        private Måltavla mål;
        Sikte scope = new Sikte();
        private Pil[] pilar;
        private int antalPilar = 0;
        Random generatorX = new Random();
       
        public Form1()
        {
            InitializeComponent();

            mål = new Måltavla(ClientSize.Width/2, ClientSize.Height/2, 69);


            scope.X = ClientSize.Width / 4;
            scope.Y = ClientSize.Height / 4;
            scope.Radie = ClientSize.Height/12;
            pilar = new Pil[50];
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
        {
            scope.Y = scope.Y - 4;
            Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scope.X = scope.X + 4;
            Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scope.Y = scope.Y + 4;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scope.X = scope.X - 4;
            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            scope.X = e.X;
            scope.Y = e.Y;
            Invalidate();

        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            

            int flyttX = generatorX.Next(138, ClientSize.Width-138);
            int flyttY = generatorX.Next(138, ClientSize.Height-138);


            for (int i = 0; i <antalPilar; i++)
                {
                int förflyttingX = generatorX.Next(138, ClientSize.Width-138);
                int förflyttingY = generatorX.Next(138, ClientSize.Height-138);
                //Pilarna X,y upptaterras beroende på förflyttningen just nu
                

                //pilar[i].Avståndx= mål.X-pilar[i].X;
                //pilar[i].Avståndy= mål.Y-pilar[i].Y;
                label1.Text = pilar[i].Avståndx +"+" + pilar[i].Avståndy.ToString();
                //mål.X = förflyttingX;
                //mål.Y = förflyttingY;
                /* for (int j = 0; j > i; j++)
                 {*/
                if (i ==0)
                { }
                else
                {
                    pilar[i].X = förflyttingX + pilar[i-1].Avståndx;
                    pilar[i].Y = förflyttingY + pilar[i-1].Avståndy;

                    //label1.Text = pilar[i].Avståndx +"+" + pilar[i].Avståndy.ToString();
                    label2.Text = mål.X.ToString();
                    label3.Text = mål.Y.ToString();
                    label4.Text = pilar[i].X.ToString();
                    label5.Text = pilar[i].Y.ToString();
                    mål.X = förflyttingX;
                    mål.Y = förflyttingY;
                    Invalidate();
                }
                //}
            }

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (antalPilar<49)
            {
                
                pilar[antalPilar++] = new Pil(e.X, e.Y, 5, 0, 0 );
                for (int i = 0; i <antalPilar; i++)
                {
                    pilar[i].Avståndx= mål.X-pilar[i].X;
                    pilar[i].Avståndy= mål.Y-pilar[i].Y;
                    label1.Text = pilar[i].Avståndx +"+" + pilar[i].Avståndy.ToString();

                }
                //label1.Text = (50- antalPilar).ToString();
                
                Invalidate();
            }
            else label1.Text = "Pilarna är slut";
        }
    }
}
