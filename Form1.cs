using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_13___Programming_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radRedSelected(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.Red;
            grpTextColor.BackColor = Color.Red;
            this.BackColor = Color.Red;
            grpBackColor.BackColor = Color.Red;
            radBlue.BackColor = Color.Red;
            radCyan.BackColor = Color.Red;
            radGreen.BackColor = Color.Red;
            radMagenta.BackColor = Color.Red;
            radRed.BackColor = Color.Red;
            radYellow.BackColor = Color.Red;
        }

        private void radGreenSelected(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.Green;
            grpTextColor.BackColor = Color.Green;
            this.BackColor = Color.Green;
            grpBackColor.BackColor = Color.Green;
            radBlue.BackColor = Color.Green;
            radCyan.BackColor = Color.Green;
            radGreen.BackColor = Color.Green;
            radMagenta.BackColor = Color.Green;
            radRed.BackColor = Color.Green;
            radYellow.BackColor = Color.Green;
        }

        private void radBlueSelected(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.Blue;
            grpTextColor.BackColor = Color.Blue;
            this.BackColor = Color.Blue;
            grpBackColor.BackColor = Color.Blue;
            radBlue.BackColor = Color.Blue;
            radCyan.BackColor = Color.Blue;
            radGreen.BackColor = Color.Blue;
            radMagenta.BackColor = Color.Blue;
            radRed.BackColor = Color.Blue;
            radYellow.BackColor = Color.Blue;
        }

        private void radCyanSelected(object sender, EventArgs e)
        {
            lblColor.ForeColor = Color.Cyan;
            grpTextColor.ForeColor = Color.Cyan;
            this.ForeColor = Color.Cyan;
            grpBackColor.ForeColor = Color.Cyan;
            radBlue.ForeColor = Color.Cyan;
            radCyan.ForeColor = Color.Cyan;
            radGreen.ForeColor = Color.Cyan;
            radMagenta.ForeColor = Color.Cyan;
            radRed.ForeColor = Color.Cyan;
            radYellow.ForeColor = Color.Cyan;
        }

        private void radMagentaSelected(object sender, EventArgs e)
        {
            lblColor.ForeColor = Color.Magenta;
            grpTextColor.ForeColor = Color.Magenta;
            this.ForeColor = Color.Magenta;
            grpBackColor.ForeColor = Color.Magenta;
            radBlue.ForeColor = Color.Magenta;
            radCyan.ForeColor = Color.Magenta;
            radGreen.ForeColor = Color.Magenta;
            radMagenta.ForeColor = Color.Magenta;
            radRed.ForeColor = Color.Magenta;
            radYellow.ForeColor = Color.Magenta;
        }

        private void radYellowSelected(object sender, EventArgs e)
        {
            lblColor.ForeColor = Color.Yellow;
            grpTextColor.ForeColor = Color.Yellow;
            this.ForeColor = Color.Yellow;
            grpBackColor.ForeColor = Color.Yellow;
            radBlue.ForeColor = Color.Yellow;
            radCyan.ForeColor = Color.Yellow;
            radGreen.ForeColor = Color.Yellow;
            radMagenta.ForeColor = Color.Yellow;
            radRed.ForeColor = Color.Yellow;
            radYellow.ForeColor = Color.Yellow;
        }
    }
}
