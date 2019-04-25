using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KARTINKA
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap bitmap1;
        Graphics graphics;
        Pen pen;
        Pen pen1;
        Pen pen2;
        Pen pen3;
        Pen pen4;
        Point p = new Point(200, 100);
        Point p1 = new Point(450, 0);
        Point p2 = new Point(510, 80);
        Point p3 = new Point(700, 75);
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }
         int Dd=0;


       // bool isClicked = false;
       // int R = 15;


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            pen = new Pen(Color.Blue);
            pen1 = new Pen(Color.Green);
            pen2 = new Pen(Color.Yellow);
            pen3 = new Pen(Color.Red);
            pen4 = new Pen(Color.Black);

            SolidBrush solid = new SolidBrush(Color.Gray);
            SolidBrush solid1 = new SolidBrush(Color.Gray);
            SolidBrush solid2 = new SolidBrush(Color.Gray);
            SolidBrush solid3 = new SolidBrush(Color.Gray);
            graphics.DrawLine(pen4, 0, 200, 810, 200);//black
            graphics.FillRectangle(pen.Brush, 0, 0, 800, 200);
            graphics.FillRectangle(pen1.Brush, 0, 201, 800, 201);
            graphics.FillEllipse(pen2.Brush, 15, 15, 100, 100);
            graphics.FillEllipse(pen.Brush, 35, 20, 80, 80);
            graphics.FillPolygon(solid, GetStar(p));
            graphics.FillPolygon(solid1, GetStar(p1));
            graphics.FillPolygon(solid2, GetStar(p2));
            graphics.FillPolygon(solid3, GetStar(p3));
            // human
            
            e.Graphics.DrawLine(pen4, 100+x, 190, 100, 210);//ребро
            e.Graphics.DrawLine(pen4, 100+x, 210, 115, 230);//правая нога
            e.Graphics.DrawLine(pen4, 100+x, 210, 86, 230);//левая нога
            e.Graphics.DrawLine(pen4, 100+x, 200, 86, 210);//левая рука 
            e.Graphics.DrawLine(pen4, 100+x, 200, 115, 210);//правая рука 
            //голова
            graphics.FillEllipse(pen4.Brush, 90+Dd, 172, 20, 20);//черная башка 
            graphics.FillEllipse(pen3.Brush, 93+Dd, 174, 15, 15);//красная башка 

            //////////////////////////////////////////////////////////////////////
            //human2
            //   x1,  y1,   x2,  y2

            graphics.DrawLine(pen4, p2.X-362, 180, p2.X-362, 210);//ребро
            graphics.DrawLine(pen4, p2.X-362, 210, p2.X -350, 227);//левая нога 
            graphics.DrawLine(pen4, p2.X-362, 210, p2.X -375, 227);//правая нога
            graphics.DrawLine(pen4, p2.X-362, 190, p2.X -345, 210);//левая рука
            graphics.DrawLine(pen4, p2.X-362, 190, p2.X -375, 210);//правая рука 
            //голова
            graphics.FillEllipse(pen4.Brush, p2.X-370+Dd, 164, 20, 20);//черная башка
            graphics.FillEllipse(pen3.Brush, p2.X-367+Dd, 166, 15, 15);//красная башка 

         
        }
          
        private Point[] GetStar(Point p)//Star1
        {
            Point[] star =
            {
                new Point(p.X+8,p.Y),
                new Point(p.X+16,p.Y+8),
                new Point(p.X+8,p.Y+16),
                new Point(p.X,p.Y+8)
            };
       
            return star;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            x+=10;
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap1);
            pictureBox1.Image = bitmap1;
            graphics.DrawLine(pen4, 100 + x, 190, 100, 210);//ребро
            graphics.DrawLine(pen4, 100 + x, 210, 115, 230);//правая нога
            graphics.DrawLine(pen4, 100 + x, 210, 86, 230);//левая нога
            graphics.DrawLine(pen4, 100 + x, 200, 86, 210);//левая рука 
            graphics.DrawLine(pen4, 100 + x, 200, 115, 210);//правая рука 
        }
    }
    }
    

