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
	public partial class frmSNT : Form
	{
		public frmSNT()
		{
			InitializeComponent();
		}

		private void frmSNT_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
		}

		private double lamtron(TextBox tbx, double number)
		{
			number = double.Parse(tbx.Text);
			if (Math.Abs(number - Math.Round(number, 5)) < 1e-5)
			{
				number = Math.Round(number, 6);
			}
			else
				number = Math.Round(number, 12);
			return number;
		}

		private void check(TextBox tbx)
		{
			if (txtA.Text == "")
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
		}

		private void txtA_TextChanged(object sender, EventArgs e)
		{
			check(txtA);
		}

		private bool IsPrime(double n)
		{
			if (n < 2)
			{
				return false;
			}
			else
			{
				if (n % 2 == 0)
				{
					return false;
				}
				for (int i = 3; i < Math.Sqrt(n); i += 2)
				{
					if (n % i == 0)
					{
						return false;
					}
				}

			}
			return true;
		}

		private void btnKiemTra_Click(object sender, EventArgs e)
		{
			if (txtA.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị nào cả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					txtA.Enabled = false;
					btnLamMoi.Enabled = true;
					btnKiemTra.Enabled = false;

					double soKT = 0;

					soKT = lamtron(txtA, soKT);
					txtA.Text = soKT.ToString();

					if(soKT%1 != 0)
					{
						MessageBox.Show("Không được nhập số thực!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txtA.Enabled = true;
						btnLamMoi.Enabled = true;
						btnKiemTra.Enabled = true;
					} else
					{
						if (IsPrime(soKT))
						{
							txtKQ.Text = soKT.ToString() + " là số nguyên tố.";
						}
						else
						{
							txtKQ.Text = soKT.ToString() + " không phải là số nguyên tố.";
						}
					}
				}
				catch
				{
					txtA.Enabled = true;
					btnKiemTra.Enabled = true;
					btnLamMoi.Enabled = true;
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA.Enabled == true)
			{
				txtA.Text = "";
			}
			if (txtA.Text == "")
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
			btnKiemTra.Enabled = true;
			txtA.Enabled = true;
			txtKQ.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
