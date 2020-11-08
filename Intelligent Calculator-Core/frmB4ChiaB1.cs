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
	public partial class frmB4ChiaB1 : Form
	{
		public frmB4ChiaB1()
		{
			InitializeComponent();
		}

		private void frmB4ChiaB1_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
		}

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
			if ((txtA.Text == "") && (txtB.Text == "") && (txtC.Text == "") && (txtD.Text == "") && (txtE.Text == "") && (txtAA.Text == "") && (txtBB.Text == ""))
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

		private void txtE_TextChanged(object sender, EventArgs e)
		{
			check(txtE);
		}

		private void txtAA_TextChanged(object sender, EventArgs e)
		{
			check(txtAA);
		}

		private void txtBB_TextChanged(object sender, EventArgs e)
		{
			check(txtBB);
		}

		private void btnTinh_Click(object sender, EventArgs e)
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
			else if (txtE.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị d!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtAA.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị aa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtBB.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị bb!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					btnTinh.Enabled = false;
					btnLamMoi.Enabled = true;
					txtA.Enabled = false;
					txtB.Enabled = false;
					txtC.Enabled = false;
					txtD.Enabled = false;
					txtE.Enabled = false;
					txtAA.Enabled = false;
					txtBB.Enabled = false;

					double dblGiaTriA = 0;
					double dblGiaTriB = 0;
					double dblGiaTriC = 0;
					double dblGiaTriD = 0;
					double dblGiaTriE = 0;
					double dblGiaTriAA = 0;
					double dblGiaTriBB = 0;

					dblGiaTriA = lamtron(txtA, dblGiaTriA);
					dblGiaTriB = lamtron(txtB, dblGiaTriB);
					dblGiaTriC = lamtron(txtC, dblGiaTriC);
					dblGiaTriD = lamtron(txtD, dblGiaTriD);
					dblGiaTriE = lamtron(txtE, dblGiaTriE);
					dblGiaTriAA = lamtron(txtAA, dblGiaTriAA);
					dblGiaTriBB = lamtron(txtBB, dblGiaTriBB);

					txtA.Text = dblGiaTriA.ToString();
					txtB.Text = dblGiaTriB.ToString();
					txtC.Text = dblGiaTriC.ToString();
					txtD.Text = dblGiaTriD.ToString();
					txtE.Text = dblGiaTriE.ToString();
					txtAA.Text = dblGiaTriAA.ToString();
					txtBB.Text = dblGiaTriBB.ToString();

					double dblNghiemPTB1 = -dblGiaTriBB / dblGiaTriAA;

					double dblO6 = dblNghiemPTB1 * dblGiaTriA;
					double dblO11 = dblGiaTriB + dblO6;
					double dblO7 = dblNghiemPTB1 * dblO11;
					double dblO12 = dblGiaTriC + dblO7;
					double dblO8 = dblNghiemPTB1 * dblO12;
					double dblO13 = dblGiaTriD + dblO8;
					double dblO9 = dblNghiemPTB1 * dblO13;
					double dblO14 = dblGiaTriE + dblO9;

					if (dblGiaTriAA == 0 && dblGiaTriBB == 0)
					{
						MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else if (dblGiaTriA == 0)
					{
						MessageBox.Show("Hệ số x ở mẫu phải khác 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if (dblO14 == 0)
						{
							txtKQ.Text = " =" + (dblGiaTriA / dblGiaTriAA).ToString() + "x³ + " + (dblO11 / dblGiaTriAA).ToString() + "x² + " + (dblO12 / dblGiaTriAA).ToString() + "x + " + (dblO13 / dblGiaTriAA).ToString();
						}
						else
						{
							txtKQ.Text = "= (" + (dblGiaTriA / dblGiaTriAA).ToString() + "x³ + " + (dblO11 / dblGiaTriAA).ToString() + "x² + " + (dblO12 / dblGiaTriAA).ToString() + "x + " + (dblO13 / dblGiaTriAA).ToString() + ") dư " + dblO14.ToString();
						}
					}
				}
				catch
				{
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					btnTinh.Enabled = true;
					btnLamMoi.Enabled = true;
					txtA.Enabled = true;
					txtB.Enabled = true;
					txtC.Enabled = true;
					txtD.Enabled = true;
					txtE.Enabled = true;
					txtAA.Enabled = true;
					txtBB.Enabled = true;
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA.Enabled)
			{
				txtA.Text = "";
				txtB.Text = "";
				txtC.Text = "";
				txtD.Text = "";
				txtE.Text = "";
				txtAA.Text = "";
				txtBB.Text = "";
			}
			if ((txtA.Text == "") && (txtB.Text == "") && (txtC.Text == "") && (txtD.Text == "") && (txtE.Text == "") && (txtAA.Text == "") && (txtBB.Text == ""))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			btnTinh.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = true;
			txtE.Enabled = true;
			txtAA.Enabled = true;
			txtBB.Enabled = true;
			txtKQ.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
