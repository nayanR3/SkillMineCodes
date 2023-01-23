using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empDisconnectProject
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommandBuilder sqlCommandBuilder;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            con =
                new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
        }

        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("select * from employee", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "employee"); // product is table empName given to the DataSet
            return ds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtEI.Clear();
            txtEN.Clear();
            txtEA.Clear();
            txtED.Clear();
            txtES.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["employee"].NewRow();
                row["empName"] = txtEN.Text;
                row["empAge"] = txtEA.Text;
                row["empDept"] = txtED.Text;
                row["empSalary"] = txtES.Text;

                ds.Tables["employee"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["employee"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted..");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["employee"].Rows.Find(txtEI.Text);

                if (row != null)
                {
                    row["empName"] = txtEN.Text;
                    row["empage"] = txtEA.Text;
                    row["empDept"] = txtED.Text;
                    row["empSalary"] = txtES.Text;

                    int result = adapter.Update(ds.Tables["employee"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated..");
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["employee"].Rows.Find(txtEI.Text);

                if (row != null)
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["employee"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record deleted..");
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["employee"].Rows.Find(txtEI.Text);

                if (row != null)
                {
                    txtEN.Text = row["empName"].ToString();
                    txtEA.Text = row["empage"].ToString();
                    txtED.Text = row["empDept"].ToString();
                    txtES.Text = row["empSalary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                GridView1.DataSource = ds.Tables["employee"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
