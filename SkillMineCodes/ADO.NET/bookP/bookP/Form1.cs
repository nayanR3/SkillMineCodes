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

namespace bookP
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 - write sql query
                string qry = "insert into Book values (@name, @price, @author, @publication, @edition)";

                // step 3 - assign query to command class
                cmd = new SqlCommand(qry, con);

                // step 4 - assign value to the parameter
                cmd.Parameters.AddWithValue("@name", txtN.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtP.Text));
                cmd.Parameters.AddWithValue("@author", txtAN.Text);
                cmd.Parameters.AddWithValue("@publication", txtPB.Text);
                cmd.Parameters.AddWithValue("@edition", Convert.ToInt32(txtE.Text));

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        private void ClearForm()
        {
            txtI.Clear();
            txtN.Clear();
            txtAN.Clear();
            txtP.Clear();
            txtE.Clear();
            txtPB.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  write the sql query
                string qry = "update Book set Name=@name, Price=@price, AuthorName=@author, Publication=@publication, Edition=@edition where Id=@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtI.Text));
                cmd.Parameters.AddWithValue("@name", txtN.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtP.Text));
                cmd.Parameters.AddWithValue("@author", txtAN.Text);
                cmd.Parameters.AddWithValue("@publication", txtPB.Text);
                cmd.Parameters.AddWithValue("@edition", Convert.ToInt32(txtE.Text));


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
                string qry = "delete from Book where Id=@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtI.Text));

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
                string qry = "select * from Book where Id =@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtI.Text));

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
                        txtP.Text = dr["Price"].ToString();
                        txtAN.Text = dr["AuthorName"].ToString();
                        txtPB.Text = dr["Publication"].ToString();
                        txtE.Text = dr["Edition"].ToString();
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

        private void btnSA_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Book";
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
