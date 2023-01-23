using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace studentProject
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
            txtR.Clear();
            txtN.Clear();
            txtS.Clear();
            txtP.Clear();
            txtA.Clear();
            txtG.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 - write sql query
                string qry = "insert into Student values (@name, @stream, @percentage, @age, @gender)";

                // step 3 - assign query to command class
                cmd = new SqlCommand(qry, con);

                // step 4 - assign value to the parameter
                cmd.Parameters.AddWithValue("@name", txtN.Text);
                cmd.Parameters.AddWithValue("@stream", txtS.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToInt32(txtP.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtA.Text));
                cmd.Parameters.AddWithValue("@gender", txtG.Text);

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
                string qry = "update Student set Name=@name, Stream=@stream, Percentage=@percentage, Age=@age, Gender=@gender where RollNo=@rollno";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@name", txtN.Text);
                cmd.Parameters.AddWithValue("@stream", txtS.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToInt32(txtP.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtA.Text));
                cmd.Parameters.AddWithValue("@gender", txtG.Text);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtR.Text));

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
                string qry = "delete from Student where RollNo=@rollno";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtR.Text));

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
                string qry = "select * from Student where RollNo =@rollno";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtR.Text));

                // step 5 - open conn
                con.Open();

                // step 6 - fire the query
                dr = cmd.ExecuteReader();
                // fire the select query

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtN.Text = dr["Name"].ToString();
                        txtS.Text = dr["Stream"].ToString();
                        txtP.Text = dr["Percentage"].ToString();
                        txtA.Text = dr["Age"].ToString();
                        txtG.Text = dr["Gender"].ToString();
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
                string qry = "select * from Student";
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
