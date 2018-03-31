using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmMDIParent : Form
    {
        public frmMDIParent()
        {
            InitializeComponent();
        }

        private bool CheckForDuplicationForm(Form NewForm)
        {
            bool b = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == NewForm.GetType())
                {
                    frm.Activate();
                    b = true;
                }
            }
            return b;
        }

        private void frmMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmadminlogin obj = new frmadminlogin();
                obj.LastLoginDetails(frmadminlogin.AdminId, "LogOut");
                obj.Show();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            frmadminlogin obj = new frmadminlogin();
            obj.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To LogOut", "LogOut", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmadminlogin obj = new frmadminlogin();
                obj.LastLoginDetails(frmadminlogin.AdminId, "LogOut");
                obj.Show();
                this.Dispose();
            }
            else
            {
                
            }
        }

        private void bookIssueToStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbookissuedtostudent obj = new frmbookissuedtostudent();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void addNewBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmaddnewbook obj = new frmaddnewbook();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void bookReturnByStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreturnbook obj = new frmreturnbook();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }

        }

        private void updateBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmupdatebook obj = new frmupdatebook();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void deleteBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmdeleteBook obj = new frmdeleteBook();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsearchbook obj = new frmsearchbook();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void recordsOfBookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecordsBookIssued obj = new frmrecordsBookIssued();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void recordsOfBookIssuedAndReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookissuedReturn obj = new frmBookissuedReturn();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void recordsOfBookInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookInformation obj = new frmBookInformation();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        
    }
}
