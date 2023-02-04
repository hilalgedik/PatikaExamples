using System.Numerics;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            int x1 = int.Parse(txtPoint1x.Text);
            int y1 = int.Parse(txtPoint1y.Text);
            int x2 = int.Parse(txtPoint2x.Text);
            int y2 = int.Parse(txtPoint2y.Text);
            int x3 = int.Parse(txtPoint3x.Text);
            int y3 = int.Parse(txtPoint3y.Text);

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);
            Point[] points = { point1, point2, point3 };

            int penWidth = 5;
            Pen pen = new Pen(Color.DeepPink, penWidth);

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawPolygon(pen, points);

            pictureBox.Image = bitmap;

        }
    }
}