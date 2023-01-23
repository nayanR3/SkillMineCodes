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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BasicForm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void lblEmpId_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);

                // 2nd step
                Employee employee = new Employee();
                employee.Name = txtEmpName.Text;
                employee.Id = Convert.ToInt32(txtEmpId.Text);
                employee.Salary = Convert.ToInt32(txtEmpSal.Text);

                // 3rd step
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, employee);
                fs.Close();

                MessageBox.Show("Data added to the file");
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);

                // 2nd step
                Employee employee = new Employee();

                // 3rd step
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                employee = (Employee)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtEmpId.Text = employee.Id.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSal.Text = employee.Salary.ToString();

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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employees.soap", FileMode.Create, FileAccess.Write);

                // 2nd step
                Employee employee = new Employee();
                employee.Name = txtEmpName.Text;
                employee.Id = Convert.ToInt32(txtEmpId.Text);
                employee.Salary = Convert.ToInt32(txtEmpSal.Text);

                // 3rd step
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, employee);
                fs.Close();

                MessageBox.Show("Data added to the file");

                txtEmpName.Clear();
                txtEmpSal.Clear();
                txtEmpId.Clear();
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employees.soap", FileMode.Open, FileAccess.Read);

                // 2nd step
                Employee employee = new Employee();

                // 3rd step
                SoapFormatter soapFormatter = new SoapFormatter();
                employee = (Employee)soapFormatter.Deserialize(fs);
                fs.Close();

                txtEmpId.Text = employee.Id.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSal.Text = employee.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // 1st step
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeesXml.xml", FileMode.Create, FileAccess.Write);

                // 2nd step
                Employee employee = new Employee();
                employee.Name = txtEmpName.Text;
                employee.Id = Convert.ToInt32(txtEmpId.Text);
                employee.Salary = Convert.ToInt32(txtEmpSal.Text);

                // 3rd step

                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, employee);


                MessageBox.Show("Data added to the file");

                txtEmpName.Clear();
                txtEmpSal.Clear();
                txtEmpId.Clear();
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeesXml.xml", FileMode.Open, FileAccess.Read);

                // 2nd step
                Employee employee = new Employee();

                // 3rd step
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                employee = (Employee)xml.Deserialize(fs);
                fs.Close();

                txtEmpId.Text = employee.Id.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSal.Text = employee.Salary.ToString();

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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employeejson.json", FileMode.Create, FileAccess.Write);

                // 2nd step
                Employee employee = new Employee();
                employee.Name = txtEmpName.Text;
                employee.Id = Convert.ToInt32(txtEmpId.Text);
                employee.Salary = Convert.ToInt32(txtEmpSal.Text);

                // 3rd step

                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close();


                MessageBox.Show("Data added to the file");

                txtEmpName.Clear();
                txtEmpSal.Clear();
                txtEmpId.Clear();
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
                FileStream fs = new FileStream(@"D:\SkillMineDoc\Employeejson.json", FileMode.Open, FileAccess.Read);

                // 2nd step
                Employee employee = new Employee();

                // 3rd step
                employee = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                txtEmpId.Text = employee.Id.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSal.Text = employee.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
