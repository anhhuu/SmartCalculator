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
	public partial class frmPTB2 : Form
	{
		public frmPTB2()
		{
			InitializeComponent();
		}

		private void frmPTB2_Load(object sender, EventArgs e)
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

		#region Giai

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
					double delta, x1, x2;

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
							if (c == 0)
							{
								txtKQ.Text = "Phương trình đã cho có nghiệm đúng với mọi x thuộc R";
							}
							else
							{
								txtKQ.Text = "Phương trình đã cho vô nghiệm";
							}

						}
						else
						{
							txtKQ.Text = "Phương trình đã cho có một nghiệm duy nhất:";
							txtX1.Text = "x = " + (-c / b);
						}

					}
					else
					{
						delta = (b * b - 4 * a * c);
						x1 = (-b + Math.Sqrt(delta)) / (2 * a);
						x2 = (-b - Math.Sqrt(delta)) / (2 * a);
						if (delta > 0)
						{
							txtKQ.Text = "Phương trình đã cho có 2 nghiệm phân biệt";
							txtX1.Text = "x1 = " + x1;
							txtX2.Text = "x2 = " + x2;
						}
						else
						{
							if (delta == 0)
							{
								txtKQ.Text = "Phương trình đã cho có nghiệm kép";
								txtX1.Text = "x1 = x2 = " + (-b / 2 * a);
							}
							else
							{

								txtKQ.Text = "Phương trình đã cho vô nghiệm";
								txtX1.Text = "do Δ = " + delta + " < 0";

							}
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
					txtX1.Text = "";
					txtX2.Text = "";
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		#endregion

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
			txtX1.Text = "";
			txtX2.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
