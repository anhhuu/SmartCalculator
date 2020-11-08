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
	public partial class frmHonSo : Form
	{
		public frmHonSo()
		{
			InitializeComponent();
		}

		private void frmHonSo_Load(object sender, EventArgs e)
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
			if ((txtGiaTri1.Text == "") && (txtGiaTri2.Text == "") && (txtGiaTri3.Text == "") && (txtGiaTri4.Text == "") && (txtGiaTri5.Text == "") && (txtGiaTri6.Text == ""))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
		}

		private void txtGiaTri1_TextChanged(object sender, EventArgs e)
		{
			check(txtGiaTri1);
		}

		private void txtGiaTri2_TextChanged(object sender, EventArgs e)
		{
			check(txtGiaTri2);
		}

		private void txtGiaTri3_TextChanged(object sender, EventArgs e)
		{
			check(txtGiaTri3);
		}

		private void txtGiaTri4_TextChanged(object sender, EventArgs e)
		{
			check(txtGiaTri4);
		}

		private void txtGiaTri5_TextChanged(object sender, EventArgs e)
		{
			check(txtGiaTri5);
		}

		private void txtGiaTri6_TextChanged(object sender, EventArgs e)
		{
			check(txtGiaTri6);
		}


		private void btnTinh_Click(object sender, EventArgs e)
		{
			if (txtGiaTri1.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtGiaTri2.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtGiaTri3.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtGiaTri4.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtGiaTri5.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtGiaTri6.Text == "")
			{
				MessageBox.Show("Hãy điền vào ô trống 1 giá trị!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					cboPhepTinh.Enabled = false;
					btnTinh.Enabled = false;
					btnLamMoi.Enabled = true;
					txtGiaTri1.Enabled = false;
					txtGiaTri2.Enabled = false;
					txtGiaTri3.Enabled = false;
					txtGiaTri4.Enabled = false;
					txtGiaTri5.Enabled = false;
					txtGiaTri6.Enabled = false;

					double dblGiaTri1 = 0;
					double dblGiaTri2 = 0;
					double dblGiaTri3 = 0;
					double dblGiaTri4 = 0;
					double dblGiaTri5 = 0;
					double dblGiaTri6 = 0;

					dblGiaTri1 = lamtron(txtGiaTri1, dblGiaTri1);
					dblGiaTri2 = lamtron(txtGiaTri2, dblGiaTri2);
					dblGiaTri3 = lamtron(txtGiaTri3, dblGiaTri3);
					dblGiaTri4 = lamtron(txtGiaTri4, dblGiaTri4);
					dblGiaTri5 = lamtron(txtGiaTri5, dblGiaTri5);
					dblGiaTri6 = lamtron(txtGiaTri6, dblGiaTri6);

					double dblKetQua1 = (dblGiaTri1 * dblGiaTri3) + dblGiaTri2;
					double dblKetQua2 = (dblGiaTri4 * dblGiaTri6) + dblGiaTri5;
					double dblKetQua3 = 0;
					double dblKetQua4 = 0;
					double dblKetQua5 = 0;

					// Nếu là phép cộng
					if (dblGiaTri3 * dblGiaTri6 == 0)
					{
						cboPhepTinh.Enabled = true;
						btnTinh.Enabled = true;
						btnLamMoi.Enabled = true;
						txtGiaTri1.Enabled = true;
						txtGiaTri2.Enabled = true;
						txtGiaTri3.Enabled = true;
						txtGiaTri4.Enabled = true;
						txtGiaTri5.Enabled = true;
						txtGiaTri6.Enabled = true;
						MessageBox.Show("Mấu số phải khác 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						lblPhepTinh.Text = cboPhepTinh.Text;
						lblGiaTri1.Text = dblKetQua1.ToString();
						lblGiaTri3.Text = dblKetQua2.ToString();
						if (cboPhepTinh.Text == "+")
						{
							if (dblGiaTri3 == dblGiaTri6)
							{
								lblGiaTri2.Text = dblGiaTri3.ToString();
								lblGiaTri4.Text = dblGiaTri6.ToString();

								dblKetQua3 = dblKetQua1 + dblKetQua2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblGiaTri6.ToString();

								if (dblKetQua3 % dblGiaTri6 == 0)
								{
									dblKetQua4 = dblKetQua3 / dblGiaTri6;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblGiaTri3;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblGiaTri3.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblGiaTri3;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblGiaTri3;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}

							if (dblGiaTri3 % dblGiaTri6 == 0)
							{
								lblGiaTri2.Text = dblGiaTri3.ToString();

								double dblQuyDongMauSo = dblGiaTri3 / dblGiaTri6;
								double dblMauSoChung = dblGiaTri6 * dblQuyDongMauSo;
								lblGiaTri4.Text = dblMauSoChung.ToString();
								double dblTuSo2 = dblKetQua2 * dblQuyDongMauSo;
								lblGiaTri3.Text = dblTuSo2.ToString();

								dblKetQua3 = dblKetQua1 + dblTuSo2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblGiaTri3.ToString();

								if (dblKetQua3 % dblGiaTri3 == 0)
								{
									dblKetQua4 = dblKetQua3 / dblGiaTri3;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblGiaTri3;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblGiaTri3.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblGiaTri3;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblGiaTri3;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}


							if (dblGiaTri6 % dblGiaTri3 == 0)
							{
								lblGiaTri4.Text = dblGiaTri6.ToString();

								double dblQuyDongMauSo = dblGiaTri6 / dblGiaTri3;
								double dblMauSoChung = dblGiaTri3 * dblQuyDongMauSo;
								lblGiaTri2.Text = dblMauSoChung.ToString();
								double dblTuSo1 = dblKetQua1 * dblQuyDongMauSo;
								lblGiaTri1.Text = dblTuSo1.ToString();

								dblKetQua3 = dblTuSo1 + dblKetQua2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblGiaTri6.ToString();

								if (dblKetQua3 % dblGiaTri6 == 0)
								{
									dblKetQua4 = dblKetQua3 / dblGiaTri6;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblGiaTri6;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblGiaTri6.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblGiaTri6;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblGiaTri6;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}


							if (dblGiaTri6 % dblGiaTri3 != 0 && dblGiaTri3 % dblGiaTri6 != 0)
							{
								double dblMauSoChung = dblGiaTri3 * dblGiaTri6;
								lblGiaTri2.Text = dblMauSoChung.ToString();
								lblGiaTri4.Text = dblMauSoChung.ToString();

								double dblTuSo1 = dblKetQua1 * dblGiaTri6;
								double dblTuSo2 = dblKetQua2 * dblGiaTri3;

								lblGiaTri1.Text = dblTuSo1.ToString();
								lblGiaTri3.Text = dblTuSo2.ToString();

								dblKetQua3 = dblTuSo1 + dblTuSo2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblMauSoChung.ToString();

								if (dblKetQua3 % dblMauSoChung == 0)
								{
									dblKetQua4 = dblKetQua3 / dblMauSoChung;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblMauSoChung;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblMauSoChung.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblMauSoChung;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblMauSoChung;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}
						}



						// Nếu là phép trừ
						if (cboPhepTinh.Text == "-")
						{
							if (dblGiaTri3 == dblGiaTri6)
							{
								lblGiaTri2.Text = dblGiaTri3.ToString();
								lblGiaTri4.Text = dblGiaTri6.ToString();

								dblKetQua3 = dblKetQua1 - dblKetQua2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblGiaTri6.ToString();

								if (dblKetQua3 % dblGiaTri6 == 0)
								{
									dblKetQua4 = dblKetQua3 / dblGiaTri6;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblGiaTri3;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblGiaTri3.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblGiaTri3;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblGiaTri3;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}

							if (dblGiaTri3 % dblGiaTri6 == 0)
							{
								lblGiaTri2.Text = dblGiaTri3.ToString();

								double dblQuyDongMauSo = dblGiaTri3 / dblGiaTri6;
								double dblMauSoChung = dblGiaTri6 * dblQuyDongMauSo;
								lblGiaTri4.Text = dblMauSoChung.ToString();
								double dblTuSo2 = dblKetQua2 * dblQuyDongMauSo;
								lblGiaTri3.Text = dblTuSo2.ToString();

								dblKetQua3 = dblKetQua1 - dblTuSo2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblGiaTri3.ToString();

								if (dblKetQua3 % dblGiaTri3 == 0)
								{
									dblKetQua4 = dblKetQua3 / dblGiaTri3;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblGiaTri3;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblGiaTri3.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblGiaTri3;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblGiaTri3;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}


							if (dblGiaTri6 % dblGiaTri3 == 0)
							{
								lblGiaTri4.Text = dblGiaTri6.ToString();

								double dblQuyDongMauSo = dblGiaTri6 / dblGiaTri3;
								double dblMauSoChung = dblGiaTri3 * dblQuyDongMauSo;
								lblGiaTri2.Text = dblMauSoChung.ToString();
								double dblTuSo1 = dblKetQua1 * dblQuyDongMauSo;
								lblGiaTri1.Text = dblTuSo1.ToString();

								dblKetQua3 = dblTuSo1 - dblKetQua2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblGiaTri6.ToString();

								if (dblKetQua3 % dblGiaTri6 == 0)
								{
									dblKetQua4 = dblKetQua3 / dblGiaTri6;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblGiaTri6;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblGiaTri6.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblGiaTri6;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblGiaTri6;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}


							if (dblGiaTri6 % dblGiaTri3 != 0 && dblGiaTri3 % dblGiaTri6 != 0)
							{
								double dblMauSoChung = dblGiaTri3 * dblGiaTri6;
								lblGiaTri2.Text = dblMauSoChung.ToString();
								lblGiaTri4.Text = dblMauSoChung.ToString();

								double dblTuSo1 = dblKetQua1 * dblGiaTri6;
								double dblTuSo2 = dblKetQua2 * dblGiaTri3;

								lblGiaTri1.Text = dblTuSo1.ToString();
								lblGiaTri3.Text = dblTuSo2.ToString();

								dblKetQua3 = dblTuSo1 - dblTuSo2;
								lblGiaTri5.Text = dblKetQua3.ToString();
								lblGiaTri6.Text = dblMauSoChung.ToString();

								if (dblKetQua3 % dblMauSoChung == 0)
								{
									dblKetQua4 = dblKetQua3 / dblMauSoChung;
									lblGiaTri10.Text = dblKetQua4.ToString();
									lblGiaTri7.Text = "";
									lblGiaTri8.Text = "";
									lblGiaTri9.Text = "";
								}
								else
								{
									double dblSoDu = dblKetQua3 % dblMauSoChung;
									lblGiaTri8.Text = dblSoDu.ToString();
									lblGiaTri9.Text = dblMauSoChung.ToString();

									dblKetQua5 = dblKetQua3 - dblSoDu;
									double dblSoChiaHet = dblKetQua5 / dblMauSoChung;
									lblGiaTri7.Text = dblSoChiaHet.ToString();

									dblKetQua4 = dblKetQua3 / dblMauSoChung;
									lblGiaTri10.Text = dblKetQua4.ToString();

								}
							}
						}



						// Nếu là phép nhân
						if (cboPhepTinh.Text == "x")
						{
							lblGiaTri1.Text = dblKetQua1.ToString();
							lblGiaTri2.Text = dblGiaTri3.ToString();
							lblGiaTri3.Text = dblKetQua2.ToString();
							lblGiaTri4.Text = dblGiaTri6.ToString();
							dblKetQua3 = dblKetQua1 * dblKetQua2;
							double dblMauSoChung = dblGiaTri3 * dblGiaTri6;
							lblGiaTri5.Text = dblKetQua3.ToString();
							lblGiaTri6.Text = dblMauSoChung.ToString();

							if (dblKetQua3 % dblMauSoChung == 0)
							{
								dblKetQua4 = dblKetQua3 / dblMauSoChung;
								lblGiaTri10.Text = dblKetQua4.ToString();
								lblGiaTri7.Text = "";
								lblGiaTri8.Text = "";
								lblGiaTri9.Text = "";
							}
							else
							{
								double dblSoDu = dblKetQua3 % dblMauSoChung;
								lblGiaTri8.Text = dblSoDu.ToString();
								lblGiaTri9.Text = dblMauSoChung.ToString();

								dblKetQua5 = dblKetQua3 - dblSoDu;
								double dblSoChiaHet = dblKetQua5 / dblMauSoChung;
								lblGiaTri7.Text = dblSoChiaHet.ToString();

								dblKetQua4 = dblKetQua3 / dblMauSoChung;
								lblGiaTri10.Text = dblKetQua4.ToString();
							}
						}


						// Nếu là phép chia
						if (cboPhepTinh.Text == "/")
						{
							lblGiaTri1.Text = dblKetQua1.ToString();
							lblGiaTri2.Text = dblGiaTri3.ToString();
							lblGiaTri3.Text = dblKetQua2.ToString();
							lblGiaTri4.Text = dblGiaTri6.ToString();

							dblKetQua3 = dblKetQua1 * dblGiaTri6;
							double dblMauSoChung = dblGiaTri3 * dblKetQua2;
							lblGiaTri5.Text = dblKetQua3.ToString();
							lblGiaTri6.Text = dblMauSoChung.ToString();

							if (dblKetQua3 % dblMauSoChung == 0)
							{
								dblKetQua4 = dblKetQua3 / dblMauSoChung;
								lblGiaTri10.Text = dblKetQua4.ToString();
								lblGiaTri7.Text = "";
								lblGiaTri8.Text = "";
								lblGiaTri9.Text = "";
							}
							else
							{
								double dblSoDu = dblKetQua3 % dblMauSoChung;
								lblGiaTri8.Text = dblSoDu.ToString();
								lblGiaTri9.Text = dblMauSoChung.ToString();

								dblKetQua5 = dblKetQua3 - dblSoDu;
								double dblSoChiaHet = dblKetQua5 / dblMauSoChung;
								lblGiaTri7.Text = dblSoChiaHet.ToString();

								dblKetQua4 = dblKetQua3 / dblMauSoChung;
								lblGiaTri10.Text = dblKetQua4.ToString();
							}
						}
					}
				}
				catch 
				{
					cboPhepTinh.Enabled = true;
					btnTinh.Enabled = true;
					btnLamMoi.Enabled = true;
					txtGiaTri1.Enabled = true;
					txtGiaTri2.Enabled = true;
					txtGiaTri3.Enabled = true;
					txtGiaTri4.Enabled = true;
					txtGiaTri5.Enabled = true;
					txtGiaTri6.Enabled = true;
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtGiaTri1.Enabled == true)
			{
				txtGiaTri1.Text = "";
				txtGiaTri2.Text = "";
				txtGiaTri3.Text = "";
				txtGiaTri4.Text = "";
				txtGiaTri5.Text = "";
				txtGiaTri6.Text = "";
			}

			if ((txtGiaTri1.Text == "") && (txtGiaTri2.Text == "") && (txtGiaTri3.Text == "") && (txtGiaTri4.Text == "") && (txtGiaTri5.Text == "") && (txtGiaTri6.Text == ""))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			cboPhepTinh.Enabled = true;
			btnTinh.Enabled = true;
			txtGiaTri1.Enabled = true;
			txtGiaTri2.Enabled = true;
			txtGiaTri3.Enabled = true;
			txtGiaTri4.Enabled = true;
			txtGiaTri5.Enabled = true;
			txtGiaTri6.Enabled = true;

			lblGiaTri1.Text = "";
			lblGiaTri2.Text = "";
			lblGiaTri3.Text = "";
			lblGiaTri4.Text = "";
			lblGiaTri5.Text = "";
			lblGiaTri6.Text = "";
			lblGiaTri7.Text = "";
			lblGiaTri8.Text = "";
			lblGiaTri9.Text = "";
			lblGiaTri10.Text = "";
			lblPhepTinh.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
