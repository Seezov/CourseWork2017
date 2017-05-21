using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUTLEGRAPH3
{
    abstract class Turtle
    {
        public PointF CurrentPoint;
        public float Angle;
        private Pen _pen = new Pen(Color.Black);
        public Bitmap Bmp;
        public Graphics G;
        protected PictureBox DrawingArea;



        public Image buffer;

        public void Display(PictureBox drawingArea)
        {
            DrawingArea = drawingArea;
            CurrentPoint = new PointF(drawingArea.Width / 2, drawingArea.Height / 2);
            Bmp = new Bitmap(drawingArea.Width, drawingArea.Height);
            drawingArea.Image = Bmp;
            G = Graphics.FromImage(drawingArea.Image);
            buffer = new Bitmap(drawingArea.Image);
            DrawTurtle();
            drawingArea.Invalidate();
        }

        public abstract void DrawTurtle();

        public void MoveForward(string value, bool penIsActive)
        {
            G.Clear(Color.White);
            G.DrawImage(buffer, 0, 0);
            
            PointF toMovePoint = new PointF
            {
                X = (float)(CurrentPoint.X + int.Parse(value) * Math.Cos(Angle / 360 * 2 * Math.PI)),
                Y = (float)(CurrentPoint.Y + int.Parse(value) * Math.Sin(Angle / 360 * 2 * Math.PI))
            };
            
            
            if (penIsActive)
            {
                G.DrawLine(_pen, CurrentPoint, toMovePoint);
            }

            buffer = new Bitmap(DrawingArea.Image);
            CurrentPoint = toMovePoint;

            DrawTurtle();

            DrawingArea.Invalidate();
        }

        public void MoveBackwards(string value, bool penIsActive)
        {
            G.Clear(Color.White);
            G.DrawImage(buffer, 0, 0);

            PointF toMovePoint = new PointF
            {
                X = (float)(CurrentPoint.X + int.Parse(value) * -Math.Cos(Angle / 360 * 2 * Math.PI)),
                Y = (float)(CurrentPoint.Y + int.Parse(value) * -Math.Sin(Angle / 360 * 2 * Math.PI))
            };


            if (penIsActive)
            {
                G.DrawLine(_pen, CurrentPoint, toMovePoint);
            }

            buffer = new Bitmap(DrawingArea.Image);
            CurrentPoint = toMovePoint;

            DrawTurtle();

            DrawingArea.Invalidate();
        }

        public void TurnLeft(string value)
        {
            Angle -= float.Parse(value);
        }

        public void TurnRight(string value)
        {
            Angle += float.Parse(value);
        }

        public void Clear()
        {
            G.Clear(Color.White);
            buffer = new Bitmap(DrawingArea.Image);
            DrawTurtle();
            DrawingArea.Invalidate();
        }
    }
}
