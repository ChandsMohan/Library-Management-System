namespace Library_Management_System
{
    partial class frmaddnewbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddnewbook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblerrornoofbooks = new System.Windows.Forms.Label();
            this.lblerroredition = new System.Windows.Forms.Label();
            this.lblerrorauthorname = new System.Windows.Forms.Label();
            this.lblerrorbookname = new System.Windows.Forms.Label();
            this.txtnoofbooks = new System.Windows.Forms.TextBox();
            this.rbtnfalse = new System.Windows.Forms.RadioButton();
            this.rbtntrue = new System.Windows.Forms.RadioButton();
            this.txtedition = new System.Windows.Forms.TextBox();
            this.txtauthorofbook = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblerrornoofbooks);
            this.groupBox1.Controls.Add(this.lblerroredition);
            this.groupBox1.Controls.Add(this.lblerrorauthorname);
            this.groupBox1.Controls.Add(this.lblerrorbookname);
            this.groupBox1.Controls.Add(this.txtnoofbooks);
            this.groupBox1.Controls.Add(this.rbtnfalse);
            this.groupBox1.Controls.Add(this.rbtntrue);
            this.groupBox1.Controls.Add(this.txtedition);
            this.groupBox1.Controls.Add(this.txtauthorofbook);
            this.groupBox1.Controls.Add(this.txtbookname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblerrornoofbooks
            // 
            this.lblerrornoofbooks.AutoSize = true;
            this.lblerrornoofbooks.Location = new System.Drawing.Point(148, 279);
            this.lblerrornoofbooks.Name = "lblerrornoofbooks";
            this.lblerrornoofbooks.Size = new System.Drawing.Size(0, 13);
            this.lblerrornoofbooks.TabIndex = 15;
            // 
            // lblerroredition
            // 
            this.lblerroredition.AutoSize = true;
            this.lblerroredition.Location = new System.Drawing.Point(148, 142);
            this.lblerroredition.Name = "lblerroredition";
            this.lblerroredition.Size = new System.Drawing.Size(0, 13);
            this.lblerroredition.TabIndex = 13;
            // 
            // lblerrorauthorname
            // 
            this.lblerrorauthorname.AutoSize = true;
            this.lblerrorauthorname.Location = new System.Drawing.Point(148, 101);
            this.lblerrorauthorname.Name = "lblerrorauthorname";
            this.lblerrorauthorname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorauthorname.TabIndex = 12;
            // 
            // lblerrorbookname
            // 
            this.lblerrorbookname.AutoSize = true;
            this.lblerrorbookname.Location = new System.Drawing.Point(148, 57);
            this.lblerrorbookname.Name = "lblerrorbookname";
            this.lblerrorbookname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorbookname.TabIndex = 11;
            // 
            // txtnoofbooks
            // 
            this.txtnoofbooks.Location = new System.Drawing.Point(144, 245);
            this.txtnoofbooks.Name = "txtnoofbooks";
            this.txtnoofbooks.Size = new System.Drawing.Size(125, 22);
            this.txtnoofbooks.TabIndex = 10;
            this.txtnoofbooks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoofbooks_KeyPress);
            this.txtnoofbooks.Leave += new System.EventHandler(this.txtnoofbooks_Leave);
            // 
            // rbtnfalse
            // 
            this.rbtnfalse.AutoSize = true;
            this.rbtnfalse.Location = new System.Drawing.Point(144, 196);
            this.rbtnfalse.Name = "rbtnfalse";
            this.rbtnfalse.Size = new System.Drawing.Size(51, 17);
            this.rbtnfalse.TabIndex = 9;
            this.rbtnfalse.TabStop = true;
            this.rbtnfalse.Text = "False";
            this.rbtnfalse.UseVisualStyleBackColor = true;
            this.rbtnfalse.Click += new System.EventHandler(this.rbtntrue_Click);
            // 
            // rbtntrue
            // 
            this.rbtntrue.AutoSize = true;
            this.rbtntrue.Location = new System.Drawing.Point(144, 173);
            this.rbtntrue.Name = "rbtntrue";
            this.rbtntrue.Size = new System.Drawing.Size(47, 17);
            this.rbtntrue.TabIndex = 8;
            this.rbtntrue.TabStop = true;
            this.rbtntrue.Text = "True";
            this.rbtntrue.UseVisualStyleBackColor = true;
            this.rbtntrue.Click += new System.EventHandler(this.rbtntrue_Click);
            // 
            // txtedition
            // 
            this.txtedition.Location = new System.Drawing.Point(144, 117);
            this.txtedition.Name = "txtedition";
            this.txtedition.Size = new System.Drawing.Size(125, 22);
            this.txtedition.TabIndex = 7;
            this.txtedition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedition_KeyPress);
            this.txtedition.Leave += new System.EventHandler(this.txtedition_Leave);
            // 
            // txtauthorofbook
            // 
            this.txtauthorofbook.Location = new System.Drawing.Point(144, 73);
            this.txtauthorofbook.Name = "txtauthorofbook";
            this.txtauthorofbook.Size = new System.Drawing.Size(125, 22);
            this.txtauthorofbook.TabIndex = 6;
            this.txtauthorofbook.Leave += new System.EventHandler(this.txtauthorofbook_Leave);
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(144, 27);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(125, 22);
            this.txtbookname.TabIndex = 5;
            this.txtbookname.Leave += new System.EventHandler(this.txtbookname_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Of Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edition Of Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Of Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // frmaddnewbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 353);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmaddnewbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmaddnewbook_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnfalse;
        private System.Windows.Forms.RadioButton rbtntrue;
        private System.Windows.Forms.TextBox txtedition;
        private System.Windows.Forms.TextBox txtauthorofbook;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnoofbooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblerrornoofbooks;
        private System.Windows.Forms.Label lblerroredition;
        private System.Windows.Forms.Label lblerrorauthorname;
        private System.Windows.Forms.Label lblerrorbookname;
    }
}