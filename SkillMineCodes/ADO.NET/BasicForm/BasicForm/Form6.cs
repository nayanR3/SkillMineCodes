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

namespace BasicForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\SkillMineDoc");

            try
            {
                if (info.Exists)
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    info.Create();
                    MessageBox.Show("Directory created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(@"D:\SkillMineDoc\Test1.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    fileinfo.Create();
                    MessageBox.Show("File created");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(@"D:\SkillMineDoc\Test1.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    fileinfo.Delete();
                    MessageBox.Show("File has been removed");
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\SkillMineDoc");
            try
            {
                if (info.Exists)
                {
                    info.Delete();
                    MessageBox.Show("folder has been removed");
                }
                else
                {
                    MessageBox.Show("folder not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc\Text1.txt";

            try
            {
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(txtEmpName.Text);
                bw.Write(Convert.ToInt32(txtEmpSal.Text));
                bw.Write(Convert.ToInt32(txtEmpId.Text));

                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to file..");

                txtEmpName.Clear();
                txtEmpSal.Clear();
                txtEmpId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblEmpName_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            string path = @"D:\SkillMineDoc\Text1.txt";
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpName.Text = br.ReadString();
                txtEmpSal.Text = br.ReadInt32().ToString();
                txtEmpId.Text = br.ReadInt32().ToString();
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
