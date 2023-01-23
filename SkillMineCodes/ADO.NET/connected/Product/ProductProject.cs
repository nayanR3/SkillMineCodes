using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Project
{
    public partial class ProductProject : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public ProductProject()
        {
            InitializeComponent();

            // step 1 - set configuration with db server
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
        }

        private void ProductProject_Load(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtPI.Clear();
            txtPN.Clear();
            txtPP.Clear();
            txtCN.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 - write sql query
                string qry = "insert into product values (@name, @price, @cName)";

                // step 3 - assign query to command class
                cmd= new SqlCommand(qry, con);

                // step 4 - assign value to the parameter
                cmd.Parameters.AddWithValue("@name", txtPN.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPP.Text));
                cmd.Parameters.AddWithValue("@cName", txtCN.Text);                
                
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

        private void txtPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // step 2 -  write the sql query
                string qry = "update Product set Name=@name, price=@price, companyName=@comp where Id=@id";
                
                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);
                
                // step-4  assign values to the parameter
                cmd.Parameters.AddWithValue("@name", txtPN.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPP.Text));
                cmd.Parameters.AddWithValue("@comp", txtCN.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtPI.Text));
                
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
                string qry = "delete from Product where id=@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assing values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtPI.Text));
                
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
                string qry = "select * from Product where id =@id";

                //step 3 - assign the query to command class
                cmd = new SqlCommand(qry, con);

                // step-4  assing values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtPI.Text));

                // step 5 - open conn
                con.Open();

                // step 6 - fire the query
                dr = cmd.ExecuteReader(); 
                // fire the select query

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtPN.Text = dr["Name"].ToString();
                        txtPP.Text = dr["price"].ToString();
                        txtCN.Text = dr["companyName"].ToString();
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
                string qry = "select * from Product";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
