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
        public MainForm()
        {
            InitializeComponent();
        }

        private RedTurtleForm RTForm;

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTForm == null)
            {
                RTForm = new RedTurtleForm();
                RTForm.MdiParent = this;
                RTForm.FormClosed += RTForm_FormClosed;
                RTForm.Show();
            }
            else
            {
                RTForm.Activate();
            }
        }

        private void RTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RTForm = null;
        }

        private GreenTurtleForm GTForm;

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GTForm == null)
            {
                GTForm = new GreenTurtleForm();
                GTForm.MdiParent = this;
                GTForm.FormClosed += GTForm_FormClosed;
                GTForm.Show();
            }
            else
            {
                GTForm.Activate();
            }
        }

        private void GTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GTForm = null;
        }

        private BlueTurtleForm BTForm;

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BTForm == null)
            {
                BTForm = new BlueTurtleForm();
                BTForm.MdiParent = this;
                BTForm.FormClosed += BTForm_FormClosed;
                BTForm.Show();
            }
            else
            {
                BTForm.Activate();
            }
        }

        private void BTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BTForm = null;
        }
    }
}
