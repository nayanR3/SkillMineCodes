using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicForm
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\student.dat", FileMode.Create, FileAccess.Write);

                // 2nd step
                Student student = new Student();
                student.Name = txtSName.Text;
                student.RollNo = Convert.ToInt32(txtSRollNo.Text);
                student.Percentage = Convert.ToInt32(txtSPercentage.Text);
                student.Department = deptList.Text;

                // 3rd step
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, student);
                fs.Close();

                MessageBox.Show("Data added to the file");

                txtSRollNo.Clear();
                txtSPercentage.Clear();
                txtSName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\student.dat", FileMode.Open, FileAccess.Read);

                // 2nd step
                Student student = new Student();

                // 3rd step
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                student = (Student)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtSRollNo.Text = student.RollNo.ToString();
                txtSName.Text = student.Name;
                txtSPercentage.Text = student.Percentage.ToString();
                deptList.Text = student.Department;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\studentXml.xml", FileMode.Create, FileAccess.Write);

                // 2nd step
                Student student = new Student();
                student.Name = txtSName.Text;
                student.RollNo = Convert.ToInt32(txtSRollNo.Text);
                student.Percentage = Convert.ToInt32(txtSPercentage.Text);

                // 3rd step

                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(fs, student);


                MessageBox.Show("Data added to the file");

                txtSRollNo.Clear();
                txtSPercentage.Clear();
                txtSName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\studentXml.xml", FileMode.Open, FileAccess.Read);

                // 2nd step
                Student student = new Student();

                // 3rd step
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                student = (Student)xml.Deserialize(fs);
                fs.Close();

                txtSRollNo.Text = student.RollNo.ToString();
                txtSName.Text = student.Name;
                txtSPercentage.Text = student.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\student.soap", FileMode.Create, FileAccess.Write);

                // 2nd step
                Student student = new Student();
                student.Name = txtSName.Text;
                student.RollNo = Convert.ToInt32(txtSRollNo.Text);
                student.Percentage = Convert.ToInt32(txtSPercentage.Text);

                // 3rd step
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, student);
                fs.Close();

                MessageBox.Show("Data added to the file");

                txtSRollNo.Clear();
                txtSPercentage.Clear();
                txtSName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\student.soap", FileMode.Open, FileAccess.Read);

                // 2nd step
                Student student = new Student();

                // 3rd step
                SoapFormatter soapFormatter = new SoapFormatter();
                student = (Student)soapFormatter.Deserialize(fs);
                fs.Close();

                txtSRollNo.Text = student.RollNo.ToString();
                txtSName.Text = student.Name;
                txtSPercentage.Text = student.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\studentjson.json", FileMode.Create, FileAccess.Write);

                // 2nd step
                Student student = new Student();
                student.Name = txtSName.Text;
                student.RollNo = Convert.ToInt32(txtSRollNo.Text);
                student.Percentage = Convert.ToInt32(txtSPercentage.Text);

                // 3rd step

                JsonSerializer.Serialize<Student>(fs, student);
                fs.Close();


                MessageBox.Show("Data added to the file");

                txtSRollNo.Clear();
                txtSPercentage.Clear();
                txtSName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\studentjson.json", FileMode.Open, FileAccess.Read);

                // 2nd step
                Student student = new Student();

                // 3rd step
                student = JsonSerializer.Deserialize<Student>(fs);
                fs.Close();

                txtSRollNo.Text = student.RollNo.ToString();
                txtSName.Text = student.Name;
                txtSPercentage.Text = student.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSRollNo.Clear();
            txtSPercentage.Clear();
            txtSName.Clear();
            //deptList.Items.Clear();
            deptList.ResetText();
        }

        private void lblEmpSal_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDept_Click(object sender, EventArgs e)
        {

        }
    }
}
