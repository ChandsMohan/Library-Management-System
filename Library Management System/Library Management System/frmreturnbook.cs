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
    public partial class frmreturnbook : Form
    {
        DBConnect dbcon = new DBConnect();
        bool checkdtls;
        bool updatedatabase;
        bool insertallrecords;
        int count;
        string bookstatus;
        public frmreturnbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mquery = "select distinct BookName from tbl_BookIssued where Student_Id='" + txtregid.Text + "'order by BookName";
            try
            {
                dbcon.OpenConnection();
                SqlCommand cmd = new SqlCommand(Mquery, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    groupBox2.Visible = true;
                    cbauthor.Visible = false;
                    cbedition.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button2.Visible = false;
                    txtregid.ReadOnly = true;
                    dr.Close();

                    SqlDataAdapter adap = new SqlDataAdapter(Mquery, DBConnect.Connection);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    DataRow row = dt.NewRow();
                    row["BookName"] = "Select Book";
                    dt.Rows.InsertAt(row, 0);
                    cbbookname.DataSource = dt;
                    cbbookname.DisplayMember = "BookName";
                    cbbookname.ValueMember = "BookName";
                }
                else
                {
                    lblerror.Text = "No Record Found";
                    lblerror.ForeColor = Color.Red;
                    txtregid.Focus();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbcon.CloseConnection();
            }
        }

        private void txtregid_Leave(object sender, EventArgs e)
        {
            if (txtregid.Text.Trim().Length.Equals(0))
            {
                lblerror.Visible = true;
                lblerror.Text = "Please Enter Student Id First";
                lblerror.ForeColor = Color.Red;
                txtregid.Focus();
            }
            else
            {
                lblerror.Visible = false;
            }
        }

        private void frmreturnbook_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
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
                    label3.Visible = true;
                    cbauthor.Visible = true;
                    string Query = "select distinct Author from tbl_BookIssued where Student_Id='" + txtregid.Text + "' and BookName='" + cbbookname.Text + "' order by Author";
                    SqlDataAdapter ada = new SqlDataAdapter(Query, DBConnect.Connection);
                    DataTable ndt = new DataTable();
                    ada.Fill(ndt);
                    DataRow row = ndt.NewRow();
                    row["Author"] = "Select Author";
                    ndt.Rows.InsertAt(row, 0);
                    cbauthor.DataSource = ndt;
                    cbauthor.DisplayMember = "Author";
                    cbauthor.ValueMember = "Author";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbcon.CloseConnection();
                }
            }

        }

        private void cbauthor_Leave(object sender, EventArgs e)
        {
            if (cbauthor.Text == "Select Author")
            {
                lblerrorauthorname.Visible = true;
                lblerrorauthorname.Text = "Please Select Author Name";
                lblerrorauthorname.ForeColor = Color.Red;
                cbauthor.Focus();
            }
            else if (cbauthor.Text != "Select Author")
            {
                lblerrorauthorname.Visible = false;
            }
        }

        private void cbedition_Leave(object sender, EventArgs e)
        {
            if (cbedition.Text == "Select Edition")
            {
                lblerroredition.Visible = true;
                lblerroredition.Text = "Please Select Edition";
                lblerroredition.ForeColor = Color.Red;
                cbedition.Focus();
            }
            else if (cbedition.Text != "Select Edition")
            {
                lblerroredition.Visible = false;
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
                label4.Visible = true;
                cbedition.Visible = true;
                button2.Visible = true;
                try
                {
                    string Myquery = "select distinct Edition from tbl_BookIssued where Student_Id='" + txtregid.Text + "' and  BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' order by Edition";
                    SqlDataAdapter adap = new SqlDataAdapter(Myquery, DBConnect.Connection);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    DataRow row = dt.NewRow();
                    row["Edition"] = "Select Edition";
                    dt.Rows.InsertAt(row, 0);
                    cbedition.DataSource = dt;
                    cbedition.DisplayMember = "Edition";
                    cbedition.ValueMember = "Edition";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbcon.CloseConnection();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkdtls = CheckDetails();
            if (checkdtls)
            {
                updatedatabase = UpdateDatabase();
                if (updatedatabase)
                {
                    insertallrecords = InsertAllRecords();
                    if (insertallrecords)
                    {
                        try
                        {
                            dbcon.OpenConnection();
                            string query = "delete tbl_BookIssued where Student_Id='" + txtregid.Text + "' and BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                            SqlCommand cmd1 = new SqlCommand(query, DBConnect.Connection);
                            int i = cmd1.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                MessageBox.Show("Details Has Been Saved Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Error occur during Updating the records");
                            }
                            txtregid.Clear();
                            cbauthor.Text = "Select Author";
                            cbedition.Text = "Select Edition";
                            cbbookname.Text = "Select Book";
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            dbcon.CloseConnection();
                        }
                    }
                }
            }
        }

        private bool InsertAllRecords()
        {
            bool b = false;
            try
            {
                dbcon.OpenConnection();
                string query = "insert into tbl_BookIssue_Return(Student_Id,BookName,Author,Edition,Status) values ('" + txtregid.Text + "','" + cbbookname.Text + "','" + cbauthor.Text + "','" + cbedition.Text + "','" + "Returned" + "')";
                SqlCommand cmd = new SqlCommand(query, DBConnect.Connection);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    b = true;
                }
                else
                {
                    b = false;
                    MessageBox.Show("An Error Occur");
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
                dbcon.CloseConnection();
            }
        }

        private bool UpdateDatabase()
        {
            bool b = false;
            try
            {
                string Myquery = "select Status, AvailableBooks from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                dbcon.OpenConnection();
                SqlCommand cmd = new SqlCommand(Myquery, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bookstatus = dr.GetValue(0).ToString();
                    count = Convert.ToInt16(dr.GetValue(1));
                }
                dr.Close();
                count = count + 1;
                if (bookstatus == "False")
                {
                    string nquery = "update tbl_BooksInfo set Status='True', AvailableBooks=" + count + " where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                    SqlCommand ncmd = new SqlCommand(nquery, DBConnect.Connection);
                    int res = ncmd.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        b = true;
                    }
                }
                else if (bookstatus == "True")
                {
                    string mquery = "update tbl_BooksInfo set AvailableBooks=" + count + " where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                    SqlCommand mcmd = new SqlCommand(mquery, DBConnect.Connection);
                    int result = mcmd.ExecuteNonQuery();
                    if (result >= 1)
                    {
                        b = true;
                    }
                }
                else
                {
                    b = false;
                    MessageBox.Show("An Error Occur");
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
                dbcon.CloseConnection();
            }
        }

        private bool CheckDetails()
        {
            bool b = false;
            if (cbbookname.Text != "Select Book" && cbauthor.Text != "Select Author" && cbedition.Text != "Select Edition")
            {
                b = true;
            }
            else
            {
                MessageBox.Show("Something Is Going Wrong \nPlease Check All Values");
            }
            return b;
        }

        private void frmreturnbook_FormClosing(object sender, FormClosingEventArgs e)
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
