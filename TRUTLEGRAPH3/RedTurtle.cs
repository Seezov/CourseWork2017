using System.Drawing;

namespace TRUTLEGRAPH3
{
    class RedTurtle : Turtle
    {
        private Pen _displayPen = new Pen(Color.Red);

        public override void DrawTurtle()
        {
            G.DrawEllipse(_displayPen, CurrentPoint.X - 10, CurrentPoint.Y - 10, 20, 20);
        }

        public void DrawCircle(string value, bool penIsActive)
        {
            for (int i = 0; i < 18; i++)
            {
                MoveForward(value, penIsActive);
                Angle += 20f;
            }
            DrawingArea.Invalidate();
        }
    }
}
