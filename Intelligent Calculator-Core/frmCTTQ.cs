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
	public partial class frmCTTQ : Form
	{
		public frmCTTQ()
		{
			InitializeComponent();
		}

		private void frmCTTQ_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
			txtU1.Enabled = false;
			txtA.Enabled = false;
			txtB.Enabled = false;
			txtC.Enabled = false;
			txtD.Enabled = false;
			txtU0.Enabled = false;
			txtU2.Enabled = false;
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
			//if ((rdNT2.Checked || rdNT1.Checked) && txtA.Text == "0" && txtB.Text == "0" && txtN.Text == "0" && txtSoMu.Text == "0")
			//{
			//	btnLamMoi.Enabled = false;
			//}
			//else if (rdNT3.Checked && txtA.Text == "0" && txtB.Text == "0" && txtC.Text == "0" && txtN.Text == "0" && txtSoMu.Text == "0")
			//{
			//	btnLamMoi.Enabled = false;
			//}
			//else
			//{
			//	btnLamMoi.Enabled = true;
			//}
		}

		private void rdDay1_CheckedChanged(object sender, EventArgs e)
		{
			txtU1.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = false;
			txtD.Enabled = false;
			txtU0.Enabled = false;
			txtU2.Enabled = false;

			txtKQ.Text = "";
			txtC.Text = "0";
			txtD.Text = "0";
			txtU0.Text = "0";
			txtU2.Text = "0";

		}

		private void rdDay2_CheckedChanged(object sender, EventArgs e)
		{
			txtU1.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = false;
			txtU0.Enabled = false;
			txtU2.Enabled = false;

			txtKQ.Text = "";
			txtD.Text = "0";
			txtU0.Text = "0";
			txtU2.Text = "0";
		}

		private void rdDay3_CheckedChanged(object sender, EventArgs e)
		{
			txtU0.Enabled = true;
			txtU1.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = false;
			txtD.Enabled = false;
			txtU2.Enabled = false;

			txtKQ.Text = "";
			txtC.Text = "0";
			txtD.Text = "0";
			txtU2.Text = "0";
		}

		private void rdDay4_CheckedChanged(object sender, EventArgs e)
		{
			txtU0.Enabled = true;
			txtU1.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = true;
			txtU2.Enabled = false;

			txtKQ.Text = "";
			txtU2.Text = "0";
		}

		private void rdDay5_CheckedChanged(object sender, EventArgs e)
		{
			txtU0.Enabled = true;
			txtU1.Enabled = true;
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = true;
			txtU2.Enabled = true;

			txtKQ.Text = "";
		}

		private void txtU0_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtU1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtU2_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtA_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtB_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtC_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtD_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void txtU0_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtU0.Text == "0")
			{
				txtU0.Text = "";
			}
		}

		private void txtU1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtU1.Text == "0")
			{
				txtU1.Text = "";
			}
		}

		private void txtU2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtU2.Text == "0")
			{
				txtU2.Text = "";
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

		private void txtD_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtD.Text == "0")
			{
				txtD.Text = "";
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (rdDay1.Checked == true)
			{
				try
				{
					double u1 = Convert.ToDouble(txtU1.Text);
					double a = Convert.ToDouble(txtA.Text);
					double b = Convert.ToDouble(txtB.Text);
					if (a * b == 0)
					{
						MessageBox.Show("Mời bạn nhập lại a,b");
					}
					else
					{
						if (a == 1)
						{
							txtKQ.Text = "Dãy có CTTQ là Un = " + u1.ToString() + " + (n-1)." + b.ToString();
						}
						else
						{
							double k = u1 + b / (a - 1);
							double m = -b / (a - 1);
							if (m < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + k.ToString() + "." + a.ToString() + "^(n-1) " + m.ToString();
							}
							else
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + k.ToString() + "." + a.ToString() + "^(n-1) " + " + " + m.ToString();
							}
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Kí tự bạn nhập không hợp lệ");
				}
			}
			if (rdDay2.Checked == true)
			{
				try
				{
					double u1 = Convert.ToDouble(txtU1.Text);
					double a = Convert.ToDouble(txtA.Text);
					double b = Convert.ToDouble(txtB.Text);
					double c = Convert.ToDouble(txtC.Text);
					if (a * b * c == 0)
					{
						MessageBox.Show("Mời bạn nhập lại a,b,c");
					}
					else
					{
						if (a == c)
						{
							txtKQ.Text = "Dãy có CTTQ là Un = " + b.ToString() + ".(n-1)." + c.ToString() + "^n + " + u1.ToString() + "." + c.ToString() + "^(n-1)";
						}
						else
						{
							double k = c / (c - a);
							if (b * k < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + (u1 - b * k * c).ToString() + "." + a.ToString() + "^(n-1) " + (b * k).ToString() + "." + c.ToString() + "^n";
							}
							else
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + (u1 - b * k * c).ToString() + "." + a.ToString() + "^(n-1) + " + (b * k).ToString() + "." + c.ToString() + "^n";
							}
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Kí tự bạn nhập không hợp lệ");
				}
			}
			if (rdDay3.Checked == true)
			{
				try
				{
					double u1 = Convert.ToDouble(txtU1.Text);
					double a = Convert.ToDouble(txtA.Text);
					double b = Convert.ToDouble(txtB.Text);
					double u0 = Convert.ToDouble(txtU0.Text);
					if (a * b == 0)
					{
						MessageBox.Show("Vui lòng nhập lại a,b,c");
					}
					else
					{
						double Delta = a * a + 4 * b;
						if (Delta > 0)
						{
							double X1 = (a + Math.Sqrt(Delta)) / (2);
							double X2 = (a - Math.Sqrt(Delta)) / 2;
							double C1 = (u1 - u0 * X2) / (X1 - X2);
							double C2 = (u0 * X1 - u1) / (X1 - X2);
							if (C2 < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + C1.ToString() + ".(" + X1.ToString() + ")^n " + C2.ToString() + ".(" + X2.ToString() + ")^n";
							}
							else
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + C1.ToString() + ".(" + X1.ToString() + ")^n + " + C2.ToString() + ".(" + X2.ToString() + ")^n";
							}
						}
						else if (Delta == 0)
						{
							double X = a / 2;
							double C = (u1 - u0 * X) / X;
							if (a < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + X.ToString() + "^n .(" + C.ToString() + ".n " + a.ToString();
							}
							else
							{
								txtKQ.Text = "Dãy có CTTQ là Un = " + X.ToString() + "^n .(" + C.ToString() + ".n + " + a.ToString();
							}
						}
						else
						{
							double Goc = Math.Acos(a / (2 * Math.Sqrt(Math.Abs(b))));
							double R = Math.Sqrt(Math.Abs(b));
							double C1 = u0;
							double C2 = (u1 - R * u0 * Math.Cos(Goc)) / (R * Math.Sin(Goc));
							if (C2 < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = (" + R.ToString() + ")^n.[" + C1.ToString() + ".cos(n." + Goc.ToString() + ")" + C2.ToString() + ".sin(n." + Goc.ToString() + ")]";
							}
							else
							{
								txtKQ.Text = "Dãy có CTTQ là Un = (" + R.ToString() + ")^n.[" + C1.ToString() + ".cos(n." + Goc.ToString() + ") + " + C2.ToString() + ".sin(n." + Goc.ToString() + ")]";
							}
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Kí tự bạn nhập không hợp lệ");
				}
			}
			if (rdDay4.Checked == true)
			{
				try
				{
					double u1 = Convert.ToDouble(txtU1.Text);
					double a = Convert.ToDouble(txtA.Text);
					double b = Convert.ToDouble(txtB.Text);
					double u0 = Convert.ToDouble(txtU0.Text);
					double c = Convert.ToDouble(txtC.Text);
					double d = Convert.ToDouble(txtD.Text);
					if (a * b * c * d == 0)
					{
						MessageBox.Show("Vui lòng nhập lại a,b,c");
					}
					else
					{
						double Delta = a * a - 4 * b;
						if (Delta > 0)
						{
							double X1 = (-a - Math.Sqrt(Delta)) / 2;
							double X2 = (-a + Math.Sqrt(Delta)) / 2;
							if (X1 != d && X2 != d)
							{
								double k = d * d / (d * d + a * d + b);
								double D = X2 - X1;
								double Dp = (u0 - k * c) * X2 - (u1 - c * d * k);
								double Dq = (u1 - c * d * k) - (u0 - k * c) * X1;
								double p = Dp / D;
								double q = Dq / D;
								if (q < 0 && k * c < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n " + q.ToString() + ".(" + X2.ToString() + ")^n" + (k * c).ToString() + ".(" + d.ToString() + ")^n";
								}
								else if (q < 0 && k * c > 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n " + q.ToString() + ".(" + X2.ToString() + ")^n + " + (k * c).ToString() + ".(" + d.ToString() + ")^n";
								}
								else if (q > 0 && k * c < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n + " + q.ToString() + ".(" + X2.ToString() + ")^n" + (k * c).ToString() + ".(" + d.ToString() + ")^n";
								}
								else
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n + " + q.ToString() + ".(" + X2.ToString() + ")^n + " + (k * c).ToString() + ".(" + d.ToString() + ")^n";
								}
							}
							if (X1 == d | X2 == d)
							{
								double k = d / (2 * d + a);
								double D = X2 - X1;
								double Dp = u0 * X2 - (u1 - c * d * k);
								double Dq = (u1 - c * d * k) - u0 * X1;
								double p = Dp / D;
								double q = Dq / D;
								if (q < 0 && k * c < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n " + q.ToString() + ".(" + X2.ToString() + ")^n" + (k * c).ToString() + ".n.(" + d.ToString() + ")^n";
								}
								else if (q < 0 && k * c > 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n " + q.ToString() + ".(" + X2.ToString() + ")^n + " + (k * c).ToString() + ".n.(" + d.ToString() + ")^n";
								}
								else if (q > 0 && k * c < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n + " + q.ToString() + ".(" + X2.ToString() + ")^n" + (k * c).ToString() + ".n.(" + d.ToString() + ")^n";
								}
								else
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + p.ToString() + ".(" + X1.ToString() + ")^n + " + q.ToString() + ".(" + X2.ToString() + ")^n + " + (k * c).ToString() + ".n.(" + d.ToString() + ")^n";
								}
							}
							else
							{
								txtKQ.Text = "Chương trinh không hỗ trợ";
							}
						}
						if (Delta == 0)
						{
							double X = -a / 2;
							if (X == d)
							{
								double p = u0;
								double q = u1 / d - c / 2 - u0;
								if (q < 0 && c < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = (" + p.ToString() + q.ToString() + ".n" + (c / 2).ToString() + ".n^2).(" + d.ToString() + ")^n";
								}
								else if (q < 0 && c > 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = (" + p.ToString() + q.ToString() + ".n + " + (c / 2).ToString() + ".n^2).(" + d.ToString() + ")^n";
								}
								else if (q > 0 && c < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = (" + p.ToString() + " + " + q.ToString() + ".n" + (c / 2).ToString() + ".n^2).(" + d.ToString() + ")^n";
								}
								else
								{
									txtKQ.Text = "Dãy có CTTQ là Un = (" + p.ToString() + " + " + q.ToString() + ".n + " + (c / 2).ToString() + ".n^2).(" + d.ToString() + ")^n";

								}
							}
						}
						else
						{
							txtKQ.Text = "Chương trình không hỗ trợ";
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Kí tự bạn nhập không hợp lệ");
				}
			}
			if (rdDay5.Checked == true)
			{
				try
				{
					double u1 = Convert.ToDouble(txtU1.Text);
					double a = Convert.ToDouble(txtA.Text);
					double b = Convert.ToDouble(txtB.Text);
					double u0 = Convert.ToDouble(txtU0.Text);
					double c = Convert.ToDouble(txtC.Text);
					double u2 = Convert.ToDouble(txtU2.Text);
					if (a * b * c == 0)
					{
						MessageBox.Show("Vui lòng nhập lại a,b,c");
					}
					else
					{
						double dblGiaTriX1 = 0;
						double dblGiaTriX2 = 0;
						double dblGiaTriX3 = 0;
						// Tìm biến số f
						// f = [(3c/a) - (b²/a²)] / 3
						double dblF = (((3 * b) / 1) - ((a * a) / (1 * 1))) / 3;

						// Tìm biến số g
						// g = [(2b³/a³) - (9bc/a²) + (27d/a)] / 27
						double dblG = (((2 * a * a * a) / (1 * 1 * 1)) - ((9 * a * b) / (1 * 1)) + ((27 * c) / 1)) / 27;

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
							dblGiaTriX1 = (dblS + dblU) - (a / (3 * 1));
							dblGiaTriX1 = Math.Round(dblGiaTriX1, 8);

							// Tính giá trị X2
							// X2 = -(S + U)/2 - (b/3a) + i*(S-U)*(3)½/2
							double dbl3Mu1Phan2 = Math.Pow(3, 0.5);
							double dblVeTraiX2 = -(dblS + dblU) / 2 - (a / (3 * 1));
							double dblVePhaiX2 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;


							// Tính giá trị X3
							// X3 = -(S + U)/2 - (b/3a) - i*(S-U)*(3)½/2
							double dblVeTraiX3 = -(dblS + dblU) / 2 - (a / (3 * 1));
							double dblVePhaiX3 = ((dblS - dblU) * dbl3Mu1Phan2) / 2;


							// Hiển thị giá trị các nghiệm
							txtKQ.Text = "Chương trình không hỗ trợ !!!";

						}



						// Trong trường hợp đặc biệt khi mà f = 0, g = 0 và h = 0 thì tất cả 3 nghiệm là thực và bằng nhau
						// X1 = X2 = X3= (d/a)^(1/3) * (-1)
						else if (dblF == 0 && dblG == 0 && dblH == 0)
						{
							//double dblS = 1;
							double dblDTrenAMu1Phan3 = 0;
							double dblDTrenA = c / 1;
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
							double A = u0;
							double B = 2 * u1 / dblGiaTriX1 - 3 * A / 2 - u2 / (2 * dblGiaTriX1 * dblGiaTriX1);
							double C = u2 / (2 * dblGiaTriX1 * dblGiaTriX1) + A / 2 - u1 / dblGiaTriX1;
							if (B < 0 && C < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = (" + A.ToString() + B.ToString() + ".n" + C.ToString() + ".n^2).(" + dblGiaTriX1.ToString() + ")^n";
							}
							else if (B < 0 && C > 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = (" + A.ToString() + B.ToString() + ".n + " + C.ToString() + ".n^2).(" + dblGiaTriX1.ToString() + ")^n";
							}
							else if (B > 0 && C < 0)
							{
								txtKQ.Text = "Dãy có CTTQ là Un = (" + A.ToString() + " + " + B.ToString() + ".n" + C.ToString() + ".n^2).(" + dblGiaTriX1.ToString() + ")^n";
							}
							else
							{
								txtKQ.Text = "Dãy có CTTQ là Un = (" + A.ToString() + " + " + B.ToString() + ".n + " + C.ToString() + ".n^2).(" + dblGiaTriX1.ToString() + ")^n";

							}
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
							double dblP = (a / (3 * 1)) * (-1);

							// Tính giá trị X1
							// X1 = 2j * cosine(k/3) - (b/3a)
							double dblCosinCuaKTren3 = Math.Cos(dblKTren3);
							double dblX1 = 2 * dblJ * dblCosinCuaKTren3 - (a / (3 * 1));
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
							double a1 = 1;
							double b1 = 1;
							double c1 = 1;
							double d1 = u0;
							double a2 = dblGiaTriX1;
							double b2 = dblGiaTriX2;
							double c2 = dblGiaTriX3;
							double d2 = u1;
							double a3 = dblGiaTriX1 * dblGiaTriX1;
							double b3 = dblGiaTriX2 * dblGiaTriX2;
							double c3 = dblGiaTriX3;
							double d3 = u2;
							double A = 0;
							double B = 0;
							double C = 0;
							if (c1 * c1 + c2 * c2 == 0)
							{
								double dx = d1 * b2 - d2 * b1;
								double dy = a1 * d2 - a2 * d1;
								double d = a1 * b2 - a2 * b1;
								if (d == 0 & dx == 0 & dy == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dx * dx + dy * dy != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double x = dx / d;
									double y = dy / d;
									if (c3 == 0)
									{
										if (a3 * x + b3 * y == d3)
										{
											//txtKQ.Text = " x = " + x.ToString();
											//txtKQ.Text = " y = " + y.ToString();
											//txtKQ.Text = " z = R";
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double z = (d3 - a3 * x - b3 * y) / c3;
										A = x;
										B = y;
										C = z;

									}
								}
							}
							else if (c1 * c1 + c3 * c3 == 0)
							{
								double dx = d1 * b3 - d3 * b1;
								double dy = a1 * d3 - a3 * d1;
								double d = a1 * b3 - a3 * b1;
								if (d == 0 & dx == 0 & dy == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dx * dx + dy * dy != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double x = dx / d;
									double y = dy / d;
									if (c2 == 0)
									{
										if (a2 * x + b2 * y == d2)
										{
											//txtKQ.Text = " x = " + x.ToString();
											//txtKQ.Text = " y = " + y.ToString();
											//txtKQ.Text = " z = R ";
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double z = (d2 - a2 * x - b2 * y) / c2;
										A = x;
										B = y;
										C = z;

									}
								}
							}
							else if (c2 * c2 + c3 * c3 == 0)
							{
								double dx = d2 * b3 - d3 * b2;
								double dy = a2 * d3 - a3 * d2;
								double d = a2 * b3 - a3 * b2;
								if (d == 0 & dx == 0 & dy == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dx * dx + dy * dy != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double x = dx / d;
									double y = dy / d;
									if (c1 == 0)
									{
										if (a1 * x + b1 * y == d1)
										{
											//txtKQ.Text = " x = " + x.ToString();
											//txtKQ.Text = " y = " + y.ToString();
											//txtKQ.Text = " z = R ";
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double z = (d1 - a1 * x - b1 * y) / c1;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (b1 * b1 + b2 * b2 == 0)
							{
								double dx = d1 * c2 - d2 * c1;
								double dz = a1 * d2 - a2 * d1;
								double d = a1 * c2 - a2 * c1;
								if (d == 0 & dx == 0 & dz == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dx * dx + dz * dz != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double x = dx / d;
									double z = dz / d;
									if (b3 == 0)
									{
										if (a3 * x + c3 * z == d3)
										{
											//txtKQ.Text = " x = " + x.ToString();
											//txtKQ.Text = " y = R ";
											//txtKQ.Text = " z = " + z.ToString();
										}
										else
										{
											//MessageBox.Show("Hệ phương trình vô nghiệm");
										}
									}
									else
									{
										double y = (d3 - a3 * x - c3 * z) / b3;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (b1 * b1 + b3 * b3 == 0)
							{
								double dx = d1 * c3 - d3 * c1;
								double dz = a1 * d3 - a3 * d1;
								double d = a1 * c3 - a3 * c1;
								if (d == 0 & dx == 0 & dz == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dx * dx + dz * dz != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double x = dx / d;
									double z = dz / d;
									if (b2 == 0)
									{
										if (a2 * x + c2 * z == d2)
										{
											//txtKQ.Text = " x = " + x.ToString();
											//txtKQ.Text = " y = R ";
											//txtKQ.Text = " z = " + z.ToString();
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double y = (d2 - a2 * x - c2 * z) / b2;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (b2 * b2 + b3 * b3 == 0)
							{
								double dx = d2 * c3 - d3 * c3;
								double dz = a2 * d3 - a3 * d2;
								double d = a2 * c3 - a3 * c2;
								if (d == 0 & dx == 0 & dz == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dx * dx + dz * dz != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double x = dx / d;
									double z = dz / d;
									if (b1 == 0)
									{
										if (a1 * x + c1 * z == d1)
										{
											//txtKQ.Text = " x = " + x.ToString();
											//txtKQ.Text = " y = R ";
											//txtKQ.Text = " z = " + z.ToString();
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double y = (d1 - a1 * x - c1 * z) / b1;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (a1 * a1 + a2 * a2 == 0)
							{
								double dy = d1 * c2 - d2 * c1;
								double dz = b1 * d2 - b2 * d1;
								double d = b1 * c2 - b2 * c1;
								if (d == 0 & dy == 0 & dz == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dy * dy + dz * dz != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double y = dy / d;
									double z = dz / d;
									if (a3 == 0)
									{
										if (b3 * y + c3 * z == d3)
										{
											//txtKQ.Text = " x = R ";
											//txtKQ.Text = " y = " + y.ToString();
											//txtKQ.Text = " z = " + z.ToString();
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double x = (d3 - b3 * y - c3 * z) / a3;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (a1 * a1 + a3 * a3 == 0)
							{
								double dy = d1 * c3 - d3 * c1;
								double dz = b1 * d3 - b3 * d1;
								double d = b1 * c3 - b3 * c1;
								if (d == 0 & dy == 0 & dz == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dy * dy + dz * dz != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double y = dy / d;
									double z = dz / d;
									if (a2 == 0)
									{
										if (b2 * y + c2 * z == d2)
										{
											//txtKQ.Text = " x = R ";
											//txtKQ.Text = " y = " + y.ToString();
											//txtKQ.Text = " z = " + z.ToString();
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double x = (d2 - b2 * y - c2 * z) / a2;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (a2 * a2 + a3 * a3 == 0)
							{
								double dy = d2 * c3 - d3 * c2;
								double dz = b2 * d3 - b3 * d2;
								double d = b2 * c3 - b3 * c2;
								if (d == 0 & dy == 0 & dz == 0)
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if ((d == 0) & (dy * dy + dz * dz != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (d != 0)
								{
									double y = dy / d;
									double z = dz / d;
									if (a1 == 0)
									{
										if (b1 * y + c1 * z == d1)
										{
											//txtKQ.Text = " x = R ";
											//txtKQ.Text = " y = " + y.ToString();
											//txtKQ.Text = " z = " + z.ToString();
										}
										else
										{
											//txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
									}
									else
									{
										double x = (d1 - b1 * y - c1 * z) / a1;
										A = x;
										B = y;
										C = z;
									}
								}
							}
							else if (c1 == 0)
							{
								double aA = a2 * c3 - a3 * c2;
								double bB = b2 * c3 - b3 * c2;
								double d = d2 * c3 - d3 * c2;
								double dx = d * b1 - bB * d1;
								double dy = aA * d1 - a1 * d;
								double D = aA * b1 - a1 * bB;
								if (D == 0 & (dx * dx + dy * dy == 0))
								{
									//MessageBox.Show("Hệ phương trình có các nghiệm x,y,z tùy ý");
								}
								else if (D == 0 & (dx * dx + dy * dy != 0))
								{
									//MessageBox.Show("Hệ phương trình vô nghiệm");
								}
								else if (D != 0)
								{
									double x = dx / D;
									double y = dy / D;
									double z = (d2 - a2 * x - b2 * y) / c2;
									//MessageBox.Show("Nghiệm của hệ là (" + x.ToString() + "," + y.ToString() + "," + z.ToString() + ")");
								}
							}
							else if (c2 == 0)
							{
								double aA = a1 * c3 - a3 * c1;
								double bB = b1 * c3 - b3 * c1;
								double d = d1 * c3 - d3 * c1;
								double dx = d * b2 - bB * d2;
								double dy = aA * d2 - a2 * d;
								double D = aA * b2 - a2 * bB;
								if (D == 0 & (dx * dx + dy * dy == 0))
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if (D == 0 & (dx * dx + dy * dy != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (D != 0)
								{
									double x = dx / D;
									double y = dy / D;
									double z = (d1 - a1 * x - b1 * y) / c1;
									A = x;
									B = y;
									C = z;
								}
							}
							else if (c3 == 0)
							{
								double aA = a1 * c2 - a2 * c1;
								double bB = b1 * c2 - b2 * c1;
								double d = d1 * c2 - d2 * c1;
								double dx = d * b3 - bB * d3;
								double dy = aA * d3 - a3 * d;
								double D = aA * b3 - a3 * bB;
								if (D == 0 & (dx * dx + dy * dy == 0))
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if (D == 0 & (dx * dx + dy * dy != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (D != 0)
								{
									double x = dx / D;
									double y = dy / D;
									double z = (d1 - a1 * x - b1 * y) / c1;
									A = x;
									B = y;
									C = z;
								}
							}
							else if (c1 != 0 & c2 != 0 & c3 != 0)
							{
								double aA = a1 * c2 - a2 * c1;
								double bB = b1 * c2 - b2 * c1;
								double d = d1 * c2 - d2 * c1;
								double aa = a2 * c3 - a3 * c2;
								double bb = b2 * c3 - b3 * c2;
								double dd = d2 * c3 - d3 * c2;
								double dx = d * bb - b * dd;
								double dy = aA * dd - d * aa;
								double D = aA * bb - bB * aa;
								if (D == 0 & (dx * dx + dy * dy == 0))
								{
									//txtKQ.Text = "Hệ phương trình có các nghiệm x,y,z tùy ý";
								}
								else if (D == 0 & (dx * dx + dy * dy != 0))
								{
									//txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (D != 0)
								{
									double x = dx / D;
									double y = dy / D;
									double z = (d1 - a1 * x - b1 * y) / c1;
									A = x;
									B = y;
									C = z;
								}
							}
							if (A == B | B == C | C == A)
							{
								//txtKQ.Text = "Chương trình không hỗ trợ !!!";
							}
							else
							{
								if (B < 0 && C < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + A.ToString() + ".(" + dblGiaTriX1.ToString() + ")^n" + B.ToString() + ".(" + dblGiaTriX2.ToString() + ")^n" + C.ToString() + ".(" + dblGiaTriX3.ToString() + ")^n";
								}
								else if (B < 0 && C > 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + A.ToString() + ".(" + dblGiaTriX1.ToString() + ")^n" + B.ToString() + ".(" + dblGiaTriX2.ToString() + ")^n + " + C.ToString() + ".(" + dblGiaTriX3.ToString() + ")^n";
								}
								else if (B > 0 && C < 0)
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + A.ToString() + ".(" + dblGiaTriX1.ToString() + ")^n + " + B.ToString() + ".(" + dblGiaTriX2.ToString() + ")^n" + C.ToString() + ".(" + dblGiaTriX3.ToString() + ")^n";
								}
								else
								{
									txtKQ.Text = "Dãy có CTTQ là Un = " + A.ToString() + ".(" + dblGiaTriX1.ToString() + ")^n + " + B.ToString() + ".(" + dblGiaTriX2.ToString() + ")^n + " + C.ToString() + ".(" + dblGiaTriX3.ToString() + ")^n";
								}
							}
						}

					}
				}
				catch (Exception)
				{
					MessageBox.Show("Kí tự bạn nhập không hợp lệ");
				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtA.Text = "0";
			txtB.Text = "0";
			txtC.Text = "0";
			txtD.Text = "0";
			txtU0.Text = "0";
			txtU1.Text = "0";
			txtU2.Text = "0";
			txtKQ.Text = "0";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
