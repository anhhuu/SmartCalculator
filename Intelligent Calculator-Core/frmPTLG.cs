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
	public partial class frmPTLG : Form
	{
		public frmPTLG()
		{
			InitializeComponent();
		}

		private void frmPTLG_Load(object sender, EventArgs e)
		{
			txtA.Enabled = false;
			txtM.Enabled = false;
			txtN.Enabled = false;
			txtP.Enabled = false;
			btnLamMoi.Enabled = false;
			btnGiai.Enabled = false;
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
			if (radioSinx.Checked == true || radioCosx.Checked == true || radioTanx.Checked == true || radioCotx.Checked == true)
			{
				if (txtA.Text == "0")
					btnLamMoi.Enabled = false;
				else
					btnLamMoi.Enabled = true;
			}
			if (radioSC.Checked == true)
			{
				if (txtA.Text == "0" && (txtM.Text == "0" && txtN.Text == "0"))
					btnLamMoi.Enabled = false;
				else
					btnLamMoi.Enabled = true;
			}
			if (radioSCBac2.Checked == true)
			{
				if (txtA.Text == "0" && (txtM.Text == "0" && txtN.Text == "0") && (txtP.Text == "0"))
					btnLamMoi.Enabled = false;
				else
					btnLamMoi.Enabled = true;
			}

		}

		private void txtA_TextChanged(object sender, EventArgs e)
		{
			check(txtA);
		}

		private void txtM_TextChanged(object sender, EventArgs e)
		{
			check(txtM);
		}

		private void txtN_TextChanged(object sender, EventArgs e)
		{
			check(txtN);
		}

		private void txtP_TextChanged(object sender, EventArgs e)
		{
			check(txtP);
		}


		private void txtA_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA.Text == "0")
			{
				txtA.Text = "";
			}
		}

		private void txtM_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtM.Text == "0")
			{
				txtM.Text = "";
			}
		}

		private void txtN_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtN.Text == "0")
			{
				txtN.Text = "";
			}
		}

		private void txtP_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtP.Text == "0")
			{
				txtP.Text = "";
			}
		}

		private void radioLGCoBan_CheckedChanged(object sender, EventArgs e)
		{
			txtA.Enabled = true;
			txtM.Enabled = false;
			txtN.Enabled = false;
			txtP.Enabled = false;
			btnGiai.Enabled = true;
			btnLamMoi.Enabled = true;
			txtKQ.Text = "";
			txtX1.Text = "";
			txtX2.Text = "";
			//txtA.Text = "0";
			txtM.Text = "0";
			txtN.Text = "0";
			txtP.Text = "0";
		}

		private void radioSC_CheckedChanged(object sender, EventArgs e)
		{
			txtA.Enabled = true;
			txtM.Enabled = true;
			txtN.Enabled = true;
			txtP.Enabled = false;
			btnGiai.Enabled = true;
			btnLamMoi.Enabled = true;
			txtKQ.Text = "";
			txtX1.Text = "";
			txtX2.Text = "";
			//txtA.Text = "0";
			//txtM.Text = "0";
			//txtN.Text = "0";
			txtP.Text = "0";
		}

		private void radioSCBac2_CheckedChanged(object sender, EventArgs e)
		{
			txtA.Enabled = true;
			txtM.Enabled = true;
			txtN.Enabled = true;
			txtP.Enabled = true;
			btnGiai.Enabled = true;
			btnLamMoi.Enabled = true;
			txtKQ.Text = "";
			txtX1.Text = "";
			txtX2.Text = "";
			//txtA.Text = "0";
			//txtM.Text = "0";
			//txtN.Text = "0";
			//txtP.Text = "0";
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			btnGiai.Enabled = false;
			btnLamMoi.Enabled = true;
			txtA.Enabled = false;
			txtM.Enabled = false;
			txtN.Enabled = false;
			txtP.Enabled = false;

			if (txtA.Text == "")
			{
				if (radioSinx.Checked == true || radioCosx.Checked == true || radioTanx.Checked == true || radioCotx.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = false;
					txtN.Enabled = false;
					txtP.Enabled = false;
				}
				if (radioSC.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = false;
				}
				if (radioSCBac2.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = true;
				}
				btnGiai.Enabled = true;
				btnLamMoi.Enabled = true;
				txtKQ.Text = "";
				txtX1.Text = "";
				txtX2.Text = "";
				MessageBox.Show("Bạn chưa nhập giá trị a!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtM.Text == "" && (radioSC.Checked == true || radioSCBac2.Checked == true))
			{
				if (radioSC.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = false;
				}
				if (radioSCBac2.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = true;
				}
				btnGiai.Enabled = true;
				btnLamMoi.Enabled = true;
				txtKQ.Text = "";
				txtX1.Text = "";
				txtX2.Text = "";
				MessageBox.Show("Bạn chưa nhập giá trị m!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtN.Text == "" && (radioSC.Checked == true || radioSCBac2.Checked == true))
			{
				if (radioSC.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = false;
				}
				if (radioSCBac2.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = true;
				}
				btnGiai.Enabled = true;
				btnLamMoi.Enabled = true;
				txtKQ.Text = "";
				txtX1.Text = "";
				txtX2.Text = "";
				MessageBox.Show("Bạn chưa nhập giá trị n!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtP.Text == "" && radioSCBac2.Checked == true)
			{
				if (radioSC.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = false;
				}
				if (radioSCBac2.Checked == true)
				{
					txtA.Enabled = true;
					txtM.Enabled = true;
					txtN.Enabled = true;
					txtP.Enabled = true;
				}
				txtP.Enabled = true;
				btnGiai.Enabled = true;
				btnLamMoi.Enabled = true;
				txtKQ.Text = "";
				txtX1.Text = "";
				txtX2.Text = "";
				MessageBox.Show("Bạn chưa nhập giá trị p!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				try
				{

					if (radioSinx.Checked == true)
					{
						double A = 0.0;
						A = lamtron(txtA, A);
						txtA.Text = A.ToString();
						if (A > 1)
						{
							txtKQ.Text = "Phương trình vô nghiệm";
							txtX1.Text = "";
							txtX2.Text = "";
						}
						else
						{
							double K = Math.Asin(A);
							double L = K / (Math.PI);
							txtKQ.Text = "Phương trình có nghiệm:";
							txtX1.Text = "x = " + L.ToString() + "π + k2π";
							L = 1 - L;
							txtX2.Text = "x = " + L.ToString() + "π + k2π";
						}
					}
					if (radioCosx.Checked == true)
					{
						double A = 0.0;
						A = lamtron(txtA, A);
						txtA.Text = A.ToString();
						if (A > 1)
						{
							txtKQ.Text = "Phương trình vô nghiệm";
							txtX1.Text = "";
							txtX2.Text = "";
						}
						else
						{
							double K = Math.Acos(A);
							double L = K / (Math.PI);
							txtKQ.Text = "Phương trình có nghiệm:";
							txtX1.Text = "x = " + L.ToString() + "π + k2π";
							txtX2.Text = "x = -" + L.ToString() + "π + k2π";
						}
					}
					if (radioTanx.Checked == true)
					{
						double A = 0.0;
						A = lamtron(txtA, A);
						txtA.Text = A.ToString();
						double K = Math.Atan(A);
						double L = K / (Math.PI);
						txtX1.Text = "x = " + L.ToString() + "π + kπ";
					}
					if (radioCotx.Checked == true)
					{
						double A = 0.0;
						A = lamtron(txtA, A);
						txtA.Text = A.ToString();
						double K = Math.Atan(A);
						double L = (0.5 - K / (Math.PI));
						txtKQ.Text = "Phương tình có nghiệm:";
						txtX1.Text = "x = " + L.ToString() + "π + kπ";
						txtX2.Text = "";
					}
					if (radioSC.Checked == true)
					{
						double A = 0.0;
						double M = 0.0;
						double N = 0.0;
						A = lamtron(txtA, A);
						txtA.Text = A.ToString();
						M = lamtron(txtM, M);
						txtM.Text = M.ToString();
						N = lamtron(txtN, N);
						txtM.Text = M.ToString();
						if (M * N == 0)
						{
							btnGiai.Enabled = true;
							txtA.Enabled = true;
							txtM.Enabled = true;
							txtN.Enabled = true;
							txtP.Enabled = false;
							MessageBox.Show("Vui lòng nhập m và n khác 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
						}
						else
						{
							A = A / (Math.Pow(M * M + N * N, 0.5));
							if (A > 1)
							{
								txtX1.Text = "Phương trình vô nghiệm";
								txtX1.Text = "";
								txtX2.Text = "";
							}
							else
							{
								double cosy = M / (Math.Pow(M * M + N * N, 0.5));
								double y = Math.Round(Math.Acos(cosy), 10);
								double k = Math.Round(Math.Asin(A), 10) - y;
								txtKQ.Text = "Phương trình có nghiệm:";
								txtX1.Text = "x = " + k.ToString() + " + k2π";
								k = Math.PI - k;
								txtX2.Text = "x = " + k.ToString() + " + k2π";
							}
						}
					}
					if (radioSCBac2.Checked == true)
					{
						double A = 0.0;
						double M = 0.0;
						double N = 0.0;
						double P = 0.0;
						A = lamtron(txtA, A);
						txtA.Text = A.ToString();
						M = lamtron(txtM, M);
						txtM.Text = M.ToString();
						N = lamtron(txtN, N);
						txtM.Text = M.ToString();
						P = lamtron(txtP, P);
						txtP.Text = P.ToString();
						if ((M - A) == 0)
						{
							if (P - A == 0)
							{
								txtKQ.Text = "Phương trình có nghiệm:";
								txtX1.Text = "x = kπ/2";
								txtX2.Text = "";
							}
							else if (N == 0)
							{
								txtKQ.Text = "Phương trình có nghiệm:";
								txtX1.Text = "x = π/2 + kπ";
								txtX2.Text = "";
							}
							else if (N * (P - A) != 0)
							{
								double cosy = N / (Math.Pow(N * N + (P - A) * (P - A), 0.5));
								double y = Math.Acos(cosy);
								txtKQ.Text = "Phương trình có nghiệm:";
								txtX1.Text = "x = -" + y.ToString() + " + kπ";
								txtX2.Text = "x = π/2 + kπ";
							}
						}
						else
						{
							double dblD = N * N - 4 * (M - A) * (P - A);
							if (dblD < 0)
							{
								txtKQ.Text = "Phương trình vô nghiệm";
								txtX1.Text = "";
								txtX2.Text = "";
							}
							else if (dblD == 0)
							{
								double x = Math.Atan(-N / (2 * (M - A)));
								txtKQ.Text = "Phương trình có nghiệm:";
								txtX1.Text = "x = " + x.ToString() + " + kπ";
								txtX2.Text = "";
							}
							else
							{
								double tanx1 = (-N - Math.Sqrt(dblD)) / (2 * M - 2 * A);
								double tanx2 = (-N + Math.Sqrt(dblD)) / (2 * M - 2 * A);
								double x1 = Math.Atan(tanx1);
								double x2 = Math.Atan(tanx2);
								txtKQ.Text = "Phương trình có nghiệm:";
								txtX1.Text = "x = " + x1.ToString() + " + kπ";
								txtX2.Text = "x = " + x2.ToString() + " + kπ";
							}
						}
					}
				}
				catch
				{
					if (radioSinx.Checked == true || radioCosx.Checked == true || radioTanx.Checked == true || radioCotx.Checked == true)
					{
						txtA.Enabled = true;
						txtM.Enabled = false;
						txtN.Enabled = false;
						txtP.Enabled = false;
					}
					if (radioSC.Checked == true)
					{
						txtA.Enabled = true;
						txtM.Enabled = true;
						txtN.Enabled = true;
						txtP.Enabled = false;
					}
					if (radioSCBac2.Checked == true)
					{
						txtA.Enabled = true;
						txtM.Enabled = true;
						txtN.Enabled = true;
						txtP.Enabled = true;
					}
					btnGiai.Enabled = true;
					btnLamMoi.Enabled = true;
					txtKQ.Text = "";
					txtX1.Text = "";
					txtX2.Text = "";
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA.Enabled == true && (radioSinx.Checked == true || radioCosx.Checked == true || radioTanx.Checked == true || radioCotx.Checked == true))
			{
				txtA.Text = "0";
			}
			if (txtN.Enabled == true && radioSC.Checked == true)
			{
				txtA.Text = "0";
				txtM.Text = "0";
				txtN.Text = "0";
			}
			if (txtP.Enabled == true && radioSCBac2.Checked == true)
			{
				txtA.Text = "0";
				txtM.Text = "0";
				txtN.Text = "0";
				txtP.Text = "0";
			}


			if (txtA.Text == "0" && (radioSinx.Checked == true || radioCosx.Checked == true || radioTanx.Checked == true || radioCotx.Checked == true))
			{
				btnLamMoi.Enabled = false;
			}
			else if (txtA.Text == "0" && txtM.Text == "0" && txtN.Text == "0" && radioSC.Checked == true)
			{
				btnLamMoi.Enabled = false;
			}
			else if (txtA.Text == "0" && txtM.Text == "0" && txtN.Text == "0" && txtP.Text == "0" && radioSCBac2.Checked == true)
			{
				btnLamMoi.Enabled = false;
			}
			else
			{
				btnLamMoi.Enabled = true;
			}


			if (radioSinx.Checked == true || radioCosx.Checked == true || radioTanx.Checked == true || radioCotx.Checked == true)
			{
				txtA.Enabled = true;
				txtM.Enabled = false;
				txtN.Enabled = false;
				txtP.Enabled = false;
			}
			if (radioSC.Checked == true)
			{
				txtA.Enabled = true;
				txtM.Enabled = true;
				txtN.Enabled = true;
				txtP.Enabled = false;
			}
			if (radioSCBac2.Checked == true)
			{
				txtA.Enabled = true;
				txtM.Enabled = true;
				txtN.Enabled = true;
				txtP.Enabled = true;
			}
			btnGiai.Enabled = true;
			txtKQ.Text = "";
			txtX1.Text = "";
			txtX2.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
