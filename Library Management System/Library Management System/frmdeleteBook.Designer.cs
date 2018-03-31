namespace Library_Management_System
{
    partial class frmdeleteBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeleteBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblerroredition = new System.Windows.Forms.Label();
            this.lblerrorauthor = new System.Windows.Forms.Label();
            this.lblerrorbookname = new System.Windows.Forms.Label();
            this.cbedition = new System.Windows.Forms.ComboBox();
            this.cbauthor = new System.Windows.Forms.ComboBox();
            this.cbbookname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblerroredition);
            this.groupBox1.Controls.Add(this.lblerrorauthor);
            this.groupBox1.Controls.Add(this.lblerrorbookname);
            this.groupBox1.Controls.Add(this.cbedition);
            this.groupBox1.Controls.Add(this.cbauthor);
            this.groupBox1.Controls.Add(this.cbbookname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblerroredition
            // 
            this.lblerroredition.AutoSize = true;
            this.lblerroredition.Location = new System.Drawing.Point(138, 172);
            this.lblerroredition.Name = "lblerroredition";
            this.lblerroredition.Size = new System.Drawing.Size(0, 13);
            this.lblerroredition.TabIndex = 8;
            // 
            // lblerrorauthor
            // 
            this.lblerrorauthor.AutoSize = true;
            this.lblerrorauthor.Location = new System.Drawing.Point(138, 122);
            this.lblerrorauthor.Name = "lblerrorauthor";
            this.lblerrorauthor.Size = new System.Drawing.Size(0, 13);
            this.lblerrorauthor.TabIndex = 7;
            // 
            // lblerrorbookname
            // 
            this.lblerrorbookname.AutoSize = true;
            this.lblerrorbookname.Location = new System.Drawing.Point(138, 70);
            this.lblerrorbookname.Name = "lblerrorbookname";
            this.lblerrorbookname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorbookname.TabIndex = 6;
            // 
            // cbedition
            // 
            this.cbedition.FormattingEnabled = true;
            this.cbedition.Location = new System.Drawing.Point(134, 145);
            this.cbedition.Name = "cbedition";
            this.cbedition.Size = new System.Drawing.Size(202, 21);
            this.cbedition.TabIndex = 5;
            this.cbedition.Leave += new System.EventHandler(this.cbedition_Leave);
            // 
            // cbauthor
            // 
            this.cbauthor.FormattingEnabled = true;
            this.cbauthor.Location = new System.Drawing.Point(134, 96);
            this.cbauthor.Name = "cbauthor";
            this.cbauthor.Size = new System.Drawing.Size(202, 21);
            this.cbauthor.TabIndex = 4;
            this.cbauthor.SelectedIndexChanged += new System.EventHandler(this.cbauthor_SelectedIndexChanged);
            this.cbauthor.Leave += new System.EventHandler(this.cbauthor_Leave);
            // 
            // cbbookname
            // 
            this.cbbookname.FormattingEnabled = true;
            this.cbbookname.Location = new System.Drawing.Point(134, 40);
            this.cbbookname.Name = "cbbookname";
            this.cbbookname.Size = new System.Drawing.Size(202, 21);
            this.cbbookname.TabIndex = 3;
            this.cbbookname.SelectedIndexChanged += new System.EventHandler(this.cbbookname_SelectedIndexChanged);
            this.cbbookname.Leave += new System.EventHandler(this.cbbookname_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // frmdeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 294);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdeleteBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdeleteBook_FormClosing);
            this.Load += new System.EventHandler(this.frmdeleteBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblerrorbookname;
        private System.Windows.Forms.ComboBox cbedition;
        private System.Windows.Forms.ComboBox cbauthor;
        private System.Windows.Forms.ComboBox cbbookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerrorauthor;
        private System.Windows.Forms.Label lblerroredition;
        private System.Windows.Forms.Button button1;

    }
}