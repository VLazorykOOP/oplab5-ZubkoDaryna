using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Point P1, P2;
        private Vector V1, V2;
        private float scale = 2.0f; 

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateParameters();
        }

        private void pictureBoxCurve_Paint(object sender, PaintEventArgs e)
        {
            DrawHermiteCurve(e.Graphics);
        }

        private void UpdateParameters()
        {
            try
            {
                int x1 = int.Parse(textBoxX1.Text);
                int y1 = int.Parse(textBoxY1.Text);
                int x2 = int.Parse(textBoxX2.Text);
                int y2 = int.Parse(textBoxY2.Text);
                int vx1 = int.Parse(textBoxVx1.Text);
                int vy1 = int.Parse(textBoxVy1.Text);
                int vx2 = int.Parse(textBoxVx2.Text);
                int vy2 = int.Parse(textBoxVy2.Text);

                P1 = new Point(x1, y1);
                P2 = new Point(x2, y2);
                V1 = new Vector(vx1, vy1);
                V2 = new Vector(vx2, vy2);

                pictureBoxCurve.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values.");
            }
        }

        private void DrawHermiteCurve(Graphics g)
        {
            g.Clear(Color.White);

            Point scaledP1 = new Point((int)(P1.X * scale), (int)(P1.Y * scale));
            Point scaledP2 = new Point((int)(P2.X * scale), (int)(P2.Y * scale));
            Vector scaledV1 = new Vector((int)(V1.X * scale), (int)(V1.Y * scale));
            Vector scaledV2 = new Vector((int)(V2.X * scale), (int)(V2.Y * scale));

           
            g.FillEllipse(Brushes.Red, scaledP1.X - 3, scaledP1.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Blue, scaledP2.X - 3, scaledP2.Y - 3, 6, 6);

           
            float t_step = 0.01f;
            Point prevPoint = scaledP1;
            for (float t = 0; t <= 1; t += t_step)
            {
                Point currentPoint = CalculateHermitePoint(scaledP1, scaledP2, scaledV1, scaledV2, t);
                g.DrawLine(Pens.Black, prevPoint, currentPoint);
                prevPoint = currentPoint;
            }

            DrawVectorArrow(g, scaledP1, scaledV1);
            DrawVectorArrow(g, scaledP2, scaledV2);
        }

        private Point CalculateHermitePoint(Point P1, Point P2, Vector V1, Vector V2, float t)
        {
            float t2 = t * t;
            float t3 = t2 * t;

            float h1 = 2 * t3 - 3 * t2 + 1;
            float h2 = -2 * t3 + 3 * t2;
            float h3 = t3 - 2 * t2 + t;
            float h4 = t3 - t2;

            float x = h1 * P1.X + h2 * P2.X + h3 * V1.X + h4 * V2.X;
            float y = h1 * P1.Y + h2 * P2.Y + h3 * V1.Y + h4 * V2.Y;

            return new Point((int)x, (int)y);
        }

        private void DrawVectorArrow(Graphics g, Point basePoint, Vector vector)
        {
            float arrowSize = 10; 
            float angle = (float)Math.Atan2(vector.Y, vector.X);
            Point endPoint = new Point((int)(basePoint.X + vector.X), (int)(basePoint.Y + vector.Y));
            g.DrawLine(Pens.Green, basePoint, endPoint);

            PointF[] arrow = new PointF[3];
            arrow[0] = new PointF(endPoint.X, endPoint.Y);
            arrow[1] = new PointF(endPoint.X - arrowSize * (float)Math.Cos(angle - Math.PI / 6), endPoint.Y - arrowSize * (float)Math.Sin(angle - Math.PI / 6));
            arrow[2] = new PointF(endPoint.X - arrowSize * (float)Math.Cos(angle + Math.PI / 6), endPoint.Y - arrowSize * (float)Math.Sin(angle + Math.PI / 6));
            g.FillPolygon(Brushes.Green, arrow);
        }
    }

    public struct Vector
    {
        public int X, Y;

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
