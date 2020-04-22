using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W6.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private System.Drawing.Graphics g;
        private System.Drawing.Pen penBlue = new System.Drawing.Pen(Color.Blue, 5F);
        private System.Drawing.Pen penRed = new System.Drawing.Pen(Color.Red, 3F);
        private System.Drawing.Pen penGreen = new System.Drawing.Pen(Color.Green, 2F);
        private System.Drawing.Pen penBrown = new System.Drawing.Pen(Color.SaddleBrown, 2F);

        private void butLine_Click(object sender, EventArgs e)
        {
            g = PictureBox1.CreateGraphics();
            g.DrawLine(penRed, 200, 90, 400, 200);
        }

        private void butEllipse_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(250, 200, 150, 80);
            g = PictureBox1.CreateGraphics();
            g.DrawEllipse(penBlue, rect);
        }

        private void butRectangle_Click(object sender, EventArgs e)
        {
            g = PictureBox1.CreateGraphics();
            g.DrawRectangle(penGreen, 100, 100, 180, 100);
        }

        private void butArc_Click(object sender, EventArgs e)
        {
            g = PictureBox1.CreateGraphics();
            float x = 25;
            float y = 50;
            float width = 100;
            float height = 200;

            float startAngle = 45;
            float sweepAngle = 250;

            g.DrawArc(penBrown, x, y, width, height, startAngle, sweepAngle);
        }

        private void butPie_Click(object sender, EventArgs e)
        {
            g = PictureBox1.CreateGraphics();
            int x = 290;
            int y = 70;
            int width = 200;
            int height = 100;

            int startAngle = 0;
            int sweepAngle = 45;

            g.DrawPie(penGreen, x, y, width, height, startAngle, sweepAngle);
        }

        private void butPolygon_Click(object sender, EventArgs e)
        {
            System.Drawing.Point[] p = new System.Drawing.Point[6];
            p[0].X = 0;
            p[0].Y = 0;
            p[1].X = 53;
            p[1].Y = 111;
            p[2].X = 114;
            p[2].Y = 86;
            p[3].X = 65;
            p[3].Y = 34;
            p[4].X = 165;
            p[4].Y = 0;
            g = PictureBox1.CreateGraphics();
            g.DrawPolygon(penBlue, p);
        }

        private void butBezier_Click(object sender, EventArgs e)
        {
            g = PictureBox1.CreateGraphics();
            float startX = 100.0F;
            float startY = 100.0F;
            float controlX1 = 200.0F;
            float controlY1 = 10.0F;
            float controlX2 = 350.0F;
            float controlY2 = 50.0F;
            float endX = 500.0F;
            float endY = 100.0F;

            g.DrawBezier(penRed, startX, startY,
                controlX1, controlY1,
                controlX2, controlY2,
                endX, endY);
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            g = PictureBox1.CreateGraphics();
            g.Clear(Color.LightGray);
        }
    }
}
