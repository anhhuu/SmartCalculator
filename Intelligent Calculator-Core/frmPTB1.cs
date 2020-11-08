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
	public partial class frmPTB1 : Form
	{
		public frmPTB1()
		{
			InitializeComponent();
		}

		private void frmPTB1_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
		}

		//Hàm làm tròn khi chuyển từ xâu sang số

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
				txtA.Text = "";
		}

		private void txtB_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB.Text == "0")
				txtB.Text = "";
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			if (txtA.Text == "") //Nhập a trống
			{
				MessageBox.Show("Bạn chưa nhập giá trị a!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else if (txtB.Text == "") //Nhập b trống
			{
				MessageBox.Show("Bạn chưa nhập giá trị b!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				try
				{
					txtA.Enabled = false;
					txtB.Enabled = false;
					btnGiai.Enabled = false;
					btnLamMoi.Enabled = true;

					double a = 0;
					double b = 0;
					double x = 0;
					a = lamtron(txtA, a);
					b = lamtron(txtB, b);

					txtA.Text = (a).ToString();
					txtB.Text = (b).ToString();
					if (a == 0)
					{
						if (b == 0)
						{
							txtKQ.Text = "Phương trình có nghiệm đúng với mọi x thuộc R";
						}
						else
						{
							txtKQ.Text = "Phương trình vô nghiệm";
						}
					}
					else
					{
						x = ((-b) / a);
						txtKQ.Text = "Phương trình có nghiệm là: x = " + x;
					}
				}
				catch (Exception) //Xử lý dữ liệu nhập vào textbox, nếu có lỗi thì in ra màn hình thông báo
				{
					txtA.Enabled = true;
					txtB.Enabled = true;
					btnGiai.Enabled = true;
					btnLamMoi.Enabled = true;
					txtKQ.Text = "";
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
			}
			if ((txtA.Text == "0") && (txtB.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			txtKQ.Text = "";
			txtA.Enabled = true;
			txtB.Enabled = true;
			btnGiai.Enabled = true;
			//btnLamMoi.Enabled = false;

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}

