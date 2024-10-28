using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            lblAddition.Visible = true;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            lblSubtraction.Visible = true;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            lblMultiplication.Visible = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            lblDivision.Visible = true;
        }
    }
}
