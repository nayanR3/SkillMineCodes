using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpName.Clear();
            txtEmpId.Clear();
            txtBasicSal.Clear();
            txtHra.Clear();
            txtDa.Clear();
            txtPf.Clear();
            txtTotalSal.Clear();
        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalSal_Click(object sender, EventArgs e)
        {
            double bsal = Convert.ToDouble(txtBasicSal.Text);

            double hra = bsal * .15; 
            double da = bsal * .10;
            double pf = bsal * .15;
            double totalSal = (bsal + hra + da)- pf;

            txtHra.Text = hra.ToString();
            txtDa.Text = da.ToString();
            txtPf.Text = pf.ToString();

            txtTotalSal.Text = totalSal.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                 ("Name - " + txtEmpName.Text +
                 "\nId - " + txtEmpId.Text +
                 "\nBasic salary - " + txtBasicSal.Text +
                 "\nTotal Salary - " + txtTotalSal.Text
                ) ;
        }
    }
}
