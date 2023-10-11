using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contextMenuStripDino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public FormContextMenuStrip()

        {

            InitializeComponent();

        }  

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtBoxD.Text = txtBoxL.Text;

        }

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)

        {

            txtBoxL.Text = txtBoxD.Text;

        }
    }
}
