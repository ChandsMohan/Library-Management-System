using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmdeleteBook : Form
    {
        DBConnect con = new DBConnect();
        bool checkdata;
        bool checkbookissued;
        public frmdeleteBook()
        {
            InitializeComponent();
        }

        private void frmdeleteBook_Load(object sender, EventArgs e)
        {
            try
            {
                string MyQuery = "select BookName from tbl_BooksInfo order by BookName";
                con.OpenConnection();
                SqlDataAdapter adap = new SqlDataAdapter(MyQuery, DBConnect.Connection);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DataRow row = dt.NewRow();
                row["BookName"] = "Select Book";
                dt.Rows.InsertAt(row, 0);
                cbbookname.DataSource = dt;
                cbbookname.DisplayMember = "BookName";
                cbbookname.ValueMember = "BookName";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        private void cbbookname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbookname.SelectedText == "Select Book")
            {
                cbauthor.SelectedText = "Select Author";
            }
            else
            {
                try
                {
                    con.OpenConnection();
                    string Nquery = "select Author from tbl_BooksInfo where BookName='" + cbbookname.Text + "' order by Author";
                    SqlDataAdapter ada = new SqlDataAdapter(Nquery, DBConnect.Connection);
                    DataTable Ndt = new DataTable();
                    ada.Fill(Ndt);
                    DataRow row = Ndt.NewRow();
                    row["Author"] = "Select Author";
                    Ndt.Rows.InsertAt(row, 0);
                    cbauthor.DataSource = Ndt;
                    cbauthor.DisplayMember = "Author";
                    cbauthor.ValueMember = "Author";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        private void cbauthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbauthor.SelectedText == "Select Author")
            {
                cbedition.SelectedText = "Select Edition";
            }
            else
            {
                try
                {
                    con.OpenConnection();
                    string Query = "select Edition from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' order by Edition";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, DBConnect.Connection);
                    DataTable Newdt = new DataTable();
                    sda.Fill(Newdt);
                    DataRow row = Newdt.NewRow();
                    row["Edition"] = "Select Edition";
                    Newdt.Rows.InsertAt(row, 0);
                    cbedition.DataSource = Newdt;
                    cbedition.DisplayMember = "Edition";
                    cbedition.ValueMember = "Edition";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
        }

        private void cbbookname_Leave(object sender, EventArgs e)
        {
            if (cbbookname.Text == "Select Book")
            {
                lblerrorbookname.Visible = true;
                lblerrorbookname.Text = "Please Select Book Name First";
                lblerrorbookname.ForeColor = Color.Red;
                cbbookname.Focus();
            }
            else if (cbbookname.Text != "Select Book")
            {
                lblerrorbookname.Visible = false;
            }
        }

        private void cbauthor_Leave(object sender, EventArgs e)
        {
            if (cbauthor.Text == "Select Author")
            {
                lblerrorauthor.Visible = true;
                lblerrorauthor.Text = "Please Select Author First";
                lblerrorauthor.ForeColor = Color.Red;
                cbauthor.Focus();
            }
            else if (cbauthor.Text != "Select Author")
            {
                lblerrorauthor.Visible = false;
            }
        }

        private void cbedition_Leave(object sender, EventArgs e)
        {
            if (cbedition.Text == "Select Edition")
            {
                lblerroredition.Visible = true;
                lblerroredition.Text = "Please Select Edition First";
                lblerroredition.ForeColor = Color.Red;
                cbedition.Focus();
            }
            else if (cbedition.Text != "Select Edition")
            {
                lblerroredition.Visible = false;
            }
        }

        private bool CheckAll()
        {
            bool b = false;
            if (cbbookname.Text != "Select Book" && cbauthor.Text != "Select Author" && cbedition.Text != "Select Edition")
            {
                b = true;
            }
            else
            {
                b = false;
                MessageBox.Show("Please Check All Data First");
            }
            return b;
        }

        private bool CheckBookIssued()
        {
            bool b = false;
            try
            {
                con.OpenConnection();
                string Query = "select BookName,Author,Edition from tbl_BookIssued where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    b = false;
                }
                else
                {
                    b = true;
                }
                return b;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                b = false;
                return b;
            }
            finally
            {
                con.CloseConnection();
            }
        }

        public void RefreshAll()
        {
            cbauthor.Text = "Select Author";
            cbedition.Text = "Select Edition";
            cbbookname.Text = "Select Book";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkdata = CheckAll();
            if (checkdata)
            {
                checkbookissued = CheckBookIssued();
                if (checkbookissued)
                {
                    try
                    {
                        con.OpenConnection();
                        string Mquery = "delete tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                        SqlCommand mcmd = new SqlCommand(Mquery, DBConnect.Connection);
                        int result = mcmd.ExecuteNonQuery();
                        if (result >= 1)
                        {
                            MessageBox.Show("Book Deleted Successfully");
                            RefreshAll();
                        }
                        else
                        {
                            MessageBox.Show("An Error Occur During Deleting Book");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("We Can Not Delete This Book \nThis Book Is Provided To Student");
                    RefreshAll();
                }
            }
        }

        private void frmdeleteBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
