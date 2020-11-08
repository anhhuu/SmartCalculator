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
    public partial class frmNhap : Form
    {
        public frmNhap()
        {
            InitializeComponent();
        }
        public TextBox _tbNhap
        {
            set
            {
                tbNhap = value;
            }
            get
            {
                return tbNhap;
            }
        }
        public String s = "";
        
        private void Nhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

		private void btnNhap_Click(object sender, EventArgs e)
		{
			s = tbNhap.Text;
			this.Close();
		}
	}
}
