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
	public partial class frmHPTXY : Form
	{
		double a1, b1, c1, a2, b2, c2, D, Dx, Dy, X, Y;
		public frmHPTXY()
		{
			InitializeComponent();
		}

		private void frmHPTXY_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
		}

		public static double lamtron(TextBox tbx, double number)
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

		private void check(TextBox tbx)
		{
			if ((txtA1.Text == "0") && (txtB1.Text == "0") && (txtC1.Text == "0") && (txtA2.Text == "0") && (txtB2.Text == "0") && (txtC2.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
		}


		private void txtA1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA1.Text == "0")
			{
				txtA1.Text = "";
			}
		}

		private void txtB1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB1.Text == "0")
			{
				txtB1.Text = "";
			}
		}

		private void txtC1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC1.Text == "0")
			{
				txtC1.Text = "";
			}
		}

		private void txtA2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA2.Text == "0")
			{
				txtA2.Text = "";
			}
		}

		private void txtB2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB2.Text == "0")
			{
				txtB2.Text = "";
			}
		}

		private void txtC3_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC2.Text == "0")
			{
				txtC2.Text = "";
			}
		}

		private void txtA1_TextChanged(object sender, EventArgs e)
		{
			check(txtA1);
		}

		private void txtB1_TextChanged(object sender, EventArgs e)
		{
			check(txtB1);
		}

		private void txtC1_TextChanged(object sender, EventArgs e)
		{
			check(txtC1);
		}

		private void txtA2_TextChanged(object sender, EventArgs e)
		{
			check(txtA2);
		}

		private void txtB2_TextChanged(object sender, EventArgs e)
		{
			check(txtB2);
		}

		private void txtC2_TextChanged(object sender, EventArgs e)
		{
			check(txtC2);
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{


			if (txtA1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị a1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtB1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị b1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtC1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtA2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị a2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtB2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị b2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtC2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				try
				{
					txtA1.Enabled = false;
					txtB1.Enabled = false;
					txtC1.Enabled = false;
					txtA2.Enabled = false;
					txtB2.Enabled = false;
					txtC2.Enabled = false;
					btnGiai.Enabled = false;
					btnLamMoi.Enabled = true;

					a1 = lamtron(txtA1, a1);
					txtA1.Text = (a1).ToString();
					b1 = lamtron(txtB1, b1);
					txtB1.Text = (b1).ToString();
					c1 = lamtron(txtC1, c1);
					txtC1.Text = (c1).ToString();
					a2 = lamtron(txtA2, a2);
					txtA2.Text = (a2).ToString();
					b2 = lamtron(txtB2, b2);
					txtB2.Text = (b2).ToString();
					c2 = lamtron(txtC2, c2);
					txtC2.Text = (c2).ToString();
					D = a1 * b2 - b1 * a2;
					Dx = c1 * b2 - b1 * c2;
					Dy = a1 * c2 - c1 * a2;
					if (D == 0)
					{
						if (Dx == 0)
						{
							if (Dy == 0)
							{
								txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y thuộc R";
							}
							else
							{
								txtKQ.Text = "Hệ phương trình đã cho vô nghiệm";
							}
						}
						else
						{
							txtKQ.Text = "Hệ phương trình đã cho vô nghiệm";
						}
					}
					else
					{
						X = Dx / D;
						Y = Dy / D;
						txtKQ.Text = "Hệ phương trình có nghiệm";
						txtX.Text = "x = " + X;
						txtY.Text = "y = " + Y;
					}
				}
				catch
				{
					txtA1.Enabled = true;
					txtB1.Enabled = true;
					txtC1.Enabled = true;
					txtA2.Enabled = true;
					txtB2.Enabled = true;
					txtC2.Enabled = true;
					btnGiai.Enabled = true;
					btnLamMoi.Enabled = true;
					txtKQ.Text = "";
					txtX.Text = "";
					txtY.Text = "";
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA1.Enabled == true)
			{
				txtA1.Text = "0";
				txtB1.Text = "0";
				txtC1.Text = "0";
				txtA2.Text = "0";
				txtB2.Text = "0";
				txtC2.Text = "0";
			}

			if ((txtA1.Text == "0") && (txtB1.Text == "0") && (txtC1.Text == "0") && (txtA2.Text == "0") && (txtB2.Text == "0") && (txtC2.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
			txtA1.Enabled = true;
			txtB1.Enabled = true;
			txtC1.Enabled = true;
			txtA2.Enabled = true;
			txtB2.Enabled = true;
			txtC2.Enabled = true;
			txtKQ.Text = "";
			txtX.Text = "";
			txtY.Text = "";
			btnGiai.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
