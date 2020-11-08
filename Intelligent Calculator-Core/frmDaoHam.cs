using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelligent_Calculator_Core
{
    public partial class frmDaoHam : Form
    {
        public frmDaoHam()
        {
            InitializeComponent();
        }
        public event EventHandler btTruyenkqdh_clicked;
        public event EventHandler btNhapdh_clicked_true;
        public event EventHandler btNhapdh_clicked_false;
        public TextBox _kqdh
        {
            set
            {
                tbKqdh = value;
            }
            get
            {
                return tbKqdh;
            }
        }
        public Boolean _visibleDhf
        {
            set
            {
                Visible = value;
            }
            get
            {
                return Visible;
            }
        }
        public void Xoahet()
        {
            tbFx.Text = "";
        }
        public void Xoa()
        {
            if (tbFx.Text != "")
                tbFx.Text = tbFx.Text.Remove(tbFx.Text.Length - 1, 1);
        }
        public Double tinhFx(string s)
        {
            frmMainIC frm1 = new frmMainIC();
            return frm1.tinhKQ(s);
        }
        public void tbFx_add(string s)
        {
            tbFx.Text += s;
        }
        public void btKqdh_Click(object sender, EventArgs e)
        {
            try
            {
                Double x = Convert.ToDouble(tbX.Text);
                Double h = 0.0000000001;
                Double x1 = x;
                Double x2 = x + h;
                String strFx1 = tbFx.Text;
                String strFx2 = tbFx.Text;
                strFx1 = Regex.Replace(strFx1, @"(\)|\d)(x)", match => match.Value[0].ToString() + "*x");
                strFx2 = Regex.Replace(strFx2, @"(\)|\d)(x)", match => match.Value[0].ToString() + "*x");
                String rep1 = x1.ToString();
                String rep2 = x2.ToString();
                strFx1 = strFx1.Replace("x", rep1);
                strFx2 = strFx2.Replace("x", rep2);
                Double kqFx = (tinhFx(strFx2) - tinhFx(strFx1)) / h;
                kqFx = Math.Round(kqFx, 3);
                tbKqdh.Text = kqFx.ToString();
            }
            catch 
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho phép!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Daoham_FormClosing(object sender, FormClosingEventArgs e)
        {
            total.showDhf = false;
            total.Where_add = 1;
			btTruyenkqdh_clicked= null;
			btNhapdh_clicked_true= null;
			btNhapdh_clicked_false = null;
			this.Hide();
            e.Cancel = true;
        }
        
        private void btTruyenkqdh_Click(object sender, EventArgs e)
        {
            if (this.btTruyenkqdh_clicked != null)
                this.btTruyenkqdh_clicked(sender, e);
        }

        private void cbNhapdl_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNhapdl.Checked)
            {
                total.Where_add = 2;
                if (this.btNhapdh_clicked_true != null)
                    this.btNhapdh_clicked_true(sender, e);
            }
            else
            {
                total.Where_add = 1;
                if (this.btNhapdh_clicked_false != null)
                    this.btNhapdh_clicked_false(sender, e);
            }
        }

        private void Daoham_Load(object sender, EventArgs e)
        {
            SetBounds(Screen.GetWorkingArea(this).Width * 5 / 100 + 50, Screen.GetWorkingArea(this).Height * 20 / 580, Width, Height);
        }

        private void Daoham_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) cbNhapdl.Checked = false;
        }
    }
}
