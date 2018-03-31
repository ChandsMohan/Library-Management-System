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
    public partial class frmsearchbook : Form
    {
        DBConnect con = new DBConnect();
        bool checkData;
        string Status;
        int count;
        public frmsearchbook()
        {
            InitializeComponent();
        }

        private void frmsearchbook_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmsearchbook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.Visible = false;
            lblsearchresult.Visible = false;
        }

        private void txtbookname_Leave(object sender, EventArgs e)
        {
            if (txtbookname.Text.Trim().Length.Equals(0))
            {
                lblerrorbookname.Text = "Please Enter Book Name First";
                lblerrorbookname.ForeColor = Color.Red;
                txtbookname.Focus();
            }
            else
            {
                lblerrorbookname.Visible = false;
            }
        }

        private void txtauthor_Leave(object sender, EventArgs e)
        {
            if (txtauthor.Text.Trim().Length.Equals(0))
            {
                lblerrorauthor.Text = "Please Enter Author Name First";
                lblerrorauthor.ForeColor = Color.Red;
                txtauthor.Focus();
            }
            else
            {
                lblerrorauthor.Visible = false;
            }
        }

        private void txtedition_Leave(object sender, EventArgs e)
        {
            if (txtedition.Text.Trim().Length.Equals(0))
            {
                lblerroredition.Text = "Please Enter Edition First";
                lblerroredition.ForeColor = Color.Red;
                txtedition.Focus();
            }
            else
            {
                lblerroredition.Visible = false;
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

        private bool CheckDetails()
        {
            bool b = false;
            if (txtbookname.Text != "" && txtauthor.Text != "" && txtedition.Text != "")
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkData = CheckDetails();
            if (checkData)
            {
                try
                {
                    con.OpenConnection();
                    string Myquery = "select BookName,Author,Edition,Status,AvailableBooks,TotalBooks from tbl_BooksInfo where BookName='" + txtbookname.Text + "' and Author='" + txtauthor.Text + "' and Edition='" + txtedition.Text + " Edition" + "'";
                    SqlCommand cmd = new SqlCommand(Myquery, DBConnect.Connection);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dataGridView1.Visible = true;
                        panel1.Visible = true;
                        lblsearchresult.Visible = true;
                        dataGridView1.Columns.Add("1", "Book Name");
                        dataGridView1.Columns.Add("2", "Author");
                        dataGridView1.Columns.Add("3", "Edition");
                        dataGridView1.Columns.Add("4", "Status");
                        dataGridView1.Columns.Add("5", "Available Books");
                        dataGridView1.Columns.Add("6", "Total Books");
                        while (dr.Read())
                        {
                            int n = dataGridView1.Rows.Add();
                            for (int i = 0; i < 6; i++)
                            {
                                dataGridView1.Rows[n].Cells[i].Value = dr.GetValue(i).ToString();
                            }
                        }


                    }
                    else
                    {
                        lblerrorresult.Text = "Sorry No Record Found";
                        lblerrorresult.ForeColor = Color.Red;
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
    }
}
