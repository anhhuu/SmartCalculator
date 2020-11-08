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
	public partial class frmBPTB22 : Form
	{
		public frmBPTB22()
		{
			InitializeComponent();
		}

		private void frmBPTB22_Load(object sender, EventArgs e)
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

					double dblA = 0;
					double dblB = 0;
					double dblC = 0;

					dblA = lamtron(txtA, dblA);
					dblB = lamtron(txtB, dblB);
					dblC = lamtron(txtC, dblC);
					txtA.Text = (dblA).ToString();
					txtB.Text = (dblB).ToString();
					txtC.Text = (dblC).ToString();

					if (dblA == 0)
					{
						if (dblB == 0)
						{
							if (dblC <= 0)
							{
								txtKQ.Text = "Bất phương trình nghiệm đúng với mọi x thuộc R";
							}
							else
							{
								txtKQ.Text = "Bất phương trình vô nghiệm";
							}
						}
						else if (dblB > 0)
						{
							double dblNghiem = -dblC / dblB;
							txtKQ.Text = "Bất phương trình có nghiệm:";
							txtX.Text = "x ≤ " + dblNghiem.ToString();
						}
						else
						{
							double dblNghiem = -dblC / dblB;
							txtKQ.Text = "Bất phương trình có nghiệm:";
							txtX.Text = "x ≥ " + dblNghiem.ToString();
						}
					}
					else if (dblA > 0)
					{
						double dblDelta = dblB * dblB - 4 * dblA * dblC;
						if (dblDelta < 0)
						{
							txtKQ.Text = "Bất phương trình vô nghiệm";
						}
						else if (dblDelta == 0)
						{
							double dblNghiem = -dblB / (2 * dblA);
							txtKQ.Text = "Bất phương trình có nghiệm:";
							txtX.Text = "x = " + dblNghiem.ToString();
						}
						else
						{
							double dblNghiem1 = (-dblB - Math.Sqrt(dblDelta)) / (2 * dblA);
							double dblNghiem2 = (-dblB + Math.Sqrt(dblDelta)) / (2 * dblA);
							txtKQ.Text = "Nghiệm của bất phương trình là:";
							txtX.Text = dblNghiem1.ToString() + " ≤ x ≤ " + dblNghiem2.ToString();
						}
					}
					else
					{
						double dblDelta = dblB * dblB - 4 * dblA * dblC;
						if (dblDelta < 0)
						{
							txtKQ.Text = " Bất phương trình nghiệm đúng với mọi x thuộc R";
						}
						else if (dblDelta == 0)
						{
							double dblNghiem = -dblB / (2 * dblA);
							txtKQ.Text = " Bất phương trình nghiệm đúng với mọi x thuộc R";
						}
						else
						{
							double dblNghiem1 = (-dblB + Math.Sqrt(dblDelta)) / (2 * dblA);
							double dblNghiem2 = (-dblB - Math.Sqrt(dblDelta)) / (2 * dblA);
							txtKQ.Text = "Nghiệm của bất phương trình là:";
							txtX.Text = "x ≤ " + dblNghiem1.ToString() + " hoặc " + dblNghiem2.ToString() + " ≤ x";
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
