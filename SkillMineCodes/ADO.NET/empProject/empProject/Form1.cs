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

namespace empProject
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
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
                // step 2 - write sql query
                string qry = "insert into Employee values (@name, @age, @dept, @salary)";

                // step 3 - assign query to command class
                cmd = new SqlCommand(qry, con);

                // step 4 - assign value to the parameter
                cmd.Parameters.AddWithValue("@name", txtEN.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtEA.Text));
                cmd.Parameters.AddWithValue("@dept", txtED.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtES.Text));

                // step 5
                // open conn
                con.Open();

                // step 6 - fire the query
                int result = cmd.ExecuteNonQuery();
                // fire the insert /update / delete

                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step 7
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  write the sql query
                string qry = "update Employee set empName=@name, empAge=@age, empDept=@dept, empSalary=@salary where empId=@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@name", txtEN.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtEA.Text));
                cmd.Parameters.AddWithValue("@dept", txtED.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtES.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEI.Text));

                // step 5 - open conn
                con.Open();

                // step 6 - fire the query
                int result = cmd.ExecuteNonQuery(); // fire the insert /update / delete
                if (result == 1)
                {
                    MessageBox.Show("Record updated");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  > write the sql query
                string qry = "delete from Employee where empId=@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assing values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEI.Text));

                // step 5 - open conn
                con.Open();

                // step 6 - fire the query
                int result = cmd.ExecuteNonQuery();
                // fire the insert /update / delete
                if (result == 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  > write the sql query
                string qry = "select * from Employee where empId =@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assing values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEI.Text));

                // step 5 - open conn
                con.Open();

                // step 6 - fire the query
                dr = cmd.ExecuteReader();
                // fire the select query

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtEN.Text = dr["empName"].ToString();
                        txtEA.Text = dr["empAge"].ToString();
                        txtED.Text = dr["empDept"].ToString();
                        txtES.Text = dr["empSalary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
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
                string qry = "select * from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                // fire the select query
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    GridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // step 7
                con.Close();
            }

        }
    }
}
