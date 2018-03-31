namespace Library_Management_System
{
    partial class frmsearchbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsearchbook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblerrorresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblerroredition = new System.Windows.Forms.Label();
            this.lblerrorauthor = new System.Windows.Forms.Label();
            this.lblerrorbookname = new System.Windows.Forms.Label();
            this.txtedition = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsearchresult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblerrorresult);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblerroredition);
            this.groupBox1.Controls.Add(this.lblerrorauthor);
            this.groupBox1.Controls.Add(this.lblerrorbookname);
            this.groupBox1.Controls.Add(this.txtedition);
            this.groupBox1.Controls.Add(this.txtauthor);
            this.groupBox1.Controls.Add(this.txtbookname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // lblerrorresult
            // 
            this.lblerrorresult.AutoSize = true;
            this.lblerrorresult.Location = new System.Drawing.Point(122, 235);
            this.lblerrorresult.Name = "lblerrorresult";
            this.lblerrorresult.Size = new System.Drawing.Size(0, 13);
            this.lblerrorresult.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblerroredition
            // 
            this.lblerroredition.AutoSize = true;
            this.lblerroredition.Location = new System.Drawing.Point(131, 174);
            this.lblerroredition.Name = "lblerroredition";
            this.lblerroredition.Size = new System.Drawing.Size(0, 13);
            this.lblerroredition.TabIndex = 8;
            // 
            // lblerrorauthor
            // 
            this.lblerrorauthor.AutoSize = true;
            this.lblerrorauthor.Location = new System.Drawing.Point(131, 120);
            this.lblerrorauthor.Name = "lblerrorauthor";
            this.lblerrorauthor.Size = new System.Drawing.Size(0, 13);
            this.lblerrorauthor.TabIndex = 7;
            // 
            // lblerrorbookname
            // 
            this.lblerrorbookname.AutoSize = true;
            this.lblerrorbookname.Location = new System.Drawing.Point(131, 64);
            this.lblerrorbookname.Name = "lblerrorbookname";
            this.lblerrorbookname.Size = new System.Drawing.Size(0, 13);
            this.lblerrorbookname.TabIndex = 6;
            // 
            // txtedition
            // 
            this.txtedition.Location = new System.Drawing.Point(125, 147);
            this.txtedition.Name = "txtedition";
            this.txtedition.Size = new System.Drawing.Size(179, 22);
            this.txtedition.TabIndex = 5;
            this.txtedition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedition_KeyPress);
            this.txtedition.Leave += new System.EventHandler(this.txtedition_Leave);
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(125, 94);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(179, 22);
            this.txtauthor.TabIndex = 4;
            this.txtauthor.Leave += new System.EventHandler(this.txtauthor_Leave);
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(125, 37);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(179, 22);
            this.txtbookname.TabIndex = 3;
            this.txtbookname.Leave += new System.EventHandler(this.txtbookname_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(446, 66);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblsearchresult);
            this.panel1.Location = new System.Drawing.Point(0, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 31);
            this.panel1.TabIndex = 2;
            // 
            // lblsearchresult
            // 
            this.lblsearchresult.AutoSize = true;
            this.lblsearchresult.BackColor = System.Drawing.Color.White;
            this.lblsearchresult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchresult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblsearchresult.Location = new System.Drawing.Point(3, 0);
            this.lblsearchresult.MinimumSize = new System.Drawing.Size(440, 30);
            this.lblsearchresult.Name = "lblsearchresult";
            this.lblsearchresult.Size = new System.Drawing.Size(440, 30);
            this.lblsearchresult.TabIndex = 0;
            this.lblsearchresult.Text = "Your Search Result";
            this.lblsearchresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmsearchbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsearchbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsearchbook_FormClosing);
            this.Load += new System.EventHandler(this.frmsearchbook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblerrorauthor;
        private System.Windows.Forms.Label lblerrorbookname;
        private System.Windows.Forms.TextBox txtedition;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerroredition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsearchresult;
        private System.Windows.Forms.Label lblerrorresult;
    }
}