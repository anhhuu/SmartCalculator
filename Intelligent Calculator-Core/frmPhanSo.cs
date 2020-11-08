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
	public partial class frmPhanSo : Form
	{
		public frmPhanSo()
		{
			InitializeComponent();
		}

		private void frmPhanSo_Load(object sender, EventArgs e)
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
			if ((txtTuSo1.Text == "") && (txtMauSo1.Text == "") && (txtTuSo2.Text == "") && (txtMauSo2.Text == ""))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
		}

		private void txtTuSo1_TextChanged(object sender, EventArgs e)
		{
			check(txtTuSo1);
		}

		private void txtMauSo1_TextChanged(object sender, EventArgs e)
		{
			check(txtMauSo1);
		}

		private void txtTuSo2_TextChanged(object sender, EventArgs e)
		{
			check(txtTuSo2);
		}

		private void txtMauSo2_TextChanged(object sender, EventArgs e)
		{
			check(txtMauSo2);
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			if (txtTuSo1.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtMauSo1.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtTuSo2.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtMauSo2.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					cboPhepTinh.Enabled = false;
					btnLamMoi.Enabled = true;
					btnTinh.Enabled = false;
					txtTuSo1.Enabled = false;
					txtMauSo1.Enabled = false;
					txtTuSo2.Enabled = false;
					txtMauSo2.Enabled = false;

					double dblTuSo1 = 0;
					double dblMauSo1 = 0;
					double dblTuSo2 = 0;
					double dblMauSo2 = 0;

					dblTuSo1 = lamtron(txtTuSo1, dblTuSo1);
					dblMauSo1 = lamtron(txtMauSo1, dblMauSo1);
					dblTuSo2 = lamtron(txtTuSo2, dblTuSo2);
					dblMauSo2 = lamtron(txtMauSo2, dblMauSo2);

					txtTuSo1.Text = dblTuSo1.ToString();
					txtMauSo1.Text = dblMauSo1.ToString();
					txtTuSo2.Text = dblTuSo2.ToString();
					txtMauSo2.Text = dblMauSo2.ToString();
					double dblTuSoChuaRutGon = 0;
					double dblMauSoChuaRutGon = 0;
					double dblTuSoDaRutGon = 0;
					double dblMauSoDaRutGon = 0;
					double dblQuyDongMauSo = 0;
					double dblMauSoChung = 0;
					double dblKetQua = 0;

					if (dblMauSo1 * dblMauSo2 == 0)
					{
						cboPhepTinh.Enabled = true;
						btnLamMoi.Enabled = true;
						btnTinh.Enabled = true;
						txtTuSo1.Enabled = true;
						txtMauSo1.Enabled = true;
						txtTuSo2.Enabled = true;
						txtMauSo2.Enabled = true;
						MessageBox.Show("Mấu số phải khác 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						// Nếu là phép "+"
						if (cboPhepTinh.Text == "+")
						{
							lblPhepTinh.Text = "+";
							if (dblMauSo1 == dblMauSo2)
							{
								dblTuSoChuaRutGon = dblTuSo1 + dblTuSo2;
								dblMauSoChuaRutGon = dblMauSo1;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSo1.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSo2.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}

							if (dblMauSo1 % dblMauSo2 == 0)
							{
								dblQuyDongMauSo = dblMauSo1 / dblMauSo2;
								dblTuSo2 = dblTuSo2 * dblQuyDongMauSo;
								dblTuSoChuaRutGon = dblTuSo1 + dblTuSo2;
								dblMauSoChuaRutGon = dblMauSo1;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSo1.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSo1.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}

							if (dblMauSo2 % dblMauSo1 == 0)
							{
								dblQuyDongMauSo = dblMauSo2 / dblMauSo1;
								dblTuSo1 = dblTuSo1 * dblQuyDongMauSo;
								dblTuSoChuaRutGon = dblTuSo1 + dblTuSo2;
								dblMauSoChuaRutGon = dblMauSo2;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSo2.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSo2.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}

							if (dblMauSo1 % dblMauSo2 != 0 && dblMauSo2 % dblMauSo1 != 0)
							{
								dblMauSoChung = dblMauSo1 * dblMauSo2;
								dblTuSo1 = dblTuSo1 * dblMauSo2;
								dblTuSo2 = dblTuSo2 * dblMauSo1;
								dblTuSoChuaRutGon = dblTuSo1 + dblTuSo2;
								dblMauSoChuaRutGon = dblMauSoChung;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSoChung.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSoChung.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}
						}



						// Nếu là phép "-"
						if (cboPhepTinh.Text == "-")
						{
							lblPhepTinh.Text = "-";
							if (dblMauSo1 == dblMauSo2)
							{
								dblTuSoChuaRutGon = dblTuSo1 - dblTuSo2;
								dblMauSoChuaRutGon = dblMauSo1;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSo1.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSo2.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}

							if (dblMauSo1 % dblMauSo2 == 0)
							{
								dblQuyDongMauSo = dblMauSo1 / dblMauSo2;
								dblTuSo2 = dblTuSo2 * dblQuyDongMauSo;
								dblTuSoChuaRutGon = dblTuSo1 - dblTuSo2;
								dblMauSoChuaRutGon = dblMauSo1;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSo1.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSo1.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}

							if (dblMauSo2 % dblMauSo1 == 0)
							{
								dblQuyDongMauSo = dblMauSo2 / dblMauSo1;
								dblTuSo1 = dblTuSo1 * dblQuyDongMauSo;
								dblTuSoChuaRutGon = dblTuSo1 - dblTuSo2;
								dblMauSoChuaRutGon = dblMauSo2;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSo2.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSo2.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}

							if (dblMauSo1 % dblMauSo2 != 0 && dblMauSo2 % dblMauSo1 != 0)
							{
								dblMauSoChung = dblMauSo1 * dblMauSo2;
								dblTuSo1 = dblTuSo1 * dblMauSo2;
								dblTuSo2 = dblTuSo2 * dblMauSo1;
								dblTuSoChuaRutGon = dblTuSo1 - dblTuSo2;
								dblMauSoChuaRutGon = dblMauSoChung;
								lblTuSo1.Text = dblTuSo1.ToString();
								lblMauSo1.Text = dblMauSoChung.ToString();
								lblTuSo2.Text = dblTuSo2.ToString();
								lblMauSo2.Text = dblMauSoChung.ToString();
								lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
								lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
							}
						}



						// Nếu là phép "x"
						if (cboPhepTinh.Text == "x")
						{
							lblPhepTinh.Text = "x";
							dblTuSoChuaRutGon = dblTuSo1 * dblTuSo2;
							dblMauSoChuaRutGon = dblMauSo1 * dblMauSo2;
							lblTuSo1.Text = dblTuSo1.ToString();
							lblMauSo1.Text = dblMauSo1.ToString();
							lblTuSo2.Text = dblTuSo2.ToString();
							lblMauSo2.Text = dblMauSo2.ToString();
							lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
							lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
						}



						// Nếu là phép "/"
						if (cboPhepTinh.Text == "/")
						{
							lblPhepTinh.Text = "/";
							dblTuSoChuaRutGon = dblTuSo1 * dblMauSo2;
							dblMauSoChuaRutGon = dblMauSo1 * dblTuSo2;
							lblTuSo1.Text = dblTuSo1.ToString();
							lblTuSo2.Text = dblTuSo2.ToString();
							lblMauSo1.Text = dblMauSo1.ToString();
							lblMauSo2.Text = dblMauSo2.ToString();
							lblTuSoChuaRutGon.Text = dblTuSoChuaRutGon.ToString();
							lblMauSoChuaRutGon.Text = dblMauSoChuaRutGon.ToString();
						}



						// Rút gọn phân số
						if (dblMauSoChuaRutGon % dblTuSoChuaRutGon == 0)
						{
							dblTuSoDaRutGon = dblTuSoChuaRutGon / dblTuSoChuaRutGon;
							dblMauSoDaRutGon = dblMauSoChuaRutGon / dblTuSoChuaRutGon;
							lblTuSoDaRutGon.Text = dblTuSoDaRutGon.ToString();
							lblMauSoDaRutGon.Text = dblMauSoDaRutGon.ToString();
						}

						if (dblTuSoChuaRutGon % dblMauSoChuaRutGon == 0)
						{
							lblTuSoDaRutGon.Text = "";
							lblMauSoDaRutGon.Text = "";
						}

						if (dblTuSoChuaRutGon % dblMauSoChuaRutGon != 0 && dblMauSoChuaRutGon % dblTuSoChuaRutGon != 0)
						{
							for (int i = 1; i <= dblTuSoChuaRutGon || i <= dblMauSoChuaRutGon; i++)
							{
								if (dblTuSoChuaRutGon % i == 0 && dblMauSoChuaRutGon % i == 0)
								{
									dblTuSoDaRutGon = dblTuSoChuaRutGon / i;
									dblMauSoDaRutGon = dblMauSoChuaRutGon / i;
									lblTuSoDaRutGon.Text = dblTuSoDaRutGon.ToString();
									lblMauSoDaRutGon.Text = dblMauSoDaRutGon.ToString();
								}
							}
						}


						dblKetQua = dblTuSoChuaRutGon / dblMauSoChuaRutGon;
						lblKetQua.Text = dblKetQua.ToString();
					}
				}
				catch
				{
					cboPhepTinh.Enabled = true;
					btnLamMoi.Enabled = true;
					btnTinh.Enabled = true;
					txtTuSo1.Enabled = true;
					txtMauSo1.Enabled = true;
					txtTuSo2.Enabled = true;
					txtMauSo2.Enabled = true;
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtTuSo1.Enabled == true)
			{
				txtTuSo1.Text = "";
				txtMauSo1.Text = "";
				txtTuSo2.Text = "";
				txtMauSo2.Text = "";
			}
			if ((txtTuSo1.Text == "") && (txtMauSo1.Text == "") && (txtTuSo2.Text == "") && (txtMauSo2.Text == ""))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			cboPhepTinh.Enabled = true;
			btnTinh.Enabled = true;
			txtTuSo1.Enabled = true;
			txtMauSo1.Enabled = true;
			txtTuSo2.Enabled = true;
			txtMauSo2.Enabled = true;

			lblPhepTinh.Text = "";
			lblTuSo1.Text = "";
			lblMauSo1.Text = "";
			lblTuSo2.Text = "";
			lblMauSo2.Text = "";
			lblTuSoChuaRutGon.Text = "";
			lblMauSoChuaRutGon.Text = "";
			lblTuSoDaRutGon.Text = "";
			lblMauSoDaRutGon.Text = "";
			lblKetQua.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
