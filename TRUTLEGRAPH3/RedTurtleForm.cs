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
    public partial class RedTurtleForm : Form
    {
        RedTurtle turtle = new RedTurtle();

        public RedTurtleForm()
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            turtle.Clear();
        }

        private void DrawCircleButton_Click(object sender, EventArgs e)
        {
            turtle.DrawCircle(DCTextBox.Text, PenCheckBox.Checked);
        }
    }
}
