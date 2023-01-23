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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string folderName = txtFolderName.Text;
            string path = @"D:\";
            path = string.Concat(path,folderName);

            try
            {
                if(Directory.Exists(path))
                {
                    MessageBox.Show("folder already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("folder created");                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderName.Text;
            string filePath = txtFileName.Text;

            string path = @"D:\" + folderPath;

            string filePathExtra = @"\" + filePath ;
            path= string.Concat(path, filePathExtra);

            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("file already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("file created");
                    txtFileName.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string folderName = txtFolderName.Text;

            string path = @"D:\";

            path= string.Concat(path, folderName);

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
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

        private void lblFileName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string folderName = txtFolderName.Text;
            string fileName = txtFileName.Text;
            string path = @"D:\" + folderName;
            path = string.Concat(path, fileName);



            try
            {
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtEmpId.Text));
                bw.Write(txtEmpName.Text);
                bw.Write(Convert.ToDouble(txtEmpSal.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to "+ path+" file..");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
