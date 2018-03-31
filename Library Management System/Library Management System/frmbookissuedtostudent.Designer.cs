namespace Library_Management_System
{
    partial class frmbookissuedtostudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbookissuedtostudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtregid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblerroredition = new System.Windows.Forms.Label();
            this.lblerrorauthorname = new System.Windows.Forms.Label();
            this.lblerrorbookname = new System.Windows.Forms.Label();
            this.cbedition = new System.Windows.Forms.ComboBox();
            this.cbauthor = new System.Windows.Forms.ComboBox();
            this.cbbookname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblerror);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtregid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verify Students";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(118, 60);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtregid
            // 
            this.txtregid.Location = new System.Drawing.Point(121, 31);
            this.txtregid.Name = "txtregid";
            this.txtregid.Size = new System.Drawing.Size(128, 22);
            this.txtregid.TabIndex = 1;
            this.txtregid.Leave += new System.EventHandler(this.txtregid_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student  Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblerroredition);
            this.groupBox2.Controls.Add(this.lblerrorauthorname);
            this.groupBox2.Controls.Add(this.lblerrorbookname);
            this.groupBox2.Controls.Add(this.cbedition);
            this.groupBox2.Controls.Add(this.cbauthor);
            this.groupBox2.Controls.Add(this.cbbookname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details Of Book";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblerroredition
            // 
            this.lblerroredition.AutoSize = true;
            this.lblerroredition.Location = new System.Drawing.Point(125, 147);
            this.lblerroredition.Name = "lblerroredition";
            this.lblerroredition.Size = new System.Drawing.Size(0, 13);
            this.lblerroredition.TabIndex = 8;
            // 
            // lblerrorauthorname
            // 
            this.lblerrorauthorname.AutoSize = true;
            this.lblerrorauthorname.Location = new System.Drawing.Point(129, 102);
            this.lblerrorauthorname.Name = "lblerrorauthorname";
            this.lblerrorauthorname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorauthorname.TabIndex = 7;
            // 
            // lblerrorbookname
            // 
            this.lblerrorbookname.AutoSize = true;
            this.lblerrorbookname.Location = new System.Drawing.Point(118, 59);
            this.lblerrorbookname.Name = "lblerrorbookname";
            this.lblerrorbookname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorbookname.TabIndex = 6;
            // 
            // cbedition
            // 
            this.cbedition.FormattingEnabled = true;
            this.cbedition.Location = new System.Drawing.Point(121, 123);
            this.cbedition.Name = "cbedition";
            this.cbedition.Size = new System.Drawing.Size(180, 21);
            this.cbedition.TabIndex = 5;
            this.cbedition.Leave += new System.EventHandler(this.cbedition_Leave);
            // 
            // cbauthor
            // 
            this.cbauthor.FormattingEnabled = true;
            this.cbauthor.Location = new System.Drawing.Point(121, 77);
            this.cbauthor.Name = "cbauthor";
            this.cbauthor.Size = new System.Drawing.Size(180, 21);
            this.cbauthor.TabIndex = 4;
            this.cbauthor.SelectedIndexChanged += new System.EventHandler(this.cbauthor_SelectedIndexChanged);
            this.cbauthor.TextChanged += new System.EventHandler(this.cbauthor_TextChanged);
            this.cbauthor.Leave += new System.EventHandler(this.cbauthor_Leave);
            // 
            // cbbookname
            // 
            this.cbbookname.FormattingEnabled = true;
            this.cbbookname.Location = new System.Drawing.Point(121, 29);
            this.cbbookname.Name = "cbbookname";
            this.cbbookname.Size = new System.Drawing.Size(180, 21);
            this.cbbookname.TabIndex = 3;
            this.cbbookname.SelectedIndexChanged += new System.EventHandler(this.cbbookname_SelectedIndexChanged);
            this.cbbookname.TextChanged += new System.EventHandler(this.cbbookname_TextChanged);
            this.cbbookname.Leave += new System.EventHandler(this.cbbookname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Edition Of Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author Of Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // frmbookissuedtostudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmbookissuedtostudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Issued To Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmbookissuedtostudent_FormClosing);
            this.Load += new System.EventHandler(this.frmbookissuedtostudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtregid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblerroredition;
        private System.Windows.Forms.Label lblerrorauthorname;
        private System.Windows.Forms.Label lblerrorbookname;
        private System.Windows.Forms.ComboBox cbedition;
        private System.Windows.Forms.ComboBox cbauthor;
        private System.Windows.Forms.ComboBox cbbookname;
        private System.Windows.Forms.Button button2;
    }
}