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
    public partial class frmbookissuedtostudent : Form
    {
        DBConnect con = new DBConnect();
        bool checkval;
        bool insert;
        bool checkforinsert;
        bool insertforalldata;
        int count;
        public frmbookissuedtostudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select Registration_Id from tbl_registration where Registration_Id='" + txtregid.Text + "'";
            try
            {
                con.DBOpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBConnect.DBConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //while (dr.Read())
                    //{
                        groupBox2.Visible = true;
                        txtregid.ReadOnly = true;
                        string NQuery = "select * from tbl_BooksInfo where Status='True'";
                        try
                        {
                            dr.Close();
                            con.OpenConnection();
                            SqlCommand ncmd = new SqlCommand(NQuery, DBConnect.Connection);
                            SqlDataReader Ndr = cmd.ExecuteReader();
                            if (Ndr.HasRows)
                            {
                                //cbbookname.Items.Add("Select Book");
                                ////cbauthor.Items.Add("Select Author");
                                //cbedition.Items.Add("Select Edition");
                                //cbedition.SelectedText = "Select Edition";
                                //cbbookname.SelectedText = "Select Book";
                                ////cbauthor.SelectedText = "Select Author";
                                Ndr.Close();
                                //try
                                //{
                                    string myquery = "select distinct BookName from tbl_BooksInfo where Status='True' order by BookName";
                                    //con.OpenConnection();
                                    SqlDataAdapter adap = new SqlDataAdapter(myquery, DBConnect.Connection);
                                    DataTable newdt = new DataTable();
                                    adap.Fill(newdt);
                                    DataRow row = newdt.NewRow();
                                    row["BookName"] = "Select Book";
                                    newdt.Rows.InsertAt(row, 0);
                                    cbbookname.DataSource = newdt;
                                    cbbookname.DisplayMember = "BookName";
                                    cbbookname.ValueMember = "BookName";
                                //}
                                //catch (SqlException ex)
                                //{
                                //    MessageBox.Show(ex.Message);
                                //}
                                //finally
                                //{
                                //    con.CloseConnection();
                                //}

                            }
                            else
                            {
                                MessageBox.Show("No Book Available \nPlease Add Book First");
                                frmaddnewbook obj = new frmaddnewbook();
                                obj.Show();
                                this.Dispose();
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
                    //}
                }
                else
                {
                    lblerror.Text = "Record Not Found \nPlease Register student First";
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
                con.DBCloseConnection();
            }
        }

        private bool CheckForInsert()
        {
            bool b = false;
            try
            {
                string Query = "select * from tbl_BookIssued where Student_Id='" + txtregid.Text + "' and  BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand(Query, DBConnect.Connection);
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    b = false;
                    MessageBox.Show("This Book Already Has Been Provided To The Student");
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

        private bool InsertAllRecords()
        {
            bool b = false;
            try
            {
                con.OpenConnection();
                string query = "insert into tbl_BookIssue_Return(Student_Id,BookName,Author,Edition,Status) values ('" + txtregid.Text + "','" + cbbookname.Text + "','" + cbauthor.Text + "','" + cbedition.Text + "','" + "Issued" + "')";
                SqlCommand cmd = new SqlCommand(query, DBConnect.Connection);
                int resul = cmd.ExecuteNonQuery();
                if (resul >= 1)
                {
                    b = true;
                }
                else
                {
                    b = false;
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

        private void frmbookissuedtostudent_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void cbbookname_TextChanged(object sender, EventArgs e)
        {
            //if (cbbookname.Text == "Select Book")
            //{
            //    cbauthor.SelectedText = "Select Author";
            //}
            //else
            //{
            //    string Query = "select Author,Status from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Status='True'";
            //    try
            //    {
            //        con.OpenConnection();
            //        SqlDataAdapter adr = new SqlDataAdapter(Query, DBConnect.Connection);
            //        DataTable dt = new DataTable();
            //        adr.Fill(dt);
            //        DataRow row = dt.NewRow();
            //        row["Author"] = "Select Author";
            //        dt.Rows.InsertAt(row, 0);
            //        cbauthor.DataSource = dt;
            //        cbauthor.DisplayMember = "Author";
            //        cbauthor.ValueMember = "Author"; 
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        con.CloseConnection();
            //    }
            //}
        }

        private void cbauthor_TextChanged(object sender, EventArgs e)
        {
            //if (cbauthor.SelectedText == "Select Author")
            //{
            //    cbedition.SelectedText = "Select Edition";
            //}
            //else
            //{
            //    try
            //    {
            //        con.OpenConnection();
            //        string Nquery = "select Edition,Status from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Status='True'";
            //        SqlDataAdapter nadr = new SqlDataAdapter(Nquery, DBConnect.Connection);
            //        DataTable ndt = new DataTable();
            //        nadr.Fill(ndt);
            //        DataRow row = ndt.NewRow();
            //        row["Edition"] = "Select Edition";
            //        ndt.Rows.InsertAt(row, 0);
            //        cbedition.DataSource = ndt;
            //        cbedition.DisplayMember = "Edition";
            //        cbedition.ValueMember = "Edition";
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        con.CloseConnection();
            //    }
            //}
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
                    string Query = "select distinct Author from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Status='True' order by Author";
                    con.OpenConnection();
                    SqlDataAdapter adr = new SqlDataAdapter(Query, DBConnect.Connection);
                    DataTable dt = new DataTable();
                    adr.Fill(dt);
                    DataRow row = dt.NewRow();
                    row["Author"] = "Select Author";
                    dt.Rows.InsertAt(row, 0);
                    cbauthor.DataSource = dt;
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
                    string Nquery = "select distinct Edition from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Status='True' order by Edition";
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

        private void button2_Click(object sender, EventArgs e)
        {
            checkval = CheckValues();
            if (checkval)
            {
                checkforinsert = CheckForInsert();
                if (checkforinsert)
                {
                    insert = Insertintotbl_BookIssued();
                    if (insert)
                    {
                        insertforalldata = InsertAllRecords();
                        if (insertforalldata)
                        {
                            try
                            {
                                string dbquery = "select AvailableBooks from tbl_BooksInfo where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                                con.OpenConnection();
                                SqlCommand cmd = new SqlCommand(dbquery, DBConnect.Connection);
                                SqlDataReader sdr = null;
                                sdr = cmd.ExecuteReader();
                                if (sdr.Read())
                                {

                                    count = Convert.ToInt16(sdr.GetValue(0));

                                }
                                count = count - 1;
                                sdr.Close();
                                if (count < 1)
                                {
                                    string nquery = "update tbl_BooksInfo set AvailableBooks=" + count + " , Status='False' where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                                    SqlCommand ncmd = new SqlCommand(nquery, DBConnect.Connection);
                                    int res = ncmd.ExecuteNonQuery();
                                    if (res >= 1)
                                    {
                                        MessageBox.Show("Details Have Been Saved Successfully \nNow There Is No Book Of This Subject ");
                                    }
                                }
                                else
                                {
                                    string mnquery = "update tbl_BooksInfo set AvailableBooks=" + count + " where BookName='" + cbbookname.Text + "' and Author='" + cbauthor.Text + "' and Edition='" + cbedition.Text + "'";
                                    SqlCommand mcmd = new SqlCommand(mnquery, DBConnect.Connection);
                                    int result = mcmd.ExecuteNonQuery();
                                    if (result >= 1)
                                    {
                                        MessageBox.Show("Details Have Been Saved Successfully");
                                    }
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
                                con.CloseConnection();
                            }
                        }
                    }
                }
            }
        }

        private bool CheckValues()
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

        private bool Insertintotbl_BookIssued()
        {
            bool b= false;
            try
            {
                con.OpenConnection();
                string Query = "insert into tbl_BookIssued(Student_Id,BookName,Author,Edition) values ('" + txtregid.Text + "','" + cbbookname.Text + "','" + cbauthor.Text + "','" + cbedition.Text + "')";
                SqlCommand cmd = new SqlCommand(Query,DBConnect.Connection);
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
            
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                b= false;
                return b;
            }
            finally
            {
                con.CloseConnection();
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

        private void txtregid_Leave(object sender, EventArgs e)
        {
            if (txtregid.Text.Trim().Length.Equals(0))
            {
                lblerror.Text = "Please Enter Student Id First";
                lblerror.ForeColor = Color.Red;
                txtregid.Focus();
            }
        }

        private void frmbookissuedtostudent_FormClosing(object sender, FormClosingEventArgs e)
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
