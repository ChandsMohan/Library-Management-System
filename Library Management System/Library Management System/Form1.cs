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
    public partial class frmstart : Form
    {
        Timer timer1 = new Timer();
        int i = 0;
            
        public frmstart()
        {
            InitializeComponent();
        }

        private void frmstart_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
           
            i += 2;
            label2.Text = i.ToString() + " % Loaded";
            progressBar1.Value += 2;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                frmadminlogin obj = new frmadminlogin();
                obj.Show();
                this.Hide();
            }
        }
    }
}
