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
	public partial class frmBPTB21 : Form
	{
		public frmBPTB21()
		{
			InitializeComponent();
		}

		private void frmBPTB21_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
		}

		//Hàm làm tròn khi chuyển từ xâu sang số
		private double lamtron(TextBox tbx, double number)
		{
			number = Convert.ToSingle(tbx.Text);
			if (Math.Abs(number - Math.Round(number, 5)) < 1e-5)
			{
				number = Math.Round(number, 6);
			}
			else
				number = Math.Round(number, 12);
			return number;
		}

		public void check(TextBox tbx)
		{
			if ((txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
		}

		private void txtA_TextChanged(object sender, EventArgs e)
		{
			check(txtA);
		}

		private void txtB_TextChanged(object sender, EventArgs e)
		{
			check(txtB);
		}

		private void txtC_TextChanged(object sender, EventArgs e)
		{
			check(txtC);
		}

		private void txtA_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA.Text == "0")
				txtA.Text = "";
		}

		private void txtB_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB.Text == "0")
				txtB.Text = "";
		}

		private void txtC_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC.Text == "0")
				txtC.Text = "";
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			if (txtA.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị a!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else if (txtB.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị b!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else if (txtC.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					txtA.Enabled = false;
					txtB.Enabled = false;
					txtC.Enabled = false;
					btnGiai.Enabled = false;
					btnLamMoi.Enabled = true;

					double a = 0;
					double b = 0;
					double c = 0;

					a = lamtron(txtA, a);
					b = lamtron(txtB, b);
					c = lamtron(txtC, c);
					txtA.Text = (a).ToString();
					txtB.Text = (b).ToString();
					txtC.Text = (c).ToString();

					if (a == 0)
					{
						if (b == 0)
						{
							if (c >= 0)
							{
								txtKQ.Text = "Bất phương trình có nghiệm đúng mới mọi số thực x";
							}
							else
							{
								txtKQ.Text = "Bất phương trình vô nghiệm";
							}
						}
						else if (b > 0)
						{
							double x = -c / b;
							txtKQ.Text = "Nghiệm của bất phương trình là: ";
							txtX.Text = "x ≥ " + x.ToString();
						}
						else if (b < 0)
						{
							double x = -c / b;
							txtKQ.Text = "Nghiệm của bất phương trình là: ";
							txtX.Text = "x ≤ " + x.ToString();
						}
					}
					if (a > 0)
					{
						double D = b * b - 4 * a * c;
						if (D <= 0)
						{
							txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
						}
						else
						{
							double x1 = (-b - Math.Sqrt(D)) / (2 * a);
							double x2 = (-b + Math.Sqrt(D)) / (2 * a);
							txtKQ.Text = "Nghiệm của bất phương trình là: ";
							txtX.Text = "x ≤ " + x1.ToString() + " hoặc " + x2.ToString() + " ≤ x";
						}
					}
					if (a < 0)
					{
						double D = b * b - 4 * a * c;
						if (D < 0)
						{
							txtKQ.Text = "Bất phương trình vô nghiệm";
						}
						else if (D == 0)
						{
							double x = -b / (2 * a);
							txtKQ.Text = "Nghiệm của bất phương trình là: ";
							txtX.Text = "x = " + x.ToString();
						}
						else
						{
							double x1 = (-b + Math.Sqrt(D)) / (2 * a);
							double x2 = (-b - Math.Sqrt(D)) / (2 * a);
							txtKQ.Text = "Nghiệm của bất phương trình là: ";
							txtX.Text = x1.ToString() + " ≤ x ≤ " + x2.ToString();
						}
					}
				}
				catch (Exception)
				{
					btnGiai.Enabled = true;
					btnLamMoi.Enabled = true;
					txtA.Enabled = true;
					txtB.Enabled = true;
					txtC.Enabled = true;
					txtKQ.Text = "";
					txtX.Text = "";
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA.Enabled == true)
			{
				txtA.Text = "0";
				txtB.Text = "0";
				txtC.Text = "0";
			}

			if ((txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			btnGiai.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtKQ.Text = "";
			txtX.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
