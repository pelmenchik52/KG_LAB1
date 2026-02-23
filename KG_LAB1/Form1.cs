using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.IO;
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

            InitializeComponent();
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(image);
            g.Clear(Color.White);
            drawAxes();
            pictureBox1.Image = image;

        }
        private void drawAxes()
        {
            if (g == null) return;

            Pen gridPen = new Pen(Color.FromArgb(235, 235, 235), 1);
            Pen axisPen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 8);
            Brush textBrush = Brushes.Black;

            float centerX = pictureBox1.Width / 2f;
            float centerY = pictureBox1.Height / 2f;

            int step;
            if (scale < 0.2) step = 200;
            else if (scale < 0.7) step = 100;
            else if (scale < 2.5) step = 50;
            else if (scale < 6) step = 10;
            else step = 1;

            for (int i = -5000; i <= 5000; i += step)
            {
                float screenX = centerX + (i * scale);
                if (screenX >= 0 && screenX <= pictureBox1.Width)
                {
                    g.DrawLine(gridPen, screenX, 0, screenX, pictureBox1.Height);
                }
            }

            for (int i = -5000; i <= 5000; i += step)
            {
                float screenY = centerY - (i * scale);
                if (screenY >= 0 && screenY <= pictureBox1.Height)
                {
                    g.DrawLine(gridPen, 0, screenY, pictureBox1.Width, screenY);
                }
            }

            g.DrawLine(axisPen, 0, centerY, pictureBox1.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, pictureBox1.Height);

            for (int i = -5000; i <= 5000; i += step)
            {
                float screenX = centerX + (i * scale);
                float screenY = centerY - (i * scale);

                if (screenX >= 0 && screenX <= pictureBox1.Width)
                {
                    g.DrawLine(axisPen, screenX, centerY - 5, screenX, centerY + 5);
                    if (i != 0)
                        g.DrawString(i.ToString(), font, textBrush, screenX - 10, centerY + 8);
                }

                if (screenY >= 0 && screenY <= pictureBox1.Height)
                {
                    g.DrawLine(axisPen, centerX - 5, screenY, centerX + 5, screenY);
                    if (i != 0)
                        g.DrawString(i.ToString(), font, textBrush, centerX + 8, screenY - 7);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(xCoordinateTextBox.Text) ||
                string.IsNullOrWhiteSpace(yCoordinateTextBox.Text) ||
                string.IsNullOrWhiteSpace(SideLengthTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля введення.");
                return;
            }

            if (int.TryParse(xCoordinateTextBox.Text, out int x0) && int.TryParse(yCoordinateTextBox.Text, out int y0) && int.TryParse(SideLengthTextBox.Text, out int lenght))
            {
                if (lenght <= 0)
                {
                    MessageBox.Show("Довжина сторони повинна бути додатною.");
                    return;
                }
                else if (x0 < -5000 || x0 > 5000 || y0 < -5000 || y0 > 5000)
                {
                    MessageBox.Show("Координати повинні бути в діапазоні від -5000 до 5000.");
                }
                else
                {
                    trianglesList.Add(new TriangleData
                    {
                        X = x0,
                        Y = y0,
                        lenght = lenght,
                        fillColor = triangleColor,
                        medianColor = mediansColor
                    });
                    updateScale();
                    redrawAll();
                }
            }
        }
        private void updateScale()
        {
            if (trianglesList.Count == 0) return;

            float maxCoord = 0;
            foreach (var tri in trianglesList)
            {
                float currentMax = Math.Max(Math.Abs(tri.X) + tri.lenght, Math.Abs(tri.Y) + tri.lenght);
                if (currentMax > maxCoord) maxCoord = currentMax;
            }

            float availableSpace = Math.Min(pictureBox1.Width, pictureBox1.Height) / 2.2f;
            scale = availableSpace / maxCoord;
        }
        public void redrawAll()
        {
            if (image == null || image.Width != pictureBox1.Width || image.Height != pictureBox1.Height)
            {
                image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(image);
                pictureBox1.Image = image;
            }
            g.Clear(Color.White);

            g.SmoothingMode = SmoothingMode.AntiAlias;

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
                g.ScaleTransform(1, -1);

                points[0] = new PointF(sx0, (int)(sy0 + R));
                points[1] = new PointF(sx0 - sLenght / 2, (int)(sy0 - R / 2));
                points[2] = new PointF(sx0 + sLenght / 2, (int)(sy0 - R / 2));

                medians[0] = new PointF(sx0, (int)(sy0 - R / 2));
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



        private void button4_Click(object sender, EventArgs e)
        {
            trianglesList.Clear();
            updateScale();
            redrawAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (trianglesList.Count == 0)
            {
                MessageBox.Show("Немає трикутників для збереження.");
                return;
            } else { 
            List<string> lines = new List<string>();
            foreach (var tri in trianglesList)
            {
                string line = $"{tri.X};{tri.Y};{tri.lenght};{tri.fillColor.ToArgb()};{tri.medianColor.ToArgb()}";
                lines.Add(line);
            }
            File.WriteAllLines("triangles.txt", lines);
            MessageBox.Show("Трикутники збережені у файл triangles.txt");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(File.Exists("triangles.txt"))
            {
                try
                {
                    trianglesList.Clear();

                    string[] lines = File.ReadAllLines("triangles.txt");

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(';');

                        if (parts.Length == 5)
                        {
                            TriangleData tri = new TriangleData
                            {
                                X = int.Parse(parts[0]),
                                Y = int.Parse(parts[1]),
                                lenght = int.Parse(parts[2]),
                                fillColor = Color.FromArgb(int.Parse(parts[3])),
                                medianColor = Color.FromArgb(int.Parse(parts[4]))
                            };
                            trianglesList.Add(tri);
                        }
                    }

                    updateScale();
                    redrawAll();

                    MessageBox.Show("Дані успішно завантажено з файлу!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при читанні файлу: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Файл triangles.txt не знайдено.");
            }
        }
    }
}
