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
    public partial class frmadminlogin : Form
    {
        DBConnect con = new DBConnect();
        public static string AdminId;
        public frmadminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select * from tbl_AdminLogin where AdminId='" + txtadminid.Text + "' and Password='" + txtpwd.Text + "'";
            try
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand(str, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        frmMDIParent obj = new frmMDIParent();
                        obj.Show();
                        this.Hide();
                        AdminId = txtadminid.Text;
                        obj.label1.Text = "Your Previous Login Time Is " + dr.GetValue(2).ToString();
                    }
                }
                else
                {
                    label5.Text = "Invalid Admin Id or Password \n Please Enter Correct Admin Id And Password";
                    label5.ForeColor = Color.Red;
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

        private void txtadminid_Leave(object sender, EventArgs e)
        {
            if (txtadminid.Text.Trim().Length.Equals(0))
            {
                label3.Visible = true;
                label3.Text = "Please Enter Admin Id First";
                label3.ForeColor = Color.Red;
                txtadminid.Focus();
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text.Trim().Length.Equals(0))
            {
                label4.Visible = true;
                label4.Text = "Please Enter Password First";
                label4.ForeColor = Color.Red;
                txtpwd.Focus();
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void frmadminlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        public bool LastLoginDetails(string AdminId, string LastLoginTime)
        {
            DateTime datetime = DateTime.Now;
            string date = datetime.ToString();
            bool b = false;
            try
            {
                con.OpenConnection();
                string Query = "update tbl_AdminLogin set LastLogin='" + date + "' where AdminId='" + AdminId + "'";
                SqlCommand cmd = new SqlCommand(Query, DBConnect.Connection);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    b = true;
                    return b;
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
            return b;
        }
    }
}
