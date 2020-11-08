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
	public partial class frmMinMaxHS : Form
	{
		public frmMinMaxHS()
		{
			InitializeComponent();
		}

		private void frmMinMaxHS_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
			btnTim.Enabled = true;
			rdoB2.Checked = false;
			rdoB3.Checked = false;
			txtA.Enabled = false;
			txtB.Enabled = false;
			txtC.Enabled = false;
			txtD.Enabled = false;
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
			if ((rdoB2.Checked == true) && (txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0"))
				btnLamMoi.Enabled = false;
			else if ((rdoB3.Checked == true) && (txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0") && (txtD.Text == "0"))
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

		private void txtD_TextChanged(object sender, EventArgs e)
		{
			check(txtD);
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

		private void txtD_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtD.Text == "0")
				txtD.Text = "";
		}

		private void rdoB2_CheckedChanged(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = true;
			btnTim.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = false;
			txtD.Text = "0";
			txtKQ1.Text = "";
			txtKQ2.Text = "";
		}

		private void rdoB3_CheckedChanged(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = true;
			btnTim.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = true;
			txtKQ1.Text = "";
			txtKQ2.Text = "";
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (rdoB2.Checked == true)
			{
				if (txtA.Text == "")
				{
					MessageBox.Show("Bạn chưa nhập giá trị a!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (txtC.Text == "")
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
						double A = 0;
						double B = 0;
						double C = 0;

						A = lamtron(txtA, A);
						B = lamtron(txtB, B);
						C = lamtron(txtC, C);

						txtA.Text = A.ToString();
						txtB.Text = B.ToString();
						txtC.Text = C.ToString();

						btnTim.Enabled = false;
						btnLamMoi.Enabled = true;
						txtA.Enabled = false;
						txtB.Enabled = false;
						txtC.Enabled = false;
						txtD.Enabled = false;

						if (A == 0)
						{
							btnTim.Enabled = true;
							btnLamMoi.Enabled = true;
							txtA.Enabled = true;
							txtB.Enabled = true;
							txtC.Enabled = true;
							txtD.Enabled = false;
							MessageBox.Show("Hệ số a phải khác 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else if (A > 0)
						{
							double X = -B / (2 * A);
							double Min = A * X * X + B * X + C;
							txtKQ1.Text = "Hàm số có cực tiểu = " + Min.ToString() + " tại x = " + X.ToString();
						}
						else
						{
							double X = -B / (2 * A);
							double Max = A * X * X + B * X + C;
							txtKQ1.Text = "Hàm số có cực đại = " + Max.ToString() + " tại x = " + X.ToString();
						}
					}
					catch (Exception)
					{
						btnTim.Enabled = true;
						btnLamMoi.Enabled = true;
						txtA.Enabled = true;
						txtB.Enabled = true;
						txtC.Enabled = true;
						txtD.Enabled = false;
						txtKQ1.Text = "";
						txtKQ2.Text = "";
						MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			if (rdoB3.Checked == true)
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
				else if (txtD.Text == "")
				{
					MessageBox.Show("Bạn chưa nhập giá trị d!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					try
					{
						btnLamMoi.Enabled = true;
						btnTim.Enabled = false;
						txtA.Enabled = false;
						txtB.Enabled = false;
						txtC.Enabled = false;
						txtD.Enabled = false;

						double A = 0;
						double B = 0;
						double C = 0;
						double D = 0;

						A = lamtron(txtA, A);
						B = lamtron(txtB, B);
						C = lamtron(txtC, C);
						D = lamtron(txtD, D);

						txtA.Text = A.ToString();
						txtB.Text = B.ToString();
						txtC.Text = C.ToString();
						txtD.Text = D.ToString();

						if (A == 0)
						{
							btnLamMoi.Enabled = true;
							btnTim.Enabled = true;
							txtA.Enabled = true;
							txtB.Enabled = true;
							txtC.Enabled = true;
							txtD.Enabled = true;
							MessageBox.Show("Hệ số a phải khác 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							if (B * B - 3 * A * C <= 0)
							{
								txtKQ1.Text = "Hàm số không tồn tại cực trị";
							}
							else
							{
								double X1 = (-B - Math.Sqrt(B * B - 3 * A * C)) / (3 * A);
								double X2 = (-B + Math.Sqrt(B * B - 3 * A * C)) / (3 * A);
								double Cuctri1 = A * X1 * X1 * X1 + B * X1 * X1 + C * X1 + D;
								double Cuctri2 = A * X2 * X2 * X2 + B * X2 * X2 + C * X2 + D;
								if (Cuctri1 > Cuctri2)
								{
									txtKQ1.Text = "Hàm số có cực tiểu = " + Cuctri2.ToString() + " tại x = " + X2.ToString();
									txtKQ2.Text = "Hàm số có cực đại = " + Cuctri1.ToString() + " tại x = " + X1.ToString();
								}
								if (Cuctri1 < Cuctri2)
								{
									txtKQ1.Text = "Hàm số có cực tiểu = " + Cuctri1.ToString() + " tại x = " + X1.ToString();
									txtKQ2.Text = "Hàm số có cực đại = " + Cuctri2.ToString() + " tại x = " + X2.ToString();
								}
							}
						}
					}
					catch (Exception)
					{
						btnTim.Enabled = true;
						btnLamMoi.Enabled = true;
						txtA.Enabled = true;
						txtB.Enabled = true;
						txtC.Enabled = true;
						txtD.Enabled = true;
						txtKQ1.Text = "";
						txtKQ2.Text = "";
						MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if(txtA.Enabled == true && rdoB2.Checked == true)
			{
				txtA.Text = "0";
				txtB.Text = "0";
				txtC.Text = "0";
			}
			if (txtA.Enabled == true && rdoB3.Checked == true)
			{
				txtA.Text = "0";
				txtB.Text = "0";
				txtC.Text = "0";
				txtD.Text = "0";
			}

			if ((rdoB2.Checked) && (txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0"))
				btnLamMoi.Enabled = false;
			else if ((rdoB3.Checked) && (txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0") && (txtD.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			btnTim.Enabled = true;

			if (rdoB2.Checked)
			{
				txtA.Enabled = true;
				txtB.Enabled = true;
				txtC.Enabled = true;
				txtD.Enabled = false;
			}
			if (rdoB3.Checked)
			{
				txtA.Enabled = true;
				txtB.Enabled = true;
				txtC.Enabled = true;
				txtD.Enabled = true;
			}

			txtKQ1.Text = "";
			txtKQ2.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
