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
    public partial class frmupdatebook : Form
    {
        DBConnect con = new DBConnect();
        string status;
        bool statuscheck;
        string statusnew;
        bool Bookissuedcheck;
        bool checkdetails;
        string Edition;
        int availablebooks;
        int TotalBooks;
        public frmupdatebook()
        {
            InitializeComponent();
        }

        private void txtbookname_Leave(object sender, EventArgs e)
        {
            if (txtbookname.Text.Trim().Length.Equals(0))
            {
                lblerrorbookname.Visible = true;
                lblerrorbookname.Text = "Please Enter Book Name";
                lblerrorbookname.ForeColor = Color.Red;
                txtbookname.Focus();
            }
            else if (txtbookname.Text != "")
            {
                lblerrorbookname.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select distinct Author from tbl_BooksInfo where BookName='" + txtbookname.Text + "'order by Author";
            try
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    groupBox2.Visible = true;
                    txtauthor.Visible = false;
                    txtedition.Visible = false;
                    txtbookname.ReadOnly = true;
                    txtbooknameforupdate.Text = txtbookname.Text;
                    dr.Close();
                    SqlDataAdapter adap = new SqlDataAdapter(query, DBConnect.Connection);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    DataRow row = dt.NewRow();
                    row["Author"] = "Select Author";
                    dt.Rows.InsertAt(row, 0);
                    cbauthor.DataSource = dt;
                    cbauthor.DisplayMember = "Author";
                    cbauthor.ValueMember = "Author";
                }
                else
                {
                    lblerrorbookname.Text = "Record Not Found";
                    lblerrorbookname.ForeColor = Color.Red;
                    txtbookname.Focus();
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

        private void frmupdatebook_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmupdatebook_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void cbedition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbedition.SelectedText == "Select Edition")
            {

            }
            else
            {
                try
                {
                    con.OpenConnection();
                    string query = "select BookName,Author,Edition,Status,AvailableBooks,TotalBooks from tbl_BooksInfo where BookName='" + txtbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, DBConnect.Connection);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            status = dr.GetValue(3).ToString();
                            txtnoofbooks.Text= dr.GetValue(4).ToString();
                            availablebooks = Convert.ToInt16(dr.GetValue(4));
                            TotalBooks = Convert.ToInt16(dr.GetValue(5));
                        }

                        if (status == "True")
                        {
                            rbtntrue.Checked = true;
                            txtnoofbooks.ReadOnly = false;
                        }
                        else if (status == "False")
                        {
                            rbtnfalse.Checked = true;
                            txtnoofbooks.ReadOnly = true;
                        }
                        
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
                    string Nquery = "select distinct Edition from tbl_BooksInfo where BookName='" + txtbookname.Text + "' and Author='" + cbauthor.Text + "'order by Edition";
                    SqlDataAdapter nadr = new SqlDataAdapter(Nquery, DBConnect.Connection);
                    DataTable ndt = new DataTable();
                    nadr.Fill(ndt);
                    DataRow row = ndt.NewRow();
                    row["Edition"] = "Select Edition";
                    ndt.Rows.InsertAt(row, 0);
                    cbedition.DataSource = ndt;
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

        private void txtbooknameforupdate_Leave(object sender, EventArgs e)
        {
            if (txtbooknameforupdate.Text.Trim().Length.Equals(0))
            {
                lblerrorbookname.Visible = true;
                lblerrorbooknameforupdate.Text = "Please Enter Book Name For Update";
                lblerrorbooknameforupdate.ForeColor = Color.Red;
                txtbooknameforupdate.Focus();
            }
            else if(!txtbooknameforupdate.Text.Trim().Length.Equals(0))
            {
                lblerrorbooknameforupdate.Visible = false;
            }
        }

        private void txtauthor_Leave(object sender, EventArgs e)
        {
            if (txtauthor.Text.Trim().Length.Equals(0))
            {
                lblerrorauthor.Visible = true;
                lblerrorauthor.Text = "Please Enter Author Name For Update";
                lblerrorauthor.ForeColor = Color.Red;
                txtauthor.Focus();
            }
            else if (!txtauthor.Text.Trim().Length.Equals(0))
            {
                lblerrorauthor.Visible = true;
            }
        }

        private void txtedition_Leave(object sender, EventArgs e)
        {
            if (txtedition.Text.Trim().Length.Equals(0))
            {
                lblerroredition.Visible = true;
                lblerroredition.Text = "Please Enter Edition For Update";
                lblerroredition.ForeColor = Color.Red;
                txtedition.Focus();
            }
            else if (!txtedition.Text.Trim().Length.Equals(0))
            {
                lblerroredition.Visible = false;
            }
        }

        private void txtnoofbooks_Leave(object sender, EventArgs e)
        {
            if (txtnoofbooks.Text.Trim().Length.Equals(0))
            {
                lblerrornoofbooks.Visible = true;
                lblerrornoofbooks.Text = "Please Enter No Of Books First";
                lblerrornoofbooks.ForeColor = Color.Red;
                txtnoofbooks.Focus();
            }
            else if(!txtnoofbooks.Text.Trim().Length.Equals(0))
            {
                lblerrornoofbooks.Visible=false;
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
                txtauthor.Text = cbauthor.Text;
                cbauthor.Visible = false;
                txtauthor.Visible = true;
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
            else if (cbauthor.Text != "Select Author")
            {
                lblerroredition.Visible = false;
                Edition = cbedition.Text;
                string[] NewEdition = Edition.Split(' ');
                txtedition.Text = NewEdition[0];
                cbedition.Visible = false;
                txtedition.Visible = true;
            }
        }

        private bool CheckAllDetails()
        {
            bool b = false;
            if (txtbookname.Text != "" && txtauthor.Text != "" && txtedition.Text != "" && txtnoofbooks.Text != "")
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        public bool SelectStatus()
        {
            bool b = false;
            if (rbtntrue.Checked == true && txtnoofbooks.Text != Convert.ToInt16(0).ToString())
            {
                statusnew = rbtntrue.Text;
                b = true;
            }
            else if (rbtnfalse.Checked == true && txtnoofbooks.Text == Convert.ToInt16(0).ToString())
            {
                statusnew = rbtnfalse.Text;
                b = true;
            }
            else
            {
                MessageBox.Show("Please Select Status \nOr Check No Of Books According Status");
                b = false;
            }
            return b;
        }

        private void rbtntrue_Click(object sender, EventArgs e)
        {
            if (rbtntrue.Checked == true)
            {
                statusnew = rbtntrue.Text;
                txtnoofbooks.ReadOnly = false;
            }
            else if (rbtnfalse.Checked == true)
            {
                statusnew = rbtnfalse.Text;
                txtnoofbooks.Text = Convert.ToInt16(0).ToString();
                txtnoofbooks.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please Select Status");
            }
        }

        private bool CheckBookIssued()
        {
            bool b = false;
            try
            {
                con.OpenConnection();
                string Query = "Select * from tbl_BookIssued where BookName='" + txtbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                SqlCommand ncmd = new SqlCommand(Query, DBConnect.Connection);
                SqlDataReader dr = ncmd.ExecuteReader();
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

        public void RefreshPage()
        {
            txtedition.Clear();
            txtauthor.Clear();
            txtbookname.Clear();
            txtnoofbooks.Clear();
            txtbooknameforupdate.Clear();
            txtbookname.ReadOnly = false;
            cbauthor.Visible = true;
            cbedition.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statuscheck = SelectStatus();
            if (statuscheck)
            {
                checkdetails = CheckAllDetails();
                if (checkdetails)
                {
                    Bookissuedcheck = CheckBookIssued();
                    if (Bookissuedcheck)
                    {
                        try
                        {
                            con.OpenConnection();
                            string Myquery = "update tbl_BooksInfo set BookName='" + txtbooknameforupdate.Text + "', Author='" + txtauthor.Text + "', Edition='" + txtedition.Text + " Th Edition" + "' , Status='" + statusnew + "' , AvailableBooks='" + txtnoofbooks.Text + "', TotalBooks='" + txtnoofbooks.Text + "' where BookName='" + txtbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                            SqlCommand cmd = new SqlCommand(Myquery, DBConnect.Connection);
                            int res = cmd.ExecuteNonQuery();
                            if (res >= 1)
                            {
                                MessageBox.Show("Record Updated Successfully");
                                RefreshPage();
                            }
                            else
                            {
                                MessageBox.Show("An Error Occur During Update");
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
                        MessageBox.Show("We Can Not Update This Book\nBecause This Book Is Provided to The Student");
                        RefreshPage();
                    }
                }
                else
                {

                }
            }
        }

        private void txtedition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers Only");
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
