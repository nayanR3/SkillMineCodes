using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BasicForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtEmpSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            string path = @"D:\nr.txt";

            try
            {
                FileStream fs = new FileStream(@"D:\nr.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(txtDName.Text);
                bw.Write(Convert.ToInt32(txtDId.Text));
                bw.Write(txtDLoc.Text);

                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to file..");

                txtDName.Clear();
                txtDId.Clear();
                txtDLoc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            string path = @"D:\nr.txt";
            try
            {
                FileStream fs = new FileStream(@"D:\nr.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtDName.Text = br.ReadString();
                txtDId.Text = br.ReadInt32().ToString();
                txtDLoc.Text = br.ReadString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
