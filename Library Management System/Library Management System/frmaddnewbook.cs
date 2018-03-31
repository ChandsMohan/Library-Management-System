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
    public partial class frmaddnewbook : Form
    {
        DBConnect con = new DBConnect();
        string Status;
        string newstatus;
        int count;
        int count1;
        string BookEdition;
        bool checkbook;
        bool bstatus;
        public frmaddnewbook()
        {
            InitializeComponent();
        }

        private void rbtntrue_Click(object sender, EventArgs e)
        {
            if (rbtntrue.Checked == true)
            {
                Status = rbtntrue.Text;
                txtnoofbooks.ReadOnly = false; ;
            }
            else if (rbtnfalse.Checked == true)
            {
                Status = rbtnfalse.Text;
                txtnoofbooks.Text = Convert.ToInt16(0).ToString();
                txtnoofbooks.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please Select Status");
            }
        }

        private void txtbookname_Leave(object sender, EventArgs e)
        {
            if (txtbookname.Text.Trim().Length.Equals(0))
            {
                lblerrorbookname.Visible = true;
                lblerrorbookname.Text = "Please Enter Book Name First";
                lblerrorbookname.ForeColor = Color.Red;
                txtbookname.Focus();
            }
            else if (txtbookname.Text != "")
            {
                lblerrorbookname.Visible = false;
            }
        }

        private void txtauthorofbook_Leave(object sender, EventArgs e)
        {
            if (txtauthorofbook.Text.Trim().Length.Equals(0))
            {
                lblerrorauthorname.Visible = true;
                lblerrorauthorname.Text = "Please Enter Author Name First";
                lblerrorauthorname.ForeColor = Color.Red;
                txtauthorofbook.Focus();
            }
            else if (txtauthorofbook.Text != "")
            {
                lblerrorauthorname.Visible = false;
            }
        }

        private void txtedition_Leave(object sender, EventArgs e)
        {
            if (txtedition.Text.Trim().Length.Equals(0))
            {
                lblerroredition.Visible = true;
                lblerroredition.Text = "Please Enter Edition First";
                lblerroredition.ForeColor = Color.Red;
                txtedition.Focus();
            }
            else if(txtedition.Text != "")
            {
                BookEdition = txtedition.Text + " Edition";
                lblerroredition.Visible = false;
            }
        }

        private void txtnoofbooks_Leave(object sender, EventArgs e)
        {
            if (txtnoofbooks.Text.Trim().Length.Equals(0))
            {
                lblerrornoofbooks.Visible = true;
                lblerrornoofbooks.Text = "Please Enter No Of Books";
                lblerrornoofbooks.ForeColor = Color.Red;
                txtnoofbooks.Focus();
            }
            else if (txtnoofbooks.Text != "")
            {
                lblerrornoofbooks.Visible = false;
            }
        }

        public bool SelectStatus()
        {
            bool b = false;
            if (rbtntrue.Checked == true && txtnoofbooks.Text != Convert.ToInt16(0).ToString())
            {
                Status = rbtntrue.Text;
                txtnoofbooks.ReadOnly = false;
                b = true;
            }
            else if (rbtnfalse.Checked == true && txtnoofbooks.Text == Convert.ToInt16(0).ToString())
            {
                Status = rbtnfalse.Text;
                txtnoofbooks.ReadOnly = true;
                b = true;
            }
            else
            {
                MessageBox.Show("Please Select Status \nOr Check No Of Books According Status");
                b = false;
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bstatus = SelectStatus();
            if (bstatus)
            {
                checkbook = CheckBookRecords();
                if (checkbook)
                {
                    string Query = "insert into tbl_BooksInfo (BookName,Author,Edition,Status,AvailableBooks,TotalBooks) values ('" + txtbookname.Text + "','" + txtauthorofbook.Text + "','" + BookEdition + "','" + Status + "','" + txtnoofbooks.Text + "','" + txtnoofbooks.Text + "')";
                    try
                    {
                        con.OpenConnection();
                        SqlCommand cmd = new SqlCommand(Query, DBConnect.Connection);
                        int res = cmd.ExecuteNonQuery();
                        if (res >= 1)
                        {
                            MessageBox.Show("Book Add Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error Occur During Adding Of Book");
                        }
                        RefreshPage();
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
            
        }

        public void RefreshPage()
        {
            txtauthorofbook.Clear();
            txtbookname.Clear();
            txtedition.Clear();
            txtnoofbooks.Clear();
        }


        public bool CheckBookRecords()
        {
            bool b = false;
            try
            {
                con.OpenConnection();
                string query = "select BookName,Author,Edition,Status,AvailableBooks,TotalBooks from tbl_BooksInfo where BookName='" + txtbookname.Text + "' and Author='" + txtauthorofbook.Text + "' and Edition='" + txtedition.Text + " Edition" + "'";
                SqlCommand cmd = new SqlCommand(query, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        newstatus = dr.GetValue(3).ToString();
                        count = Convert.ToInt16(dr.GetValue(4));
                        count1 = Convert.ToInt16(dr.GetValue(5));
                        b = false;
                    }
                    dr.Close();
                    count = count + Convert.ToInt16(txtnoofbooks.Text);
                    count1 = count1 + Convert.ToInt16(txtnoofbooks.Text);
                        if (newstatus == "False" && txtnoofbooks.Text != Convert.ToInt16(0).ToString())
                        {
                            string Mquery = "Update tbl_BooksInfo set Status='True', AvailableBooks=" + count + ",TotalBooks=" + count1 +" where BookName='" + txtbookname.Text + "' and Author='" + txtauthorofbook.Text + "' and Edition='" + txtedition.Text + " Edition" + "'";
                            SqlCommand Mcmd = new SqlCommand(Mquery, DBConnect.Connection);
                            int resu = Mcmd.ExecuteNonQuery();
                            if (resu >= 1)
                            {
                                MessageBox.Show("This book is already in our database \nStatus and No of Books has been updated");
                                RefreshPage();
                            }
                        }

                        else if (newstatus == "True")
                        {
                            string nquery = "update tbl_BooksInfo set AvailableBooks=" + count + ",TotalBooks=" + count1 + " where BookName='" + txtbookname.Text + "' and Author='" + txtauthorofbook.Text + "' and Edition='" + txtedition.Text + " Edition" + "'";
                            SqlCommand ncmd = new SqlCommand(nquery, DBConnect.Connection);
                            int result = ncmd.ExecuteNonQuery();
                            if (result >= 1)
                            {
                                MessageBox.Show("This book is already in our database \nNo of Books has been updated");
                                RefreshPage();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Book Available in Our Database");
                            RefreshPage();
                        }
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
        private void txtnoofbooks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && ((int)e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtedition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && ((int)e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
            else
            {
                e.Handled = false;

            }
        }

        private void frmaddnewbook_FormClosing(object sender, FormClosingEventArgs e)
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
