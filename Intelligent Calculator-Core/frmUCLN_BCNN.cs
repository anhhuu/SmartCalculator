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
	public partial class frmUCLN_BCNN : Form
	{
		public frmUCLN_BCNN()
		{
			InitializeComponent();
		}

		private void frmUCLN_BCNN_Load(object sender, EventArgs e)
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
			if ((txtA.Text == "0") && (txtB.Text == "0"))
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

		private void txtA_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA.Text == "0")
			{
				txtA.Text = "";
			}
		}

		private void txtB_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB.Text == "0")
			{
				txtB.Text = "";
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			txtA.Enabled = false;
			txtB.Enabled = false;
			btnTim.Enabled = false;
			btnLamMoi.Enabled = true;

			if (txtA.Text == "") //Nhập a trống
			{
				txtA.Enabled = true;
				txtB.Enabled = true;
				btnTim.Enabled = true;
				btnLamMoi.Enabled = true;
				txtUCLN.Text = "";
				txtBCNN.Text = "";
				MessageBox.Show("Bạn chưa nhập giá trị a!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else if (txtB.Text == "") //Nhập b trống
			{
				txtA.Enabled = true;
				txtB.Enabled = true;
				btnTim.Enabled = true;
				btnLamMoi.Enabled = true;
				txtUCLN.Text = "";
				txtBCNN.Text = "";
				MessageBox.Show("Bạn chưa nhập giá trị b!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					double A = 0, B = 0;
					A = lamtron(txtA, A);
					txtA.Text = A.ToString();
					B = lamtron(txtB, B);
					txtB.Text = B.ToString();
					if (A * B == 0)
					{
						txtA.Enabled = true;
						txtB.Enabled = true;
						btnTim.Enabled = true;
						btnLamMoi.Enabled = true;
						txtUCLN.Text = "";
						txtBCNN.Text = "";
						MessageBox.Show("Vui lòng nhập các số a,b khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						A = Math.Abs(A);
						B = Math.Abs(B);
						double M = A;
						double N = B;
						if (A % 1 == 0 && B % 1 == 0)
						{
							while (A != B)
							{
								if (A < B)
								{
									B = B - A;
								}
								else
								{
									A = A - B;
								}
							}
							double UCLN = A;
							double BCNN = (M * N) / UCLN;
							txtUCLN.Text = "Ước chung lớn nhất = " + UCLN.ToString();
							txtBCNN.Text = "Bội chung nhỏ nhất = " + BCNN.ToString();
						} else
						{
							txtA.Enabled = true;
							txtB.Enabled = true;
							btnTim.Enabled = true;
							btnLamMoi.Enabled = true;
							txtUCLN.Text = "";
							txtBCNN.Text = "";
							MessageBox.Show("Lỗi, không thực hiện với số thực", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
				catch (Exception)
				{
					txtA.Enabled = true;
					txtB.Enabled = true;
					btnTim.Enabled = true;
					btnLamMoi.Enabled = true;
					txtUCLN.Text = "";
					txtBCNN.Text = "";
					MessageBox.Show("Bạn chưa nhập giá trị b!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA.Enabled == true)
			{
				txtA.Text = "0";
				txtB.Text = "0";
			}
			if ((txtA.Text == "0") && (txtB.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			txtUCLN.Text = "";
			txtBCNN.Text = "";
			txtA.Enabled = true;
			txtB.Enabled = true;
			btnTim.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
