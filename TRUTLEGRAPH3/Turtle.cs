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
    class Turtle
    {
        public PointF CurrentPoint;
        public float Angle;
        public Pen Pen = new Pen(Color.Black);
        public Bitmap Bmp;
        public Graphics G;
        private PictureBox _drawingArea;



        public Image buffer;

        public void Display(PictureBox drawingArea)
        {
            
            _drawingArea = drawingArea;
            CurrentPoint = new PointF(drawingArea.Width / 2, drawingArea.Height / 2);
            Bmp = new Bitmap(drawingArea.Width, drawingArea.Height);
            drawingArea.Image = Bmp;
            G = Graphics.FromImage(drawingArea.Image);
            buffer = new Bitmap(drawingArea.Image);
            DrawTurtle();
            drawingArea.Invalidate();

        }

        private void DrawTurtle()
        { 
            G.DrawRectangle(Pen, CurrentPoint.X - 5, CurrentPoint.Y - 5, 10, 10);
        }


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
                G.DrawLine(Pen, CurrentPoint, toMovePoint);
            }

            buffer = new Bitmap(_drawingArea.Image);
            CurrentPoint = toMovePoint;

            DrawTurtle();

            _drawingArea.Invalidate();
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
                G.DrawLine(Pen, CurrentPoint, toMovePoint);
            }

            buffer = new Bitmap(_drawingArea.Image);
            CurrentPoint = toMovePoint;

            DrawTurtle();

            _drawingArea.Invalidate();
        }

        public void TurnLeft(string value)
        {
            Angle -= float.Parse(value);
        }

        public void TurnRight(string value)
        {
            Angle += float.Parse(value);
        }

        public void DrawCircle(string value, bool penIsActive)
        {
            for (int i = 0; i < 18; i++)
            {
                MoveForward(value,true);
                Angle += 20f;
            }
            _drawingArea.Invalidate();
        }

        public void DrawTriangle(string value, bool penIsActive)
        {
            for (int i = 0; i < 3; i++)
            {
                MoveForward(value, true);
                Angle += 120f;
            }
            _drawingArea.Invalidate();
        }
    }
}
