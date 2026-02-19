using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
namespace KG_LAB1
{
    public partial class Form1 : Form
    {
        public struct TriangleData
        {
            public int X;
            public int Y;
            public int lenght;
            public Color fillColor;
            public Color medianColor;
        }
        List<TriangleData> trianglesList = new List<TriangleData>();
        float scale = 1f;
        Color triangleColor = Color.Red;
        Color mediansColor = Color.Blue;
        Bitmap image;
        Graphics g;
        public Form1()
        {
            image = new Bitmap(1000, 720,
                System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            InitializeComponent();
            g = Graphics.FromImage(image);
            g.Clear(Color.White);
            drawAxes();
            pictureBox1.Image = image;

        }
        private void drawAxes()
        {
            Pen pen = new Pen(Color.LightGray, 1);
            g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawLine(pen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(xCoordinateTextBox.Text, out int x0) && int.TryParse(yCoordinateTextBox.Text, out int y0) && int.TryParse(SideLengthTextBox.Text, out int lenght))
            {
                trianglesList.Add(new TriangleData
                {
                    X = x0,
                    Y = y0,
                    lenght = lenght,
                    fillColor = triangleColor,
                    medianColor = mediansColor
                });
                redrawAll();
            }
        }
        public void redrawAll()
        {
            g.Clear(Color.White);
            drawAxes();

            foreach (var tri in trianglesList)
            {
                PointF[] points = new PointF[] {
                new PointF(0, 0),
                new PointF(0, 0),
                new PointF(0, 0)
            };
                PointF[] medians = new PointF[] {
                new PointF(0, 0),
                new PointF(0, 0),
                new PointF(0, 0)
            };
                float sx0 = tri.X * scale;
                float sy0 = tri.Y * scale;
                float sLenght = tri.lenght * scale;
                float R = (float)(sLenght / Math.Sqrt(3));
                var state = g.Save();
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

                points[0] = new PointF(sx0, (int)(sy0 - R));
                points[1] = new PointF(sx0 - sLenght / 2, (int)(sy0 + R / 2));
                points[2] = new PointF(sx0 + sLenght / 2, (int)(sy0 + R / 2));

                medians[0] = new PointF(sx0, (int)(sy0 + R / 2));
                medians[1] = new PointF((int)((points[0].X + points[2].X) / 2f), (int)((points[0].Y + points[2].Y) / 2f));
                medians[2] = new PointF((int)((points[0].X + points[1].X) / 2f), (int)((points[0].Y + points[1].Y) / 2f));

                Pen pen = new Pen(Color.Black, 3);
                Pen penForMedians = new Pen(tri.medianColor, 3);
                SolidBrush brush = new SolidBrush(tri.fillColor);

                g.DrawPolygon(pen, points);
                g.FillPolygon(brush, points);
                g.DrawLine(penForMedians, points[0], medians[0]);
                g.DrawLine(penForMedians, points[1], medians[1]);
                g.DrawLine(penForMedians, points[2], medians[2]);
                pen.Dispose();

                g.Restore(state);
            }
            pictureBox1.Invalidate();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                triangleColor = colorDialog1.Color;
                button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                mediansColor = colorDialog2.Color;
                button1_Click(sender, e);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scale = trackBar1.Value / 10f;
            redrawAll();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            trianglesList.Clear();
            redrawAll();
        }
    }
}
