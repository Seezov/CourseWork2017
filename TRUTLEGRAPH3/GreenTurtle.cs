using System.Drawing;

namespace TRUTLEGRAPH3
{
    class GreenTurtle : Turtle
    {
        private Pen _displayPen = new Pen(Color.Green);
        public override void DrawTurtle()
        {
            PointF[] points = new PointF[4];
            
            PointF point1 = new PointF(CurrentPoint.X, CurrentPoint.Y - 10);
            points[0] = point1;
            PointF point2 = new PointF(CurrentPoint.X - 10, CurrentPoint.Y + 10);
            points[1] = point2;
            PointF point3 = new PointF(CurrentPoint.X + 10, CurrentPoint.Y + 10);
            points[2] = point3;
            PointF point4 = new PointF(CurrentPoint.X, CurrentPoint.Y - 10);
            points[3] = point4;

            G.DrawLines(_displayPen,points);
            
        }

        public void DrawTriangle(string value, bool penIsActive)
        {
            Angle -= 60f;
            for (int i = 0; i < 3; i++)
            {
                Angle += 120f;
                MoveForward(value, penIsActive); 
            }
            DrawingArea.Invalidate();
            Angle += 60f;
        }
    }
}
