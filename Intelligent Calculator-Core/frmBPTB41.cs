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
	public partial class frmBPTB41 : Form
	{
		public frmBPTB41()
		{
			InitializeComponent();
		}

		private void frmBPTB41_Load(object sender, EventArgs e)
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
			if ((txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0") && (txtD.Text == "0") && (txtE.Text == "0"))
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

		private void txtE_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtE.Text == "0")
				txtE.Text = "";
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
			else if (txtE.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị e!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					txtA.Enabled = false;
					txtB.Enabled = false;
					txtC.Enabled = false;
					txtD.Enabled = false;
					txtE.Enabled = false;
					btnGiai.Enabled = false;
					btnLamMoi.Enabled = true;

					double dblA = 0;
					double dblB = 0;
					double dblC = 0;
					double dblD = 0;
					double dblE = 0;

					dblA = lamtron(txtA, dblA);
					dblB = lamtron(txtB, dblB);
					dblC = lamtron(txtC, dblC);
					dblD = lamtron(txtD, dblD);
					dblE = lamtron(txtE, dblE);

					txtA.Text = dblA.ToString();
					txtB.Text = dblB.ToString();
					txtC.Text = dblC.ToString();
					txtD.Text = dblD.ToString();
					txtE.Text = dblE.ToString();

					if (dblA == 0)
					{
						MessageBox.Show("Bạn vui lòng nhập hệ số a khác 0, nếu hệ số a = 0 vui lòng sử dụng chức năng giải bất phương trình bậc 3", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (dblA > 0)
					{

						dblB = dblB / dblA;
						dblC = dblC / dblA;
						dblD = dblD / dblA;
						dblE = dblE / dblA;
						dblA = 1;
						double m = -8;
						double n = 4 * dblC;
						double p = 8 * dblE - 2 * dblB * dblD;
						double q = dblB * dblB * dblE - 4 * dblC * dblE + dblD * dblD;
						double dblGiaTriX1 = 0;
						double dblGiaTriX2 = 0;
						double dblGiaTriX3 = 0;
						if (q == 0)
						{
							dblGiaTriX1 = 0;
						}
						else
						{

							// Tìm biến số f
							// f = [(3c/a) - (b²/a²)] / 3
							double dblF = (((3 * p) / m) - ((n * n) / (m * m))) / 3;

							// Tìm biến số g
							// g = [(2b³/a³) - (9bc/a²) + (27d/a)] / 27
							double dblG = (((2 * n * n * n) / (m * m * m)) - ((9 * n * p) / (m * m)) + ((27 * q) / m)) / 27;

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
								double dble = 1;
								if (dblR < 0)
								{
									dble = -1;
								}
								else
								{
									dble = 1;
								}
								double dblRMu1Phan3 = Math.Pow(dblR * dble, 0.33333333333333333333333333333333);
								dblRMu1Phan3 = dblRMu1Phan3 * dble;

								// Tìm giá trị S
								// S = (R)^(1/3)
								double dblS = dblRMu1Phan3;

								// Tìm giá trị T
								// T = -(g/2) - (h)½
								double dblT = -(dblG / 2) - dblHMu1Phan2;
								if (dblT < 0)
								{
									dble = -1;
								}
								else
								{
									dble = 1;
								}
								double dblTMu1Phan3 = Math.Pow(dblT * dble, 0.33333333333333333333333333333333);
								dblTMu1Phan3 = dblTMu1Phan3 * dble;

								// Tìm giá trị U
								// U = (T)^(1/3)
								double dblU = dblTMu1Phan3;


								// Tính giá trị X1
								// X1 = (S + U) - (b/3a)
								dblGiaTriX1 = (dblS + dblU) - (n / (3 * m));

								// Tính giá trị X2
								// X2 = -(S + U)/2 - (b/3a) + i*(S-U)*(3)½/2
								double dbl3Mu1Phan2 = Math.Pow(3, 0.5);
								double dblVeTraiX2 = -(dblS + dblU) / 2 - (n / (3 * m));
								double dblVePhaiX2 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;

								// Tính giá trị X3
								// X3 = -(S + U)/2 - (b/3a) - i*(S-U)*(3)½/2
								double dblVeTraiX3 = -(dblS + dblU) / 2 - (n / (3 * m));
								double dblVePhaiX3 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;




							}



							// Trong trường hợp đặc biệt khi mà f = 0, g = 0 và h = 0 thì tất cả 3 nghiệm là thực và bằng nhau
							// X1 = X2 = X3= (d/a)^(1/3) * (-1)
							else if (dblF == 0 && dblG == 0 && dblH == 0)
							{
								//double dblS = 1;
								double dblDTrenAMu1Phan3 = 0;
								double dblDTrenA = q / m;
								dblDTrenAMu1Phan3 = Math.Pow(Math.Abs(dblDTrenA), 0.33333333333333333333333333333333);

								if (dblDTrenA < 0)
								{
									dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * 1;
								}
								else if (dblDTrenA > 0)
								{
									dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * (-1);
								}



								// Tính giá trị X1
								dblGiaTriX1 = dblDTrenAMu1Phan3;

								// Tính giá trị X2
								dblGiaTriX2 = dblDTrenAMu1Phan3;

								// Tính giá trị X3
								dblGiaTriX3 = dblDTrenAMu1Phan3;



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
								double dblP = (n / (3 * m)) * (-1);

								// Tính giá trị X1
								// X1 = 2j * cosine(k/3) - (b/3a)
								double dblCosinCuaKTren3 = Math.Cos(dblKTren3);
								double dblX1 = 2 * dblJ * dblCosinCuaKTren3 - (n / (3 * m));
								dblGiaTriX1 = dblX1;

								// Tính giá trị X2
								// X2 = L * (M + N) + P
								dblGiaTriX2 = (dblL * (dblM + dblN)) + dblP;

								// Tính giá trị X3
								// X3 = L * (M - N) + P
								dblGiaTriX3 = (dblL * (dblM - dblN)) + dblP;



							}

						}

						if (2 * dblGiaTriX1 < (dblC - dblB * dblB / 4))
						{

							double X = (dblD - dblB * dblGiaTriX1) / (dblB * dblB / 2 + 4 * dblGiaTriX1 - 2 * dblC);
							if (X * X + dblB * X / 2 + dblGiaTriX1 == 0)
							{
								txtKQ.Text = "Bất phương trình có nghiệm:";
								txtX1.Text = "x ≥ " + X.ToString();
							}
							else
							{
								txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
							}
						}
						else
						{
							if (dblB * dblGiaTriX1 / 2 - dblD < 0)
							{
								double fBienSo2 = (dblB / 2 - Math.Sqrt(Math.Round((dblB * dblB / 4 - dblC + dblGiaTriX1 * 2), 8)));
								double fBienSo3 = dblGiaTriX1 + Math.Sqrt(Math.Round((dblGiaTriX1 * dblGiaTriX1 - dblE), 8));
								double fBienSo5 = (dblB / 2 + Math.Sqrt(Math.Round((dblB * dblB / 4 - dblC + dblGiaTriX1 * 2), 8)));
								double fBienSo6 = dblGiaTriX1 - Math.Sqrt(Math.Round((dblGiaTriX1 * dblGiaTriX1 - dblE), 8));
								double Delta1 = Math.Pow(fBienSo2, 2) - 4 * fBienSo3;
								double Delta2 = Math.Pow(fBienSo5, 2) - 4 * fBienSo6;



								if (Delta1 < 0 && Delta2 < 0)
								{
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 < 0 && Delta2 == 0)
								{
									double x = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 < 0 && Delta2 > 0)
								{
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x3.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x4.ToString();
								}
								else if (Delta1 == 0 && Delta2 < 0)
								{
									double x12 = (-fBienSo2) / 2;
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 == 0 && Delta2 == 0)
								{
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 == 0 && Delta2 > 0)
								{
									double x12 = -fBienSo2 / 2;
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x3.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x4.ToString();
								}

								else if (Delta1 > 0 && Delta2 < 0)
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x2.ToString();
								}
								else if (Delta1 > 0 && Delta2 == 0)
								{
									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x34 = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x2.ToString();

								}
								else
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);

									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString() + "      hoặc";
									txtX2.Text = x2.ToString() + " ≤ x ≤ " + x3.ToString() + "      hoặc";
									txtX3.Text = "x ≤ " + x4.ToString();
								}
							}
							else
							{

								double fBienSo2 = (dblB / 2 - Math.Sqrt(Math.Round(dblB * dblB / 4 - dblC + dblGiaTriX1 * 2, 8)));
								double fBienSo3 = dblGiaTriX1 - Math.Sqrt(Math.Round(dblGiaTriX1 * dblGiaTriX1 - dblE, 8));
								double fBienSo5 = (dblB / 2 + Math.Sqrt(Math.Round(dblB * dblB / 4 - dblC + dblGiaTriX1 * 2, 8)));
								double fBienSo6 = dblGiaTriX1 + Math.Sqrt(Math.Round(dblGiaTriX1 * dblGiaTriX1 - dblE, 8));
								double Delta1 = Math.Pow(fBienSo2, 2) - 4 * fBienSo3;
								double Delta2 = Math.Pow(fBienSo5, 2) - 4 * fBienSo6;


								if (Delta1 < 0 && Delta2 < 0)
								{
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 < 0 && Delta2 == 0)
								{
									double x = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 < 0 && Delta2 > 0)
								{
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtX1.Text = "x ≥ " + x3.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x4.ToString();
								}
								else if (Delta1 == 0 && Delta2 < 0)
								{
									double x12 = (-fBienSo2) / 2;
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 == 0 && Delta2 == 0)
								{
									txtKQ.Text = "Bất phương trình có nghiệm đúng với mọi x thuộc R";
								}
								else if (Delta1 == 0 && Delta2 > 0)
								{
									double x12 = -fBienSo2 / 2;
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);

									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x3.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x4.ToString();
								}

								else if (Delta1 > 0 && Delta2 < 0)
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x2.ToString();
								}
								else if (Delta1 > 0 && Delta2 == 0)
								{
									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x34 = -fBienSo5 / 2;
									Math.Round(x34, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString() + "      hoặc";
									txtX2.Text = "x ≤ " + x2.ToString();

								}
								else
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString();
									txtX2.Text = x2.ToString() + " ≤ x ≤ " + x3.ToString() + "      hoặc";
									txtX3.Text = "x ≤ " + x4.ToString();
								}
							}

						}
					}
					else
					{

						dblB = dblB / dblA;
						dblC = dblC / dblA;
						dblD = dblD / dblA;
						dblE = dblE / dblA;
						dblA = 1;
						double m = -8;
						double n = 4 * dblC;
						double p = 8 * dblE - 2 * dblB * dblD;
						double q = dblB * dblB * dblE - 4 * dblC * dblE + dblD * dblD;
						double dblGiaTriX1 = 0;
						double dblGiaTriX2 = 0;
						double dblGiaTriX3 = 0;
						if (q == 0)
						{
							dblGiaTriX1 = 0;
						}
						else
						{

							// Tìm biến số f
							// f = [(3c/a) - (b²/a²)] / 3
							double dblF = (((3 * p) / m) - ((n * n) / (m * m))) / 3;

							// Tìm biến số g
							// g = [(2b³/a³) - (9bc/a²) + (27d/a)] / 27
							double dblG = (((2 * n * n * n) / (m * m * m)) - ((9 * n * p) / (m * m)) + ((27 * q) / m)) / 27;

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
								double dble = 1;
								if (dblR < 0)
								{
									dble = -1;
								}
								else
								{
									dble = 1;
								}
								double dblRMu1Phan3 = Math.Pow(dblR * dble, 0.33333333333333333333333333333333);
								dblRMu1Phan3 = dblRMu1Phan3 * dble;

								// Tìm giá trị S
								// S = (R)^(1/3)
								double dblS = dblRMu1Phan3;

								// Tìm giá trị T
								// T = -(g/2) - (h)½
								double dblT = -(dblG / 2) - dblHMu1Phan2;
								if (dblT < 0)
								{
									dble = -1;
								}
								else
								{
									dble = 1;
								}
								double dblTMu1Phan3 = Math.Pow(dblT * dble, 0.33333333333333333333333333333333);
								dblTMu1Phan3 = dblTMu1Phan3 * dble;

								// Tìm giá trị U
								// U = (T)^(1/3)
								double dblU = dblTMu1Phan3;


								// Tính giá trị X1
								// X1 = (S + U) - (b/3a)
								dblGiaTriX1 = (dblS + dblU) - (n / (3 * m));

								// Tính giá trị X2
								// X2 = -(S + U)/2 - (b/3a) + i*(S-U)*(3)½/2
								double dbl3Mu1Phan2 = Math.Pow(3, 0.5);
								double dblVeTraiX2 = -(dblS + dblU) / 2 - (n / (3 * m));
								double dblVePhaiX2 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;

								// Tính giá trị X3
								// X3 = -(S + U)/2 - (b/3a) - i*(S-U)*(3)½/2
								double dblVeTraiX3 = -(dblS + dblU) / 2 - (n / (3 * m));
								double dblVePhaiX3 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;




							}



							// Trong trường hợp đặc biệt khi mà f = 0, g = 0 và h = 0 thì tất cả 3 nghiệm là thực và bằng nhau
							// X1 = X2 = X3= (d/a)^(1/3) * (-1)
							else if (dblF == 0 && dblG == 0 && dblH == 0)
							{
								//double dblS = 1;
								double dblDTrenAMu1Phan3 = 0;
								double dblDTrenA = q / m;
								dblDTrenAMu1Phan3 = Math.Pow(Math.Abs(dblDTrenA), 0.33333333333333333333333333333333);

								if (dblDTrenA < 0)
								{
									dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * 1;
								}
								else if (dblDTrenA > 0)
								{
									dblDTrenAMu1Phan3 = dblDTrenAMu1Phan3 * (-1);
								}



								// Tính giá trị X1
								dblGiaTriX1 = dblDTrenAMu1Phan3;

								// Tính giá trị X2
								dblGiaTriX2 = dblDTrenAMu1Phan3;

								// Tính giá trị X3
								dblGiaTriX3 = dblDTrenAMu1Phan3;



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
								double dblP = (n / (3 * m)) * (-1);

								// Tính giá trị X1
								// X1 = 2j * cosine(k/3) - (b/3a)
								double dblCosinCuaKTren3 = Math.Cos(dblKTren3);
								double dblX1 = 2 * dblJ * dblCosinCuaKTren3 - (n / (3 * m));
								dblGiaTriX1 = dblX1;

								// Tính giá trị X2
								// X2 = L * (M + N) + P
								dblGiaTriX2 = (dblL * (dblM + dblN)) + dblP;

								// Tính giá trị X3
								// X3 = L * (M - N) + P
								dblGiaTriX3 = (dblL * (dblM - dblN)) + dblP;



							}

						}

						if (2 * dblGiaTriX1 < (dblC - dblB * dblB / 4))
						{

							double X = (dblD - dblB * dblGiaTriX1) / (dblB * dblB / 2 + 4 * dblGiaTriX1 - 2 * dblC);
							if (X * X + dblB * X / 2 + dblGiaTriX1 == 0)
							{
								txtKQ.Text = "Bất phương trình có nghiệm:";
								txtX1.Text = "Bất phương trình có nghiệm x = " + X.ToString();
							}
							else
							{
								txtX1.Text = "Bất phương trình vô nghiệm";
							}
						}
						else
						{
							if (dblB * dblGiaTriX1 - dblD < 0)
							{
								double fBienSo2 = (dblB / 2 - Math.Sqrt(Math.Round((dblB * dblB / 4 - dblC + dblGiaTriX1 * 2), 8)));
								double fBienSo3 = dblGiaTriX1 + Math.Sqrt(Math.Round((dblGiaTriX1 * dblGiaTriX1 - dblE), 8));
								double fBienSo5 = (dblB / 2 + Math.Sqrt(Math.Round((dblB * dblB / 4 - dblC + dblGiaTriX1 * 2), 8)));
								double fBienSo6 = dblGiaTriX1 - Math.Sqrt(Math.Round((dblGiaTriX1 * dblGiaTriX1 - dblE), 8));
								double Delta1 = Math.Pow(fBienSo2, 2) - 4 * fBienSo3;
								double Delta2 = Math.Pow(fBienSo5, 2) - 4 * fBienSo6;



								if (Delta1 < 0 && Delta2 < 0)
								{

									txtX1.Text = "Bất phương trình vô nghiệm";
								}
								else if (Delta1 < 0 && Delta2 == 0)
								{
									double x = -fBienSo5 / 2;
									txtX1.Text = "x = " + x.ToString();
								}
								else if (Delta1 < 0 && Delta2 > 0)
								{
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = x4.ToString() + " ≤ x ≤ " + x3.ToString();
								}
								else if (Delta1 == 0 && Delta2 < 0)
								{
									double x12 = (-fBienSo2) / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x12.ToString();
								}
								else if (Delta1 == 0 && Delta2 == 0)
								{
									double x12 = -fBienSo2 / 2;
									double x34 = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x12.ToString() + "      hoặc";
									txtX2.Text = "x = " + x34.ToString();
								}
								else if (Delta1 == 0 && Delta2 > 0)
								{
									double x12 = -fBienSo2 / 2;
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x12.ToString() + "      hoặc";
									txtX2.Text = x4.ToString() + " ≤ x ≤ " + x3.ToString();

								}

								else if (Delta1 > 0 && Delta2 < 0)
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = x2.ToString() + " ≤ x ≤ " + x1.ToString();

								}
								else if (Delta1 > 0 && Delta2 == 0)
								{
									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x34 = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX2.Text = x2.ToString() + " ≤ x ≤ " + x1.ToString() + "      hoặc";
									txtX1.Text = "x = " + x34.ToString();
								}
								else
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);

									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = x3.ToString() + " ≤ x ≤ " + x1.ToString() + "      hoặc";
									txtX2.Text = x4.ToString() + " ≤ x ≤ " + x2.ToString();

								}
							}
							else
							{

								double fBienSo2 = (dblB / 2 - Math.Sqrt(Math.Round(dblB * dblB / 4 - dblC + dblGiaTriX1 * 2, 8)));
								double fBienSo3 = dblGiaTriX1 - Math.Sqrt(Math.Round(dblGiaTriX1 * dblGiaTriX1 - dblE, 8));
								double fBienSo5 = (dblB / 2 + Math.Sqrt(Math.Round(dblB * dblB / 4 - dblC + dblGiaTriX1 * 2, 8)));
								double fBienSo6 = dblGiaTriX1 + Math.Sqrt(Math.Round(dblGiaTriX1 * dblGiaTriX1 - dblE, 8));
								double Delta1 = Math.Pow(fBienSo2, 2) - 4 * fBienSo3;
								double Delta2 = Math.Pow(fBienSo5, 2) - 4 * fBienSo6;


								if (Delta1 < 0 && Delta2 < 0)
								{

									txtX1.Text = "Bất phương trình vô nghiệm";
								}
								else if (Delta1 < 0 && Delta2 == 0)
								{
									double x = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x.ToString();
								}
								else if (Delta1 < 0 && Delta2 > 0)
								{
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = x4.ToString() + " ≤ x ≤ " + x3.ToString();

								}
								else if (Delta1 == 0 && Delta2 < 0)
								{
									double x12 = (-fBienSo2) / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x12.ToString();
								}
								else if (Delta1 == 0 && Delta2 == 0)
								{
									double x12 = -fBienSo2 / 2;
									double x34 = -fBienSo5 / 2;
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x12.ToString() + "      hoặc";
									txtX2.Text = "x = " + x34.ToString();
								}
								else if (Delta1 == 0 && Delta2 > 0)
								{
									double x12 = -fBienSo2 / 2;
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x = " + x12.ToString() + "      hoặc";
									txtX2.Text = x4.ToString() + " ≤ x ≤ " + x3.ToString();

								}

								else if (Delta1 > 0 && Delta2 < 0)
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = x2.ToString() + " ≤ x ≤ " + x1.ToString();

								}
								else if (Delta1 > 0 && Delta2 == 0)
								{
									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x34 = -fBienSo5 / 2;
									Math.Round(x34, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX2.Text = x2.ToString() + " ≤ x ≤ " + x1.ToString() + "      hoặc";
									txtX1.Text = "x = " + x34.ToString();
								}
								else
								{

									double x1 = (-fBienSo2 + Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x1 = Math.Round(x1, 8);
									double x2 = (-fBienSo2 - Math.Sqrt(Math.Round(Delta1, 8))) / 2;
									x2 = Math.Round(x2, 8);
									double x3 = (-fBienSo5 + Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x3 = Math.Round(x3, 8);
									double x4 = (-fBienSo5 - Math.Sqrt(Math.Round(Delta2, 8))) / 2;
									x4 = Math.Round(x4, 8);
									x4 = Math.Round(x4, 8);
									txtKQ.Text = "Bất phương trình có nghiệm:";
									txtX1.Text = "x ≥ " + x1.ToString() + "      hoặc";
									txtX2.Text = x2.ToString() + "≤ x ≤ " + x3.ToString() + "      hoặc";
									txtX3.Text = "x ≤ " + x4.ToString();
								}
							}
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
					txtE.Enabled = true;
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
				txtE.Text = "0";
			}

			if ((txtA.Text == "0") && (txtB.Text == "0") && (txtC.Text == "0") && (txtD.Text == "0") && (txtE.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;

			btnGiai.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = true;
			txtE.Enabled = true;
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
