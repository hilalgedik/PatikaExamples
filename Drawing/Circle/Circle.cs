using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing.Circle
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int r;

            r = Convert.ToInt32(txtR.Text);

            int penWidth = 5;
            Pen pen = new Pen(Color.Green, penWidth);


            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g.DrawEllipse(pen,250-r,150-r,2*r,2*r);

            pictureBox1.Image=bitmap;
        }
    }
}
