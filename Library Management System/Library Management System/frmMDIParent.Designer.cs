namespace Library_Management_System
{
    partial class frmMDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIParent));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnByStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsOfBookIssuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsOfBookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsOfBookIssuedAndReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsOfBookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInfoToolStripMenuItem,
            this.bookInfoToolStripMenuItem1,
            this.recordsOfBookIssuedToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookInfoToolStripMenuItem
            // 
            this.bookInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIssueToStudentToolStripMenuItem,
            this.bookReturnByStudentToolStripMenuItem});
            this.bookInfoToolStripMenuItem.Name = "bookInfoToolStripMenuItem";
            this.bookInfoToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.bookInfoToolStripMenuItem.Text = "Book Isue And Return";
            // 
            // bookIssueToStudentToolStripMenuItem
            // 
            this.bookIssueToStudentToolStripMenuItem.Name = "bookIssueToStudentToolStripMenuItem";
            this.bookIssueToStudentToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.bookIssueToStudentToolStripMenuItem.Text = "Book Issue To Student";
            this.bookIssueToStudentToolStripMenuItem.Click += new System.EventHandler(this.bookIssueToStudentToolStripMenuItem_Click);
            // 
            // bookReturnByStudentToolStripMenuItem
            // 
            this.bookReturnByStudentToolStripMenuItem.Name = "bookReturnByStudentToolStripMenuItem";
            this.bookReturnByStudentToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.bookReturnByStudentToolStripMenuItem.Text = "Book Return By Student";
            this.bookReturnByStudentToolStripMenuItem.Click += new System.EventHandler(this.bookReturnByStudentToolStripMenuItem_Click);
            // 
            // bookInfoToolStripMenuItem1
            // 
            this.bookInfoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem1,
            this.updateBookInfoToolStripMenuItem,
            this.deleteBookToolStripMenuItem1});
            this.bookInfoToolStripMenuItem1.Name = "bookInfoToolStripMenuItem1";
            this.bookInfoToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.bookInfoToolStripMenuItem1.Text = "Book Info";
            // 
            // addNewBookToolStripMenuItem1
            // 
            this.addNewBookToolStripMenuItem1.Name = "addNewBookToolStripMenuItem1";
            this.addNewBookToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.addNewBookToolStripMenuItem1.Text = "Add New Book";
            this.addNewBookToolStripMenuItem1.Click += new System.EventHandler(this.addNewBookToolStripMenuItem1_Click);
            // 
            // updateBookInfoToolStripMenuItem
            // 
            this.updateBookInfoToolStripMenuItem.Name = "updateBookInfoToolStripMenuItem";
            this.updateBookInfoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updateBookInfoToolStripMenuItem.Text = "Update Book Info";
            this.updateBookInfoToolStripMenuItem.Click += new System.EventHandler(this.updateBookInfoToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem1
            // 
            this.deleteBookToolStripMenuItem1.Name = "deleteBookToolStripMenuItem1";
            this.deleteBookToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.deleteBookToolStripMenuItem1.Text = "Delete Book";
            this.deleteBookToolStripMenuItem1.Click += new System.EventHandler(this.deleteBookToolStripMenuItem1_Click);
            // 
            // recordsOfBookIssuedToolStripMenuItem
            // 
            this.recordsOfBookIssuedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsOfBookIssueToolStripMenuItem,
            this.recordsOfBookIssuedAndReturnToolStripMenuItem,
            this.recordsOfBookInformationToolStripMenuItem});
            this.recordsOfBookIssuedToolStripMenuItem.Name = "recordsOfBookIssuedToolStripMenuItem";
            this.recordsOfBookIssuedToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsOfBookIssuedToolStripMenuItem.Text = "Records";
            // 
            // recordsOfBookIssueToolStripMenuItem
            // 
            this.recordsOfBookIssueToolStripMenuItem.Name = "recordsOfBookIssueToolStripMenuItem";
            this.recordsOfBookIssueToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.recordsOfBookIssueToolStripMenuItem.Text = "Records Of Book Issued";
            this.recordsOfBookIssueToolStripMenuItem.Click += new System.EventHandler(this.recordsOfBookIssueToolStripMenuItem_Click);
            // 
            // recordsOfBookIssuedAndReturnToolStripMenuItem
            // 
            this.recordsOfBookIssuedAndReturnToolStripMenuItem.Name = "recordsOfBookIssuedAndReturnToolStripMenuItem";
            this.recordsOfBookIssuedAndReturnToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.recordsOfBookIssuedAndReturnToolStripMenuItem.Text = "Records Of Book Issued And Return";
            this.recordsOfBookIssuedAndReturnToolStripMenuItem.Click += new System.EventHandler(this.recordsOfBookIssuedAndReturnToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // recordsOfBookInformationToolStripMenuItem
            // 
            this.recordsOfBookInformationToolStripMenuItem.Name = "recordsOfBookInformationToolStripMenuItem";
            this.recordsOfBookInformationToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.recordsOfBookInformationToolStripMenuItem.Text = "Records Of Book Information";
            this.recordsOfBookInformationToolStripMenuItem.Click += new System.EventHandler(this.recordsOfBookInformationToolStripMenuItem_Click);
            // 
            // frmMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(704, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDIParent_FormClosing);
            this.Load += new System.EventHandler(this.frmMDIParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssueToStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recordsOfBookIssuedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsOfBookIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateBookInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnByStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsOfBookIssuedAndReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsOfBookInformationToolStripMenuItem;

    }
}