using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelligent_Calculator_Core
{
    public partial class Logax : Form
    {
        public Logax()
        {
            InitializeComponent();
        }
        public event EventHandler btTruyenlogax_clicked;
        public TextBox _Cosoa
        {
            set
            {
                tbCosoa = value;
            }
            get
            {
                return tbCosoa;
            }
        }
        private void Logax_FormClosing(object sender, FormClosingEventArgs e)
        {
            total.showLogaxf = false;
            tbCosoa.Text = "";
            this.Hide();
            e.Cancel = true;
        }

        private void btNhapLog_Click(object sender, EventArgs e)
        {
            if (tbCosoa.Text != "")
            {
                if (this.btTruyenlogax_clicked != null)
                    this.btTruyenlogax_clicked(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập cơ số!");
            }
        }
    }
}
