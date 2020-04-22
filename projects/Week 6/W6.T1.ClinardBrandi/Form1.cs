using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace W6.T1.ClinardBrandi
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

        private System.Drawing.Graphics g;
        private System.Drawing.Pen penBlue = new System.Drawing.Pen(Color.Blue, 2F);
        private System.Drawing.Pen penGreen = new System.Drawing.Pen(Color.Green, 4F);
        private System.Drawing.Pen penRed = new System.Drawing.Pen(Color.Red, 6F);
        private System.Drawing.Pen penBlack = new System.Drawing.Pen(Color.Black, 8F);




        private void btnLine_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawLine(penBlack, 250, 50, 400, 200);

        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawEllipse(penBlue, 300, 30, 100, 200);

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawRectangle(penRed, 0, 0, 200, 200);
        }

        private void btnArc_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawArc(penGreen, 0, 0, 100, 200, 45F, 270F);
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawPie(penRed, 200, 50, 50, 75, 30F, 180F);
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            System.Drawing.Point[] p = new System.Drawing.Point[6];
            p[0].X = 0;
            p[0].Y = 0;
            p[1].X = 53;
            p[1].Y = 111;
            p[2].X = 114;
            p[2].Y = 86;
            p[3].X = 34;
            p[3].Y = 34;
            p[4].X = 165;
            p[4].Y = 7;
            g = pictureBox1.CreateGraphics();
            g.DrawPolygon(penBlue, p);

        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawBezier(penGreen, 100, 100, 200, 10, 350, 50, 500, 100); ;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();

        }
    }
}
