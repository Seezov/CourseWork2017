using System.Drawing;

namespace TRUTLEGRAPH3
{
    class BlueTurtle : Turtle
    {
        private Pen _displayPen = new Pen(Color.Blue);

        public override void DrawTurtle()
        {
            G.DrawRectangle(_displayPen, CurrentPoint.X - 10, CurrentPoint.Y - 10, 20, 20);
        }

        public void DrawRectangle(string value, bool penIsActive)
        {
            for (int i = 0; i < 4; i++)
            {
                MoveForward(value, penIsActive);
                Angle += 90f;
            }
            DrawingArea.Invalidate();
        }
    }
}
