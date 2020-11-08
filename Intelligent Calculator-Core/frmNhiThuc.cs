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
	public partial class frmNhiThuc : Form
	{
		public frmNhiThuc()
		{
			InitializeComponent();
		}

		private void frmNhiThuc_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
			txtN.Enabled = false;
			txtA.Enabled = false;
			txtB.Enabled = false;
			txtC.Enabled = false;
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
			if ((rdNT2.Checked || rdNT1.Checked) && txtA.Text == "0" && txtB.Text == "0" && txtN.Text == "0" && txtSoMu.Text == "0")
			{
				btnLamMoi.Enabled = false;
			}
			else if (rdNT3.Checked && txtA.Text == "0" && txtB.Text == "0" && txtC.Text == "0" && txtN.Text == "0" && txtSoMu.Text == "0")
			{
				btnLamMoi.Enabled = false;
			}
			else
			{
				btnLamMoi.Enabled = true;
			}
		}

		private void txtN_TextChanged(object sender, EventArgs e)
		{
			check(txtN);
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

		private void txtSoMu_TextChanged(object sender, EventArgs e)
		{
			check(txtSoMu);
		}

		private void txtN_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtN.Text == "0")
			{
				txtN.Text = "";
			}
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

		private void txtC_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC.Text == "0")
			{
				txtC.Text = "";
			}
		}
		private void txtSoMu_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtSoMu.Text == "0")
			{
				txtSoMu.Text = "";
			}
		}

		private void rdNT1_CheckedChanged(object sender, EventArgs e)
		{
			txtN.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = false;
			txtC.Text = "0";
			txtKQ.Text = "";
		}

		private void rdNT2_CheckedChanged(object sender, EventArgs e)
		{
			txtN.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = false;
			txtC.Text = "0";
			txtKQ.Text = "";
		}

		private void rdNT3_CheckedChanged(object sender, EventArgs e)
		{
			txtN.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtKQ.Text = "";
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (txtA.Text == "") //Nhập a trống
			{
				MessageBox.Show("Bạn chưa nhập giá trị a!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtB.Text == "") //Nhập b trống
			{
				MessageBox.Show("Bạn chưa nhập giá trị b!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtN.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị n!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtSoMu.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập số mũ của số hạng x cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (rdNT3.Enabled && txtC.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				if (rdNT1.Checked == true)
				{
					try
					{
						txtA.Enabled = false;
						txtB.Enabled = false;
						txtC.Enabled = false;
						txtN.Enabled = false;
						txtSoMu.Enabled = false;
						btnLamMoi.Enabled = true;
						btnTim.Enabled = false;

						double A = 0;
						double B = 0;
						double N = 0;
						double Mu = 0;

						A = lamtron(txtA, A);
						B = lamtron(txtB, B);
						N = lamtron(txtN, N);
						Mu = lamtron(txtSoMu, Mu);

						txtA.Text = A.ToString();
						txtB.Text = B.ToString();
						txtN.Text = N.ToString();
						txtSoMu.Text = Mu.ToString();

						if (A == 0 || N == 0 || N % 1 != 0)
						{
							MessageBox.Show("Vui lòng nhập a, n khác 0, n là số nguyên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							double K = N - Mu / A;
							if (K % 1 != 0 | K < 0 | K > N)
							{
								txtKQ.Text = "Không tồn tại hệ số chứa x^" + Mu.ToString();
							}
							else
							{
								int Ngiaithua = 1;
								int Kgiaithua = 1;
								int NtruKgiaithua = 1;
								int i = 1;
								int j = 1;
								int k = 1;
								for (i = 1; i <= N; i++)
								{
									Ngiaithua = Ngiaithua * i;
								}
								for (j = 1; j <= K; j++)
								{
									Kgiaithua = Kgiaithua * j;
								}
								for (k = 1; k <= (N - K); k++)
								{
									NtruKgiaithua = NtruKgiaithua * k;
								}
								double BmuK = Math.Pow(B, K);
								double H = ((Ngiaithua) / (Kgiaithua * NtruKgiaithua)) * BmuK;
								txtKQ.Text = "Hệ số cần tìm là : " + H.ToString();
							}
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Bạn nhập các giá trị chưa hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (rdNT2.Checked == true)
				{
					try
					{
						txtA.Enabled = false;
						txtB.Enabled = false;
						txtC.Enabled = false;
						txtN.Enabled = false;
						txtSoMu.Enabled = false;
						btnLamMoi.Enabled = true;
						btnTim.Enabled = false;

						double A = 0;
						double B = 0;
						double N = 0;
						double Mu = 0;

						A = lamtron(txtA, A);
						B = lamtron(txtB, B);
						N = lamtron(txtN, N);
						Mu = lamtron(txtSoMu, Mu);

						txtA.Text = A.ToString();
						txtB.Text = B.ToString();
						txtN.Text = N.ToString();
						txtSoMu.Text = Mu.ToString();

						if (A == 0 | N == 0 | B == 0)
						{
							MessageBox.Show("Vui lòng nhập a, b, n khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							if (A == B)
							{
								if (Mu == A * N)
								{
									double H = Math.Pow(2, N);
									txtKQ.Text = "Hệ số cần tìm là : " + H.ToString();
								}
								else
								{
									txtKQ.Text = "Không tồn tại hệ số chứa x^" + Mu.ToString();
								}
							}
							else
							{
								double K = (A * N - Mu) / (A - B);
								if (K % 1 != 0)
								{
									txtKQ.Text = "Không tồn tại hệ số chứa x^" + Mu.ToString();
								}
								else
								{
									int Ngiaithua = 1;
									int Kgiaithua = 1;
									int NtruKgiaithua = 1;
									int i = 1;
									int j = 1;
									int k = 1;
									for (i = 1; i <= N; i++)
									{
										Ngiaithua = Ngiaithua * i;
									}
									for (j = 1; j <= K; j++)
									{
										Kgiaithua = Kgiaithua * j;
									}
									for (k = 1; k <= (N - K); k++)
									{
										NtruKgiaithua = NtruKgiaithua * k;
									}
									double H = ((Ngiaithua) / (Kgiaithua * NtruKgiaithua));
									txtKQ.Text = "Hệ số cần tìm là : " + H.ToString();
								}
							}
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Bạn nhập các giá trị chưa hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				if (rdNT3.Checked == true)
				{
					try
					{
						txtA.Enabled = false;
						txtB.Enabled = false;
						txtC.Enabled = false;
						txtN.Enabled = false;
						txtSoMu.Enabled = false;
						btnLamMoi.Enabled = true;
						btnTim.Enabled = false;

						double A = 0;
						double B = 0;
						double C = 0;
						double N = 0;
						double Mu = 0;

						A = lamtron(txtA, A);
						B = lamtron(txtB, B);
						C = lamtron(txtC, C);
						N = lamtron(txtN, N);
						Mu = lamtron(txtSoMu, Mu);

						txtA.Text = A.ToString();
						txtB.Text = B.ToString();
						txtC.Text = C.ToString();
						txtN.Text = N.ToString();
						txtSoMu.Text = Mu.ToString();

						if (A > B)
						{
							if (Mu > A * N)
							{
								txtKQ.Text = "Không tồn tại hệ số chứa x^" + Mu.ToString();
							}
							if (Mu == A * N)
							{
								txtKQ.Text = "Hệ số cần tìm là : " + (A * N).ToString();
							}
						}
						if (A < B)
						{
							if (Mu > B * N)
							{
								txtKQ.Text = "Không tồn tại hệ số chứa x^" + Mu.ToString();
							}
							if (Mu == B * N)
							{
								txtKQ.Text = "Hệ số cần tìm là : " + (B * N).ToString();
							}
						}
						if (A * B * N * C == 0)
						{
							MessageBox.Show("Vui lòng nhập lại các số a,b,c,n (các hệ số phải khác 0)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							int K = 0;
							int i = 0;
							double H = 0;
							for (K = 0; K <= N; K++)
							{
								for (i = 0; i <= K; i++)
								{
									if ((A * K + i * (B - A)) == Mu)
									{
										int Ngiaithua = 1;
										int Kgiaithua = 1;
										int NtruKgiaithua = 1;
										int iGiaithua = 1;
										int KtruiGiaithua = 1;
										int m = 1;
										int n = 1;
										int p = 1;
										int q = 1;
										int r = 1;
										for (m = 1; m <= N; m++)
										{
											Ngiaithua = Ngiaithua * m;
										}
										for (n = 1; n <= K; n++)
										{
											Kgiaithua = Kgiaithua * n;
										}
										for (p = 1; p <= (N - K); p++)
										{
											NtruKgiaithua = NtruKgiaithua * p;
										}
										for (q = 1; q <= i; q++)
										{
											iGiaithua = iGiaithua * q;
										}
										for (r = 1; r <= (K - i); r++)
										{
											KtruiGiaithua = KtruiGiaithua * r;
										}
										double nCk = Ngiaithua / (Kgiaithua * NtruKgiaithua);
										double kCi = Kgiaithua / (iGiaithua * KtruiGiaithua);
										H = H + nCk * kCi * Math.Pow(C, N - K);
									}
								}
							}
							txtKQ.Text = "Hệ số cần tìm là : " + H.ToString();
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Bạn nhập các giá trị chưa hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if(txtA.Enabled && !rdNT3.Checked)
			{
				txtA.Text = "0";
				txtB.Text = "0";
				txtN.Text = "0";
				txtSoMu.Text = "0";
			}
			else if(txtA.Enabled && rdNT3.Checked)
			{
				txtA.Text = "0";
				txtB.Text = "0";
				txtC.Text = "0";
				txtN.Text = "0";
				txtSoMu.Text = "0";
			}
			if ((rdNT2.Checked || rdNT1.Checked) && txtA.Text == "0" && txtB.Text == "0" && txtN.Text == "0" && txtSoMu.Text == "0")
			{
				btnLamMoi.Enabled = false;
			}
			else if (rdNT3.Checked && txtA.Text == "0" && txtB.Text == "0" && txtC.Text == "0" && txtN.Text == "0" && txtSoMu.Text == "0")
			{
				btnLamMoi.Enabled = false;
			}
			else
			{
				btnLamMoi.Enabled = true;
			}

			btnTim.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtSoMu.Enabled = true;
			txtN.Enabled = true;
			if (rdNT3.Checked)
				txtC.Enabled = true;
			txtKQ.Text = "";

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
