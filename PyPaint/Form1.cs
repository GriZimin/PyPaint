using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyPaint
{
    public partial class Form1 : Form
    {
        Palette palette;
        Graphics g;
        Point oldPoint, newPoint;
        public Color currentColor;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            palette = new Palette(this);
            palette.Show();
        }

        public void Clear()
        {
            g.Clear(Color.White);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Clear();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            newPoint = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(new Pen(currentColor), newPoint, oldPoint);
            }
            oldPoint = newPoint;
        }
    }
}
