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
	public partial class frmPTB3 : Form
	{

		public frmPTB3()
		{
			InitializeComponent();
		}

		private void frmPTB3_Load(object sender, EventArgs e)
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
			if ((txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0") && (txtD.Text == "0"))
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
			else if (txtD.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị d!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					txtA.Enabled = false;
					txtB.Enabled = false;
					txtC.Enabled = false;
					txtD.Enabled = false;
					btnGiai.Enabled = false;
					btnLamMoi.Enabled = true;

					double dblGiaTriA = 0;
					double dblGiaTriB = 0;
					double dblGiaTriC = 0;
					double dblGiaTriD = 0;

					dblGiaTriA = lamtron(txtA, dblGiaTriA);
					dblGiaTriB = lamtron(txtB, dblGiaTriB);
					dblGiaTriC = lamtron(txtC, dblGiaTriC);
					dblGiaTriD = lamtron(txtD, dblGiaTriD);
					txtA.Text = dblGiaTriA.ToString();
					txtB.Text = dblGiaTriB.ToString();
					txtC.Text = dblGiaTriC.ToString();
					txtD.Text = dblGiaTriD.ToString();
					double dblGiaTriX1 = 0;
					double dblGiaTriX2 = 0;
					double dblGiaTriX3 = 0;

					if (dblGiaTriA == 0)
					{
						if (dblGiaTriB == 0)
						{
							if (dblGiaTriC == 0)
							{
								if (dblGiaTriD == 0)
								{
									txtKQ.Text = "Phương trình đã cho có vô số nghiệm";
								}
								else if (dblGiaTriD != 0)
								{
									txtKQ.Text = "Phương trình vô nghiệm";
								}
							}
							else if (dblGiaTriC != 0)
							{
								double fNghiem = -dblGiaTriD / dblGiaTriC;
								txtKQ.Text = "Phương trình đã cho có một nghiệm";
								txtX1.Text = "x = " + fNghiem.ToString();
							}
						}
						else if (dblGiaTriB != 0)
						{
							double fD = dblGiaTriC * dblGiaTriC - 4 * dblGiaTriB * dblGiaTriD;
							if (fD < 0)
							{
								txtKQ.Text = "Phương trình vô nghiệm";
								txtX1.Text = "";
							}
							else if (fD == 0)
							{
								double fNghiem = -dblGiaTriC / (2 * dblGiaTriB);
								txtKQ.Text = "Phương trình có nghiệm kép:";
								txtX1.Text = "x1 = x2 = " + fNghiem.ToString();
							}
							else
							{
								double fNghiem1 = (-dblGiaTriC + Math.Sqrt(fD)) / (2 * dblGiaTriB);
								double fNghiem2 = (-dblGiaTriC - Math.Sqrt(fD)) / (2 * dblGiaTriB);
								txtKQ.Text = "Phương trình có hai nghiệm:";
								txtX1.Text = "x1 = " + fNghiem1.ToString();
								txtX2.Text = "x2 = " + fNghiem2.ToString();
							}
						}
					}
					else
					{

						// Tìm biến số f
						// f = [(3c/a) - (b²/a²)] / 3
						double dblF = (((3 * dblGiaTriC) / dblGiaTriA) - ((dblGiaTriB * dblGiaTriB) / (dblGiaTriA * dblGiaTriA))) / 3;

						// Tìm biến số g
						// g = [(2b³/a³) - (9bc/a²) + (27d/a)] / 27
						double dblG = (((2 * dblGiaTriB * dblGiaTriB * dblGiaTriB) / (dblGiaTriA * dblGiaTriA * dblGiaTriA)) - ((9 * dblGiaTriB * dblGiaTriC) / (dblGiaTriA * dblGiaTriA)) + ((27 * dblGiaTriD) / dblGiaTriA)) / 27;

						// Tìm biến số h
						// h = (g²/4) + (f³/27)
						double dblH = ((dblG * dblG) / 4) + ((dblF * dblF * dblF) / 27);


						// Nếu h > 0, phương trình chỉ có duy nhất 1 nghiệm thực
						if (dblH > 0)
						{
							// Tìm giá trị R
							// R = -(g/2) + (h)½
							double dblHMu1Phan2 = Math.Sqrt(dblH);
							double dblR = -(dblG / 2) + dblHMu1Phan2;

							// Vì không thể tính được Căn Bậc 3 của một số âm nên chúng ta sẽ sử dụng giá trị e
							double dblE = 1;
							if (dblR < 0)
							{
								dblE = -1;
							}
							else
							{
								dblE = 1;
							}
							double dblRMu1Phan3 = Math.Pow(dblR * dblE, 0.33333333333333333333333333333333);
							dblRMu1Phan3 = dblRMu1Phan3 * dblE;

							// Tìm giá trị S
							// S = (R)^(1/3)
							double dblS = dblRMu1Phan3;

							// Tìm giá trị T
							// T = -(g/2) - (h)½
							double dblT = -(dblG / 2) - dblHMu1Phan2;
							if (dblT < 0)
							{
								dblE = -1;
							}
							else
							{
								dblE = 1;
							}
							double dblTMu1Phan3 = Math.Pow(dblT * dblE, 0.33333333333333333333333333333333);
							dblTMu1Phan3 = dblTMu1Phan3 * dblE;

							// Tìm giá trị U
							// U = (T)^(1/3)
							double dblU = dblTMu1Phan3;


							// Tính giá trị X1
							// X1 = (S + U) - (b/3a)
							dblGiaTriX1 = (dblS + dblU) - (dblGiaTriB / (3 * dblGiaTriA));
							dblGiaTriX1 = Math.Round(dblGiaTriX1, 8);

							// Tính giá trị X2
							// X2 = -(S + U)/2 - (b/3a) + i*(S-U)*(3)½/2
							double dbl3Mu1Phan2 = Math.Pow(3, 0.5);
							double dblVeTraiX2 = -(dblS + dblU) / 2 - (dblGiaTriB / (3 * dblGiaTriA));
							double dblVePhaiX2 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;


							// Tính giá trị X3
							// X3 = -(S + U)/2 - (b/3a) - i*(S-U)*(3)½/2
							double dblVeTraiX3 = -(dblS + dblU) / 2 - (dblGiaTriB / (3 * dblGiaTriA));
							double dblVePhaiX3 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;


							// Hiển thị giá trị các nghiệm
							txtKQ.Text = "Phương trình có 3 nghiệm phân biệt";
							txtX1.Text = "x1 = " + dblGiaTriX1.ToString();
							txtX2.Text = "x2 = " + dblVeTraiX2.ToString() + " + " + dblVePhaiX2.ToString() + "*i";
							txtX3.Text = "x3 = " + dblVeTraiX3.ToString() + " - " + dblVePhaiX3.ToString() + "*i";

						}



						// Trong trường hợp đặc biệt khi mà f = 0, g = 0 và h = 0 thì tất cả 3 nghiệm là thực và bằng nhau
						// X1 = X2 = X3= (d/a)^(1/3) * (-1)
						else if (dblF == 0 && dblG == 0 && dblH == 0)
						{
							//double dblS = 1;
							double dblDTrenAMu1Phan3 = 0;
							double dblDTrenA = dblGiaTriD / dblGiaTriA;
							dblDTrenAMu1Phan3 = Math.Pow(Math.Abs(dblDTrenA), 0.33333333333333333333333333333333);
							if (dblDTrenA < 0)
							{
								dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * 1;
							}
							if (dblDTrenA > 0)
							{
								dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * (-1);
							}



							// Tính giá trị X1
							dblGiaTriX1 = Math.Round(dblDTrenAMu1Phan3, 8);

							// Tính giá trị X2
							dblGiaTriX2 = Math.Round(dblDTrenAMu1Phan3, 8);

							// Tính giá trị X3
							dblGiaTriX3 = Math.Round(dblDTrenAMu1Phan3, 8);

							// Hiển thị giá trị các nghiệm
							txtX1.Text = "Phương trình có nghiệm bội ba x = " + dblGiaTriX1.ToString();
						}




						// Khi h <= 0, thì tất cả 3 nghiệm là thực
						else if (dblH <= 0)
						{
							// Tìm biến số i
							// i = ((g²/4) - h) ½ 
							double dblS = 1;
							double dblBieuThuc = (dblG * dblG) / 4 - dblH;
							double dblI = Math.Pow(dblBieuThuc, 0.5);
							if (dblI < 0)
							{
								dblS = -1;
							}
							if (dblI > 0)
							{
								dblS = 1;
							}
							dblI = Math.Pow(dblBieuThuc * dblS, 0.5);
							dblI = dblI * dblS;



							// Tìm biến số j
							// j = (i)^(1/3)
							double dblJ = Math.Pow(dblI, 0.33333333333333333333333333333333);
							if (dblJ < 0)
							{
								dblS = -1;
							}
							if (dblJ > 0)
							{
								dblS = 1;
							}
							dblJ = Math.Pow(dblI * dblS, 0.33333333333333333333333333333333);
							dblJ = dblJ * dblS;

							// Tìm biến số k
							// k = arc cosine (- (g / 2i)) 
							double dblGTren2i = -(dblG / (2 * dblI));
							double dblK = Math.Acos(dblGTren2i);

							// Tìm giá trị của L
							// L = j * (-1)
							double dblL = dblJ * (-1);

							// Tìm giá trị của M
							// M = cosine (K/3)
							double dblKTren3 = dblK / 3;
							double dblM = Math.Cos(dblKTren3);


							// Tìm giá trị của N
							// N = (Căn bậc 2 của 3) * sine (K/3)
							double dblCanBac2Cua3 = Math.Sqrt(3);
							double dblSinCuaKTren3 = Math.Sin(dblKTren3);
							double dblN = dblCanBac2Cua3 * dblSinCuaKTren3;


							// Tìm giá trị của P
							// P = (b/3a) * (-1)
							double dblP = (dblGiaTriB / (3 * dblGiaTriA)) * (-1);

							// Tính giá trị X1
							// X1 = 2j * cosine(k/3) - (b/3a)
							double dblCosinCuaKTren3 = Math.Cos(dblKTren3);
							double dblX1 = 2 * dblJ * dblCosinCuaKTren3 - (dblGiaTriB / (3 * dblGiaTriA));
							dblGiaTriX1 = Math.Round(dblX1, 8);

							// Tính giá trị X2
							// X2 = L * (M + N) + P
							dblGiaTriX2 = (dblL * (dblM + dblN)) + dblP;
							dblGiaTriX2 = Math.Round(dblGiaTriX2, 8);

							// Tính giá trị X3
							// X3 = L * (M - N) + P
							dblGiaTriX3 = (dblL * (dblM - dblN)) + dblP;
							dblGiaTriX3 = Math.Round(dblGiaTriX3, 8);

							// Hiển thị giá trị các nghiệm
							txtKQ.Text = "Phương trình có 3 nghiệm phân biệt";
							txtX1.Text = "x1 = " + dblGiaTriX1.ToString();
							txtX2.Text = "x2 = " + dblGiaTriX2.ToString();
							txtX3.Text = "x3 = " + dblGiaTriX3.ToString();

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
					txtD.Enabled = true;
					txtKQ.Text = "";
					txtX1.Text = "";
					txtX2.Text = "";
					txtX3.Text = "";
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
				txtD.Text = "0";
			}

			if ((txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0") && (txtD.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			btnGiai.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = true;
			txtKQ.Text = "";
			txtX1.Text = "";
			txtX2.Text = "";
			txtX3.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
