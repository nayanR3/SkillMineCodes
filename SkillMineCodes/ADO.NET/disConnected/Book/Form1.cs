using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bookDisconnectPro
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
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("select * from book", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "book");// product is table name given to the DataSet
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["book"].NewRow();
                row["name"] = txtN.Text;
                row["price"] = txtP.Text;
                row["authorName"] = txtAN.Text;
                row["publication"]=txtPB.Text;
                row["edition"]=txtE.Text;

                ds.Tables["book"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["book"]);
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
                DataRow row = ds.Tables["book"].Rows.Find(txtI.Text);

                if (row != null)
                {
                    row["name"] = txtN.Text;
                    row["price"] = txtP.Text;
                    row["authorName"] = txtAN.Text;
                    row["publication"] = txtPB.Text;
                    row["edition"] = txtE.Text;

                    int result = adapter.Update(ds.Tables["book"]);
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
                DataRow row = ds.Tables["book"].Rows.Find(txtI.Text);

                if (row != null)
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["book"]);
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
                DataRow row = ds.Tables["book"].Rows.Find(txtI.Text);

                if (row != null)
                {
                    txtN.Text = row["name"].ToString();
                    txtP.Text = row["price"].ToString();
                    txtAN.Text = row["authorName"].ToString();
                    txtPB.Text = row["publication"].ToString();
                    txtE.Text = row["edition"].ToString();
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
                GridView1.DataSource = ds.Tables["book"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
