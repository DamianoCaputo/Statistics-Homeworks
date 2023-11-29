using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statistic_language_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);

            //linea
            Point point1 = new Point(10, 10);
            Point point2 = Point.Add(point1, new Size(255, 0));
            e.Graphics.DrawLine(blkpen, point1, point2);

            //punto
            Point point3 = new Point(300, 10);
            Point point4 = Point.Add(point3, new Size(1, 0));
            e.Graphics.DrawLine(blkpen, point3, point4);

            //cerchio
            e.Graphics.DrawEllipse(blkpen, 350, 10, 30, 30);


            //rettangolo
            e.Graphics.DrawRectangle(blkpen, 400, 10, 150, 90);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
