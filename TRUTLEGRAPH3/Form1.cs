using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUTLEGRAPH3
{
    public partial class MainForm : Form
    {
        Turtle turtle = new Turtle();

        public MainForm()
        {
            InitializeComponent();
            turtle.Angle = 0;
            turtle.Display(DrawingArea);
        }

        private void MoveForwardButton_Click(object sender, EventArgs e)
        {
            turtle.MoveForward(MFTextBox.Text, PenCheckBox.Checked);
        }

        private void MoveBackwardsButton_Click(object sender, EventArgs e)
        {
            turtle.MoveBackwards(MBTextBox.Text, PenCheckBox.Checked);
        }

        private void TurnLeftButton_Click(object sender, EventArgs e)
        {
            turtle.TurnLeft(TLTextBox.Text);
        }

        private void TurnRightButton_Click(object sender, EventArgs e)
        {
            turtle.TurnRight(TRTextBox.Text);
        }

        private void DrawCircleButton_Click(object sender, EventArgs e)
        {
            turtle.DrawCircle(RadiusTextBox.Text,PenCheckBox.Checked);
        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            turtle.DrawTriangle(TriangleTextBox.Text, PenCheckBox.Checked);
        }
    }
}
