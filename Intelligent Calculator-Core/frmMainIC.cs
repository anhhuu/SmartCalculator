using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelligent_Calculator_Core
{
	public partial class frmMainIC : Form
	{
		public frmMainIC()
		{
			InitializeComponent();
		}

		private void IntelligentCalculator_Load(object sender, EventArgs e)
		{
			rdDeg.Checked = true;
			//SetBounds(Screen.GetWorkingArea(this).Width * 5 / 100, Screen.GetWorkingArea(this).Height * 20 / 100, Width, Height);
		}

		//public static Double Mem = 0;
		public static Double tKQ = 0;
		public static Double ans = 0;
		public static frmDaoHam dhf = new frmDaoHam();
		public static frmTichPhan tpf = new frmTichPhan();
		public static frmChinhHop ch = new frmChinhHop();
		public static frmToHop th = new frmToHop();
		public static Logax logaxf = new Logax();
		private bool daTinh = false;

		private const double PI = 3.14159265358979;

		private void phepKhac()
		{
			tbScr.Text = "";
			tbView.Text = "";
			daTinh = false;
		}

		private void tinhTiep()
		{
			tbView.Text = "";
			daTinh = false;
		}

		public void changebtX(object sender, EventArgs e)
		{
			this.btX.Enabled = !this.btX.Enabled;
		}
		public void disX(object sender, EventArgs e)
		{
			this.btX.Enabled = false;
		}
		public void enaX(object sender, EventArgs e)
		{
			this.btX.Enabled = true;
		}
		public void tbScr_add(string s)
		{
			if (tbScr.Text == "0") tbScr.Text = "";
			tbScr.Text += s;
		}
		public void tbNow_add(string s)
		{
			if (total.Where_add == 1) tbScr_add(s);
			else if (total.Where_add == 2)
			{
				dhf.tbFx_add(s);
			}
			else if (total.Where_add == 3)
			{
				tpf.tbFx_add(s);
			}
		}
		private void btDot_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			double test = double.Parse(lblTest.Text);
			if (test == 1503)
			{
				tbNow_add(",");
			}

			if (test == 15.03)
			{
				tbNow_add(".");
			}
		}

		private void btNum0_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("0");
		}

		private void btNum1_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("1");
		}

		private void btNum2_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("2");
		}

		private void btNum3_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("3");
		}

		private void btNum4_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("4");
		}

		private void btNum5_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("5");
		}

		private void btNum6_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("6");
		}

		private void btNum7_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("7");
		}

		private void btNum8_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("8");
		}
		private void btNum9_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("9");
		}
		private void btX_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("x");
		}

		private void btPi_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add(PI.ToString());
		}

		private void btAns_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("(" + ans.ToString() + ")");
		}

		public Double Canbac3(Double x)
		{
			if (daTinh)
			{
				phepKhac();
			}
			Double a, f = 0;
			a = x;
			if (a == 0) f = 0;
			else if (a > 0) f = Math.Exp((1.0 / 3) * Math.Log(a));
			else if (a < 0) f = -Math.Exp((1.0 / 3) * Math.Log(-a));
			return f;
		}

		public void Nhanketquadh(object sender, EventArgs e)
		{
			if (dhf._visibleDhf) tbScr_add(dhf._kqdh.Text);
		}

		public void Nhanketquatp(object sender, EventArgs e)
		{
			if (tpf._visibleTpf) tbScr_add(tpf._kqtp.Text);
		}

		public void Nhanketquach(object sender, EventArgs e)
		{
			if (ch._visibleCh) tbScr_add(ch._kqch.Text);
		}

		public void Nhanketquath(object sender, EventArgs e)
		{
			if (th._visibleTh) tbScr_add(th._kqth.Text);
		}

		private void btDaoham_Click(object sender, EventArgs e)
		{
			if (!total.showDhf)
			{
				dhf.btTruyenkqdh_clicked += new EventHandler(Nhanketquadh);
				dhf.btNhapdh_clicked_true += new EventHandler(enaX);
				dhf.btNhapdh_clicked_false += new EventHandler(disX);
				dhf.Show();
			}
		}
		private void btTichphan_Click(object sender, EventArgs e)
		{
			if (!total.showTpf)
			{
				tpf.btTruyenkqtp_clicked += new EventHandler(Nhanketquatp);
				tpf.btNhaptp_clicked_true += new EventHandler(enaX);
				tpf.btNhaptp_clicked_false += new EventHandler(disX);
				tpf.Show();
			}
		}

		private void btChinhHop_Click(object sender, EventArgs e)
		{
			if (!total.showCh)
			{
				ch.btTruyenkqch_clicked += new EventHandler(Nhanketquach);
				ch.Show();
			}
		}

		private void btToHop_Click(object sender, EventArgs e)
		{
			th.btTruyenkqth_clicked += new EventHandler(Nhanketquath);
			th.Show();
		}

		private void btCong_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				tinhTiep();
			}
			tbNow_add("+");
		}

		private void btTru_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				tinhTiep();
			}
			tbNow_add("-");
		}

		private void btNhan_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				tinhTiep();
			}
			tbNow_add("*");
		}

		private void btChia_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				tinhTiep();
			}
			tbNow_add("÷");
		}
		private void btNgoacMo_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("(");
		}
		private void btNgoacDong_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add(")");
		}
		private void btCan2_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("sqrt(");
		}
		private void btSqrt3_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("sqrt3(");
		}
		private void btLuythua_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				tinhTiep();
			}
			tbNow_add("^(");
		}
		private void btGiaithua_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				tinhTiep();
			}
			tbScr.Text += "!";
		}
		private void btLn_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("ln(");
		}
		private void btLog10_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			tbNow_add("log(");
		}
		public static Boolean ArcEnable = false;
		private void btSin_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			if (!ArcEnable) tbNow_add("sin(");
			else tbNow_add("arcsin(");
		}
		private void btCos_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			if (!ArcEnable) tbNow_add("cos(");
			else tbNow_add("arccos(");
		}

		private void btTan_Click(object sender, EventArgs e)
		{
			if (daTinh)
			{
				phepKhac();
			}
			if (!ArcEnable) tbNow_add("tan(");
			else tbNow_add("arctan(");
		}

		private void btArc_Click(object sender, EventArgs e)
		{
			if (!ArcEnable) ArcEnable = true;
			else ArcEnable = false;
			if (!ArcEnable)
			{
				this.btArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btArc.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
				this.btSin.Text = "sin";
				this.btCos.Text = "cos";
				this.btTan.Text = "tan";
			}
			else
			{
				this.btArc.BackColor = System.Drawing.Color.DarkSlateBlue;
				this.btSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btSin.Text = "arcsin";
				this.btCos.Text = "arccos";
				this.btTan.Text = "arctan";
			}
		}

		private void checkMaxValue(double value)
		{
			if (value >= double.MaxValue || value <= double.MinValue)
			{
				disabledButton();
				tbScr.Text = "Overflow";
			}
			else
			{
				tbScr.Text = value.ToString();
			}
		}

		private void disabledButton()
		{
			btArc.Enabled = false;
			btAns.Enabled = false;
			btBang.Enabled = false;
			btCan2.Enabled = false;
			btChia.Enabled = false;
			btChinhHop.Enabled = false;
			btClear.Enabled = false;
			btCong.Enabled = false;
			btCos.Enabled = false;
			btDaoham.Enabled = false;
			btDot.Enabled = false;
			btGiaithua.Enabled = false;
			btLn.Enabled = false;
			btLog10.Enabled = false;
			btLogax.Enabled = false;
			btLuythua.Enabled = false;
			btNgoacDong.Enabled = false;
			btNgoacMo.Enabled = false;
			btNhan.Enabled = false;
			btNum0.Enabled = false;
			btNum1.Enabled = false;
			btNum2.Enabled = false;
			btNum3.Enabled = false;
			btNum4.Enabled = false;
			btNum5.Enabled = false;
			btNum6.Enabled = false;
			btNum7.Enabled = false;
			btNum8.Enabled = false;
			btNum9.Enabled = false;
			btPi.Enabled = false;
			btSin.Enabled = false;
			btSqrt3.Enabled = false;
			btTan.Enabled = false;
			btTru.Enabled = false;
			btTichphan.Enabled = false;
			btToHop.Enabled = false;
			btX.Enabled = false;
			btXoa.Enabled = false;
			rdDeg.Visible = false;
			rdRad.Visible = false;
			btXoaHet.FlatAppearance.BorderSize = 1;
			//btXoaHet.Enabled = false;
		}

		private void enabledButton()
		{
			btArc.Enabled = true;
			btAns.Enabled = true;
			btBang.Enabled = true;
			btCan2.Enabled = true;
			btChia.Enabled = true;
			btChinhHop.Enabled = true;
			btClear.Enabled = true;
			btCong.Enabled = true;
			btCos.Enabled = true;
			btDaoham.Enabled = true;
			btDot.Enabled = true;
			btGiaithua.Enabled = true;
			btLn.Enabled = true;
			btLog10.Enabled = true;
			btLogax.Enabled = true;
			btLuythua.Enabled = true;
			btNgoacDong.Enabled = true;
			btNgoacMo.Enabled = true;
			btNhan.Enabled = true;
			btNum0.Enabled = true;
			btNum1.Enabled = true;
			btNum2.Enabled = true;
			btNum3.Enabled = true;
			btNum4.Enabled = true;
			btNum5.Enabled = true;
			btNum6.Enabled = true;
			btNum7.Enabled = true;
			btNum8.Enabled = true;
			btNum9.Enabled = true;
			btPi.Enabled = true;
			btSin.Enabled = true;
			btSqrt3.Enabled = true;
			btTan.Enabled = true;
			btTru.Enabled = true;
			btTichphan.Enabled = true;
			btToHop.Enabled = true;
			btX.Enabled = true;
			btXoa.Enabled = true;
			rdDeg.Visible = true;
			rdRad.Visible = true;
			btXoaHet.FlatAppearance.BorderSize = 0;
			//btXoaHet.Enabled = false;
		}

		public static Double giaithua(Double n)
		{
			Double tam = 1;
			n = Convert.ToInt16(n);
			if (n == 0) return 1;
			for (int i = 1; i <= n; i++)
			{
				tam *= i;
			}
			tam = Convert.ToDouble(tam);
			return tam;
		}
		public static int UuTien(string c)
		{
			if (c == "canba" || c == "sqrt" || c == "^" || c == "ln" || c == "logax" || c == "log" || c == "sin" || c == "cos" || c == "tan" || c == "arcsin" || c == "arccos" || c == "arctan")
				return 4;
			if (c == "!")
				return 3;
			if (c == "*" || c == "/")
				return 2;
			if (c == "+" || c == "-")
				return 1;
			return 0;
		}
		public static void txtFormat(ref string s)
		{
			s = s.Replace(" ", "");
			s = Regex.Replace(s, @"\)(\d|logax|log|ln|sin|cos|tan|arcsin|arccos|arctan|sqrt|canba)", match => match.Value[0].ToString() + "*" + match.Value.ToString().Remove(0, 1));
			s = Regex.Replace(s, @"\d(\(|logax|log|ln|sin|cos|tan|arcsin|arccos|arctan|sqrt|canba)", match => match.Value[0].ToString() + "*" + match.Value.ToString().Remove(0, 1));
			s = Regex.Replace(s, @"\+|\-|\*|\/|\^{3, }", match => match.Value[0].ToString());
			s = Regex.Replace(s, @"(\+|\-|\*|\/|\^)(\+|\*|\/|\^)", match => match.Value[0].ToString());
			s = Regex.Replace(s, @"\+|\-|\*|\/|\^|\)|\(|logax|log|ln|sin|cos|tan|arcsin|arccos|arctan|sqrt|canba|!", match => String.Format(" {0} ", match.Value));
			s = s.Replace("  ", " ");
			s = s.Trim();
		}
		private static bool ToanTu(string s)
		{
			return Regex.Match(s, @"^(\+|\-|\*|\/|sqrt|\^|sin|cos|tan|arcsin|arccos|arctan|log|ln|logax|canba|!)$").Success;
		}
		private static bool ToanHang(string s)
		{
			return Regex.Match(s, @"^\d+$|^\d+\.+\d+$|π|^\d+$|^\d+\.+\d+π$|\d+π$").Success;
		}
		public static string TTo2HTo(string s)
		{
			txtFormat(ref s);
			if (s[0] == '-') s = "0 " + s;
			string[] str = s.Split(' ');
			Stack<string> stack = new Stack<string>();
			StringBuilder pfout = new StringBuilder();

			for (int i = 0; i < str.Length; i++)
			{
				string tok = str[i];
				if (ToanTu(tok))
				{
					if (tok == "!" && ((i < (str.Length - 1) && ToanTu(str[i + 1])) || i == str.Length - 1))
					{
						stack.Push(tok);
					}
					else if (i > 0 && ((ToanTu(str[i - 1]) && str[i - 1] != "!") || str[i - 1] == "("))
					{
						if (tok == "-")
						{
							pfout.Append(tok + str[i + 1]).Append(" ");
							i++;
						}
						else if (tok == "ln" || tok == "logax" || tok == "log" || tok == "canba" || tok == "sqrt" || tok == "^" || tok == "sin" || tok == "cos" || tok == "tan" || tok == "arcsin" || tok == "arccos" || tok == "arctan")
						{
							stack.Push(tok);
						}
					}
					else// ToanTu
					{
						while (stack.Count > 0 && UuTien(tok) <= UuTien(stack.Peek()))
							pfout.Append(stack.Pop()).Append(" ");
						stack.Push(tok);
					}
				}
				else if (tok == "(")
				{
					stack.Push(tok);
				}
				else if (tok == ")")
				{
					string x = stack.Pop();
					while (x != "(")
					{
						pfout.Append(x).Append(" ");
						x = stack.Pop();
					}
				}
				else
				{
					pfout.Append(tok).Append(" ");
				}
			}

			while (stack.Count > 0)
				pfout.Append(stack.Pop()).Append(" ");

			return pfout.ToString();
		}
		public double tinhpf(string s)
		{
			Stack<double> stack = new Stack<double>();
			s = s.Trim();
			IList<string> str = s.Split(' ');
			try
			{
				foreach (string c in str)
				{
					if (ToanTu(c))
					{
						double x = stack.Pop();
						if (c == "!" || c == "ln" || c == "log" || c == "canba" || c == "sqrt" || c == "sin" || c == "cos" || c == "tan" || c == "arcsin" || c == "arccos" || c == "arctan")
							switch (c)
							{
								case "sqrt":
									if (x >= 0)
									{
										x = Math.Sqrt(x);
										stack.Push(x);
									}
									break;

								case "canba": x = Canbac3(x); stack.Push(x); break;
								case "ln": x = Math.Log(x); stack.Push(x); break;
								case "log": x = Math.Log(x, 10); stack.Push(x); break;

								case "sin":
									if (rdDeg.Checked)
									{
										if (x % 180 == 0)
										{
											x = 0;
										}
										else
										{
											x = ((x * PI) / 180);
											x = Math.Sin(x);
										}
										stack.Push(x);
									}
									else
									{
										if ((int)(x % PI) == 0)
										{
											x = 0;
										}
										else
										{
											x = Math.Sin(x);
										}
										stack.Push(x);
									}
									break;

								case "cos":
									if (rdDeg.Checked)
									{
										if ((x - 90) % 180 == 0)
										{
											x = 0;
										}
										else
										{
											x = ((x * PI) / 180);
											x = Math.Cos(x);
										}
										stack.Push(x);
									}
									else
									{
										if ((x - PI / 2) % PI == 0)
										{
											x = 0;
										}
										else
										{
											x = Math.Cos(x);
										}
										stack.Push(x);
									}
									break;

								case "tan":
									if (rdDeg.Checked)
									{
										if ((x - 90) % 180 == 0)
										{
											x = 0;
										}
										else
										{
											x = ((x * PI) / 180);
											x = Math.Tan(x);
											stack.Push(x);
										}
									}
									else
									{
										if ((x - (PI / 2) % PI) == 0)
										{
											x = 0;
										}
										else
										{
											x = Math.Tan(x);
											stack.Push(x);
										}
									}
									break;

								case "arcsin":
									if (x >= -1 && x <= 1)
									{
										if (rdDeg.Checked)
										{
											x = Math.Asin(x);
											stack.Push((x * 180) / Math.PI);
										}
										else
										{
											x = Math.Asin(x);
											stack.Push(x);
										}
									}
									break;
								case "arccos":
									if (x >= -1 && x <= 1)
									{
										if (rdDeg.Checked)
										{
											x = Math.Acos(x);
											stack.Push((x * 180) / Math.PI);
										}
										else
										{
											x = Math.Acos(x);
											stack.Push(x);
										}
									}
									break;
								case "arctan":
									if (rdDeg.Checked)
									{
										x = Math.Atan(x);
										stack.Push((x * 180) / Math.PI);
									}
									else
									{
										x = Math.Atan(x);
										stack.Push(x);
									}
									break;
								case "!": x = giaithua(x); stack.Push(x); break;
							}
						else
						{
							double y = stack.Pop();
							switch (c)
							{
								case "+": y += x; stack.Push(y); break;
								case "-": y -= x; stack.Push(y); break;
								case "*": y *= x; stack.Push(y); break;
								case "/":
									if (x == 0)
									{
										y = 0;
									}
									else
									{
										y /= x;
										stack.Push(y);
									}
									break;
								case "^": y = Math.Pow(y, x); stack.Push(y); break;
								case "logax": y = Math.Log(x, y); stack.Push(y); break;
							}
						}
					}
					else
					{
						stack.Push(double.Parse(c));
					}
				}
				return stack.Pop();
			}
			catch
			{
				tbView.Text = "";
				MessageBox.Show("Phát hiện lỗi từ biểu thức nhập vào. Vui lòng nhập lại!\nHãy chắc chắn bạn đã nhập đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tpf.thuchien = false;
			}
			return 0;
		}
		public Double tinhKQ(string s)
		{
			Double t = 0;
			char[] cTrim = { '+', 'x', '÷', ' ' };
			s = s.Trim(cTrim);
			s = s.Replace("÷", "/");
			s = s.Replace(")(", ")*(");
			s = s.Replace("sqrt3", "canba");
			if (s != "")
			{
				//txtFormat(ref s);
				s = TTo2HTo(s);
				//tbScr.Text = s; //Xem ket qua sau khi chuyen
				t = tinhpf(s);
			}
			daTinh = true;
			return t;
		}
		private void btBang_Click(object sender, EventArgs e)
		{
			//String atbScrText = tinhKQ(tbScr.Text).ToString();
			try
			{
				if (total.Where_add == 1)
				{
					tbView.Text = tbScr.Text + " = ";
					double kq = tinhKQ(tbScr.Text);
					ans = kq;
					checkMaxValue(kq);
				}
				else if (total.Where_add == 2)
					dhf.btKqdh_Click(sender, e);
				else if (total.Where_add == 3)
					tpf.btKqtp_Click(sender, e);
			}
			catch
			{
				tbView.Text = "";
			}
		}

		private void btXoa_Click(object sender, EventArgs e)
		{
			if (!daTinh)
			{
				if (total.Where_add == 1 && !daTinh)
				{
					if (tbScr.Text.Length > 0)
					{
						tbScr.Text = tbScr.Text.Remove(tbScr.Text.Length - 1, 1);
					}
					if (tbScr.Text.Length == 0)
					{
						tbScr.Text = "0";
					}
				}
				else if (total.Where_add == 2)
				{
					dhf.Xoa();
				}
				else if (total.Where_add == 3)
				{
					tpf.Xoa();
				}
			}
		}
		private void btXoaHet_Click(object sender, EventArgs e)
		{
			if (!btArc.Enabled)
			{
				enabledButton();
			}
			if (total.Where_add == 1)
			{
				tbView.Text = "";
				tbScr.Text = "0";
				tKQ = 0;

			}
			else if (total.Where_add == 2)
			{
				dhf.Xoahet();
			}
			else if (total.Where_add == 3)
			{
				tpf.Xoahet();
			}
		}
		private void btClear_Click(object sender, EventArgs e)
		{
			if (total.Where_add == 1)
			{
				tbScr.Text = "0";
				tbView.Text = "";
			}
			else if (total.Where_add == 2)
			{
				dhf.Xoahet();
			}
			else if (total.Where_add == 3)
			{
				tpf.Xoahet();
			}
		}
		//public static string dec2oct(string s)
		//{
		//	int t = Convert.ToInt32(s);
		//	s = Convert.ToString(t, 8);
		//	return s;
		//}
		//public static string dec2bin(string s)
		//{
		//	int t = Convert.ToInt32(s);
		//	s = Convert.ToString(t, 2);
		//	return s;
		//}
		//public static string dec2hex(string s)
		//{
		//	int t = Convert.ToInt32(s);
		//	s = Convert.ToString(t, 16);
		//	s = s.ToUpper();
		//	return s;
		//}
		//public static string hex2dec(string s)
		//{
		//	int t = Convert.ToInt32(s, 16);
		//	s = t.ToString();
		//	return s;
		//}
		//public static string bin2dec(string s)
		//{
		//	int t = Convert.ToInt32(s, 2);
		//	s = t.ToString();
		//	return s;
		//}
		//public static string oct2dec(string s)
		//{
		//	int t = Convert.ToInt32(s, 8);
		//	s = t.ToString();
		//	return s;
		//}

		public void Nhanlogax(object sender, EventArgs e)
		{
			tbNow_add(String.Format("logax({0})(", logaxf._Cosoa.Text));
		}
		private void btLogax_Click(object sender, EventArgs e)
		{
			if (!total.showLogaxf)
			{
				logaxf.btTruyenlogax_clicked += new EventHandler(Nhanlogax);
				logaxf.Show();
				total.showLogaxf = true;
			}
		}

		private void giaiPTB1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPTB1 ptb1 = new frmPTB1();
			ptb1.ShowDialog();
		}

		private void giaiPTB2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPTB2 ptb2 = new frmPTB2();
			ptb2.ShowDialog();
		}

		private void giaiPTB3ToolStripMenuItemtripMenuItem_Click(object sender, EventArgs e)
		{
			frmPTB3 ptb3 = new frmPTB3();
			ptb3.ShowDialog();
		}

		private void giaiPTB4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPTB4 ptb4 = new frmPTB4();
			ptb4.ShowDialog();
		}

		private void giaiPTLGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPTLG ptlg = new frmPTLG();
			ptlg.ShowDialog();
		}

		private void giaiHPT2AnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHPTXY hptxy = new frmHPTXY();
			hptxy.ShowDialog();
		}

		private void giaiHPT3AnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHPTXYZ hptxyz = new frmHPTXYZ();
			hptxyz.ShowDialog();
		}

		private void giaiHPTDangCapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHPTXYDangCap hptdc = new frmHPTXYDangCap();
			hptdc.ShowDialog();
		}

		private void giaiBPT21ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBPTB21 bpt21 = new frmBPTB21();
			bpt21.ShowDialog();
		}

		private void giaiBPT22ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBPTB22 bpt22 = new frmBPTB22();
			bpt22.ShowDialog();
		}

		private void giaiBPT31ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBPTB31 bpt31 = new frmBPTB31();
			bpt31.ShowDialog();
		}

		private void giaiBPT32ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBPTB32 bpt32 = new frmBPTB32();
			bpt32.ShowDialog();
		}

		private void giaiBPT41ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBPTB41 bpt41 = new frmBPTB41();
			bpt41.ShowDialog();
		}

		private void giaiBPT42ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBPTB42 bpt42 = new frmBPTB42();
			bpt42.ShowDialog();
		}

		private void phanSoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPhanSo pt = new frmPhanSo();
			pt.ShowDialog();
		}

		private void honSoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHonSo ht = new frmHonSo();
			ht.ShowDialog();
		}

		private void chiaB2ChoB1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmB2ChiaB1 b2chiab1 = new frmB2ChiaB1();
			b2chiab1.ShowDialog();
		}

		private void chiaB3ChoB1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmB3ChiaB1 b3chiab1 = new frmB3ChiaB1();
			b3chiab1.ShowDialog();
		}

		private void chiaB4ChoB1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmB3ChiaB1 b3chiab1 = new frmB3ChiaB1();
			b3chiab1.ShowDialog();
		}

		private void timUCLNBCNNToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUCLN_BCNN uclnbcnn = new frmUCLN_BCNN();
			uclnbcnn.ShowDialog();
		}

		private void kiemTraSNTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSNT snt = new frmSNT();
			snt.ShowDialog();
		}

		private void nhiThucNewtonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNhiThuc ntnt = new frmNhiThuc();
			ntnt.ShowDialog();
		}

		private void timCTTQToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCTTQ cttq = new frmCTTQ();
			cttq.ShowDialog();
		}

		private void chuyenDoiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmChuyenDoi cd = new frmChuyenDoi();
			cd.ShowDialog();
		}

		private void timCTCDHamB2B3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMinMaxHS minmaxhs = new frmMinMaxHS();
			minmaxhs.ShowDialog();
		}

		private void khaoSatHamSoToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void veDoThiHamSoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMainDoThi mn = new frmMainDoThi();
			mn.ShowDialog();
		}

		private void saoChepToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(tbScr.Text);
		}

		private void catToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(tbScr.Text);
			tbScr.Text = "0";
		}

		private void danToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tbScr.Text += Clipboard.GetText();
		}

		private void degToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (rdRad.Checked)
			{
				rdRad.Checked = false;
				rdDeg.Checked = true;
				radToolStripMenuItem.Checked = false;
				degToolStripMenuItem.Checked = true;
			}
		}

		private void radToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (rdDeg.Checked)
			{
				rdRad.Checked = true;
				rdDeg.Checked = false;
				radToolStripMenuItem.Checked = true;
				degToolStripMenuItem.Checked = false;
			}
		}

		private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmThongTin tt = new frmThongTin();
			tt.ShowDialog();
		}

		private void huongDanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Liên hệ tác giả để biết thêm chi tiết. (Email: panhhuu@gmail.com)", "Hướng Dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void rdDeg_CheckedChanged(object sender, EventArgs e)
		{
			radToolStripMenuItem.Checked = false;
			degToolStripMenuItem.Checked = true;
		}

		private void rdRad_CheckedChanged(object sender, EventArgs e)
		{
			radToolStripMenuItem.Checked = true;
			degToolStripMenuItem.Checked = false;
		}
	}

	public class total
	{
		public static Boolean showDhf = false;
		public static Boolean showCh = false;
		public static Boolean showTh = false;
		public static Boolean showTpf = false;
		public static Boolean showLogaxf = false;
		public static Boolean showEqnf = false;
		public static Int32 Where_add = 1;
	}
}
