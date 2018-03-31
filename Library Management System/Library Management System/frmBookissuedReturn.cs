using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmBookissuedReturn : Form
    {
        DBConnect con = new DBConnect();
        DirectoryInfo Book_Issued_And_Return;
        Timer timer1 = new Timer();
        public frmBookissuedReturn()
        {
            InitializeComponent();
        }

        private void frmBookissuedReturn_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            dataGridView1.Columns.Add("1", "Student ID");
            dataGridView1.Columns.Add("2", "Book Name");
            dataGridView1.Columns.Add("3", "Author");
            dataGridView1.Columns.Add("4", "Edition");
            dataGridView1.Columns.Add("5", "Status");
            dataGridView1.Columns.Add("6", "Date And Time");
            BindGrid();
        }

        public void BindGrid()
        {
            try
            {
                con.OpenConnection();
                string str = "select * from tbl_BookIssue_Return order by Student_Id";
                SqlCommand cmd = new SqlCommand(str, DBConnect.Connection);
                SqlDataReader dr = cmd.ExecuteReader();
                int records=0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        for(int i=0; i<6; i++)
                        {
                            dataGridView1.Rows[n].Cells[i].Value = dr.GetValue(i).ToString();
                        }
                        records ++;
                    }
                    toolStripLabel1.Text = records + " Records Found";
                }
                else
                {
                    toolStripLabel1.Text = "No Record Found";
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel2.Text = DateTime.Now.ToString();
        }

        private void frmBookissuedReturn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }



            // storing Each row and column value to excel sheet
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString().Trim();
                }
            }


            // save the application
            DirectoryInfo Book_Issued_And_Return = new DirectoryInfo(Application.StartupPath + "//Book_Issued_And_Return//");
            if (Book_Issued_And_Return.Exists)
            {
            }
            else
            {
                Book_Issued_And_Return.Create();
            }
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            workbook.SaveAs(Application.StartupPath + "\\Book_Issued_And_Return\\" + System.DateTime.Now.ToString("dd-MMM-yy") + ".xls");
        }
    }
}
