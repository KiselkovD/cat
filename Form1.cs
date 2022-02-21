using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cat
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = CreateGraphics();
            g.Clear(Color.White);
            //g.DrawEllipse(Pens.Black, 400, 100, 250, 150); // тело
            //g.DrawEllipse(Pens.Black, 350, 350, 20, 20);
            g.DrawLine(Pens.Black, 47, 5, 64, 35);
            g.DrawLine(Pens.Black, 51, 43, 64, 35);
            g.DrawLine(Pens.Black, 51, 43, 47, 5);//
            g.DrawLine(Pens.Black, 79, 23, 47, 5);
            g.DrawLine(Pens.Black, 79, 23, 99, 23);
            g.DrawLine(Pens.Black, 121, 35, 99, 23);
            g.DrawLine(Pens.Black, 121, 35, 155, 21);
            g.DrawLine(Pens.Black, 142, 47, 155, 21);
            g.DrawLine(Pens.Black, 154, 61, 142, 47);
            g.DrawLine(Pens.Black, 154, 61, 155, 21);
            g.DrawLine(Pens.Black, 154, 61, 153, 73);
            g.DrawLine(Pens.Black, 153, 73, 136, 87);
            g.DrawLine(Pens.Black, 153, 73, 175, 113);
            g.DrawLine(Pens.Black, 133, 99, 136, 87);
            g.DrawLine(Pens.Black, 175, 113, 179, 151);
            g.DrawLine(Pens.Black, 133, 99, 140, 107);
            g.DrawLine(Pens.Black, 140, 107, 143, 113);
            g.DrawLine(Pens.Black, 133, 153, 143, 113);
            g.DrawLine(Pens.Black, 189, 151, 3, 155);
            g.DrawLine(Pens.Black, 140, 107, 91, 125);
            g.DrawLine(Pens.Black, 91, 125, 63, 119);
            g.DrawLine(Pens.Black, 63, 119, 39, 99);
            g.DrawLine(Pens.Black, 51, 43, 43, 69);
            g.DrawLine(Pens.Black, 68, 103, 84, 105);
            g.DrawLine(Pens.Black, 75, 111, 68, 103);
            g.DrawLine(Pens.Black, 75, 111, 84, 105);
            g.DrawLine(Pens.Black, 39, 99, 13, 155);
            g.DrawLine(Pens.Black, 39, 99, 39,91);
            g.DrawLine(Pens.Black, 67, 89, 85, 89);

            float c1=108, c2=90;
            double a = 30 * 3.1415926 / 180, a2 = 354 * 3.1415926 / 180;

            for (int i2 = -300; i2 < 300; i2++)
                for (int i3 = -400; i3 < 400; i3++)
                {
                    if ((i2 * Math.Cos(a) + i3 * Math.Sin(a)) * (i2 * Math.Cos(a) + i3 * Math.Sin(a)) / 3 + (-i2 * Math.Sin(a) + i3 * Math.Cos(a)) * (-i2 * Math.Sin(a) + i3 * Math.Cos(a)) < 200) g.DrawLine(Pens.Black, i2 + 50, i3 + 80, i2 + 1 + 50, i3 + 1 + 80);
                    if ((i2 * Math.Cos(a2) + i3 * Math.Sin(a2)) * (i2 * Math.Cos(a2) + i3 * Math.Sin(a2)) / 3 + (-i2 * Math.Sin(a2) + i3 * Math.Cos(a2)) * (-i2 * Math.Sin(a2) + i3 * Math.Cos(a2)) < 200) g.DrawLine(Pens.Black, i2 + c1, i3 + c2, i2 + 1 + c1, i3 + 1 + c2);
                }
                    
            
            /*this.BackColor = Color.White;
           
            Graphics gr = e.Graphics;
            
            for (int d = 1;d<45;d++)
            {
                gr.RotateTransform(1);
                gr.DrawEllipse(new Pen(Brushes.Red, 3), new Rectangle(new Point(200, 0), new Size(1, 1)));


            }
            gr.DrawEllipse(Pens.Black, new Rectangle(new Point(200, 0), new Size(105, 105)));*/



        }
    }
}
