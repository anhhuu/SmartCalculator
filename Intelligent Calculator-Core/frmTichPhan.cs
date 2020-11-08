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
    public partial class frmTichPhan : Form
    {
        public frmTichPhan()
        {
            InitializeComponent();
        }
        public event EventHandler btTruyenkqtp_clicked;
        public event EventHandler btNhaptp_clicked_true;
        public event EventHandler btNhaptp_clicked_false;
        public Boolean thuchien;
        public TextBox _kqtp
        {
            set
            {
                tbKqtp = value;
            }
            get
            {
                return tbKqtp;
            }
        }
        public Boolean _visibleTpf
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
        private void Tichphan_FormClosing(object sender, FormClosingEventArgs e)
        {
            total.showTpf = false;
            total.Where_add = 1;
			btTruyenkqtp_clicked = null;
			btNhaptp_clicked_true = null;
			btNhaptp_clicked_false = null;
			this.Hide();
            e.Cancel = true;
        }
        public Double tinhFx(String sFx, Double valueX)
        {
            frmMainIC frm1 = new frmMainIC();
            Double kq = 0;
            sFx = sFx.Replace("x", valueX.ToString());
            kq = frm1.tinhKQ(sFx);
            return kq;
        }
        public void btKqtp_Click(object sender, EventArgs e)
        {
            int i;
            Double n = 200;
            thuchien = true;
            try
            {
                String fx_tam = tbFx.Text;
                fx_tam = Regex.Replace(fx_tam, @"(\)|\d)(x)", match => match.Value[0].ToString() + "*x");
                Double tam = tinhFx(fx_tam, 2);
            }
            catch
            {
                MessageBox.Show("Lỗi cú pháp ở hàm số nhập vào. Vui lòng nhập đúng định dạng cho phép!");
                thuchien = false;
            }
            try
            {
                Double tam1 = Convert.ToDouble(tbCanA.Text);
                Double tam2 = Convert.ToDouble(tbCanB.Text);
            }

            catch 
            {
                MessageBox.Show("Lỗi ở 2 cận nhập vào. Vui lòng nhập đúng định dạng cho phép!");
                thuchien = false;
            }
            if (thuchien)
            {
                String fx = tbFx.Text;
                Double a = Convert.ToDouble(tbCanA.Text);
                Double b = Convert.ToDouble(tbCanB.Text);
                fx = Regex.Replace(fx, @"(\)|\d)(x)", match => match.Value[0].ToString() + "*x");
                Double h = (b - a) / n;
                Double t = 0;
                String strT = "";
                for (i = 0; i <= n; i++)
                {
                    Double tX = a + i * h;
                    Double tY = tinhFx(fx, tX);
                    strT += i.ToString() + " " + tY.ToString() + "\r\n";
                    if (i == 0 || i == n) t += tY;
                    else if (i % 2 == 0) t += 2 * tY;
                    else if (i % 2 != 0) t += 4 * tY;
                }
                t *= (h / 3);
                t = Math.Round(t, 3);
                tbKqtp.Text = t.ToString();
            }
        }

        private void btTruyenkqtp_Click(object sender, EventArgs e)
        {
            if (this.btTruyenkqtp_clicked != null)
                this.btTruyenkqtp_clicked(sender, e);
        }

        private void Tichphan_Load(object sender, EventArgs e)
        {
            SetBounds(Screen.GetWorkingArea(this).Width * 5 / 100 + 50, Screen.GetWorkingArea(this).Height * 20 / 44, Width, Height);
        }
        public void tbFx_add(string s)
        {
            tbFx.Text += s;
        }
        private void cbNhapdl_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNhapdl.Checked)
            {
                total.Where_add = 3;
                if (this.btNhaptp_clicked_true != null)
                    this.btNhaptp_clicked_true(sender, e);
            }
            else
            {
                total.Where_add = 1;
                if (this.btNhaptp_clicked_false != null)
                    this.btNhaptp_clicked_false(sender, e);
            }
        }

        private void Tichphan_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) cbNhapdl.Checked = false;
        }
    }
}
