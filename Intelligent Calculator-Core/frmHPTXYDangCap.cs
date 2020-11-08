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
	public partial class frmHPTXYDangCap : Form
	{
		public frmHPTXYDangCap()
		{
			InitializeComponent();
		}

		private void frmHPTXYDangCap_Load(object sender, EventArgs e)
		{
			btnLamMoi.Enabled = false;
		}

		private double lamtron(TextBox tbx, double number)
		{
			number = Convert.ToSingle(tbx.Text);
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
			if ((txtA1.Text == "0") && (txtB1.Text == "0") && (txtC1.Text == "0") && (txtA2.Text == "0") && (txtB2.Text == "0") && (txtC2.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
		}

		private void txtA1_TextChanged(object sender, EventArgs e)
		{
			check(txtA1);
		}

		private void txtB1_TextChanged(object sender, EventArgs e)
		{
			check(txtB1);
		}

		private void txtC1_TextChanged(object sender, EventArgs e)
		{
			check(txtC1);
		}

		private void txtD1_TextChanged(object sender, EventArgs e)
		{
			check(txtD1);
		}

		private void txtA2_TextChanged(object sender, EventArgs e)
		{
			check(txtA2);
		}

		private void txtB2_TextChanged(object sender, EventArgs e)
		{
			check(txtB2);
		}

		private void txtC2_TextChanged(object sender, EventArgs e)
		{
			check(txtC2);
		}

		private void txtD2_TextChanged(object sender, EventArgs e)
		{
			check(txtD2);
		}

		private void txtA1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA1.Text == "0")
			{
				txtA1.Text = "";
			}
		}

		private void txtB1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB1.Text == "0")
			{
				txtB1.Text = "";
			}
		}

		private void txtC1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC1.Text == "0")
			{
				txtC1.Text = "";
			}
		}

		private void txtD1_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtD1.Text == "0")
			{
				txtD1.Text = "";
			}
		}

		private void txtA2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA2.Text == "0")
			{
				txtA2.Text = "";
			}
		}

		private void txtB2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB2.Text == "0")
			{
				txtB2.Text = "";
			}
		}

		private void txtC2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC2.Text == "0")
			{
				txtC2.Text = "";
			}
		}

		private void txtD2_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtD2.Text == "0")
			{
				txtD2.Text = "";
			}
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			if (txtA1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị a1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtB1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị b1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtC1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtD1.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị d1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtA2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị a2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtB2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị b2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtC2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtD2.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị d2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					txtA1.Enabled = false;
					txtB1.Enabled = false;
					txtC1.Enabled = false;
					txtD1.Enabled = false;
					txtA2.Enabled = false;
					txtB2.Enabled = false;
					txtC2.Enabled = false;
					txtD2.Enabled = false;
					btnGiai.Enabled = false;
					btnLamMoi.Enabled = true;

					double a1 = 0;
					double b1 = 0;
					double c1 = 0;
					double d1 = 0;
					double a2 = 0;
					double b2 = 0;
					double c2 = 0;
					double d2 = 0;

					a1 = lamtron(txtA1, a1);
					b1 = lamtron(txtB1, b1);
					c1 = lamtron(txtC1, c1);
					d1 = lamtron(txtD1, d1);
					a2 = lamtron(txtA2, a2);
					b2 = lamtron(txtB2, b2);
					c2 = lamtron(txtC2, c2);
					d2 = lamtron(txtD2, d2);

					txtA1.Text = (a1).ToString();
					txtB1.Text = (b1).ToString();
					txtC1.Text = (c1).ToString();
					txtD1.Text = (d1).ToString();
					txtA2.Text = (a2).ToString();
					txtB2.Text = (b2).ToString();
					txtC2.Text = (c2).ToString();
					txtD2.Text = (d2).ToString();

					if (a1 == 0 | b1 == 0 | c1 == 0 | a2 == 0 | b2 == 0 | c2 == 0)
					{
						MessageBox.Show("Vui lòng nhập các hệ số của biến khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						if (d1 == 0 & d2 != 0)
						{
							double D = b1 * b1 - 4 * a1 * c1;
							if (D < 0)
							{
								txtKQ.Text = "Hệ phương trình vô nghiệm";
							}
							else if (D == 0)
							{
								double t = -b1 / (2 * a1);
								if (a2 * t * t + b2 * t + c2 == 0)
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}

								else if (a2 * t * t + b2 * t + c2 != 0)
								{
									if (d2 / (a2 * t * t + b2 * t + c2) < 0)
									{
										txtKQ.Text = "Hệ phương trình vô nghiệm";
									}
									else if (d2 / (a2 * t * t + b2 * t + c2) > 0)
									{
										double y1 = Math.Sqrt(d2 / (a2 * t * t + b2 * t + c2));
										double y2 = -Math.Sqrt(d2 / (a2 * t * t + b2 * t + c2));
										double x1 = y1 * t;
										double x2 = y2 * t;
										txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
										txtX1.Text = "x = " + x1.ToString();
										txtY1.Text = "y = " + y1.ToString() + "      hoặc";
										txtX2.Text = "x = " + x2.ToString();
										txtY2.Text = "y = " + y2.ToString();
									}
								}
							}
							else
							{
								double t1 = (-b1 + Math.Sqrt(D)) / (2 * a1);
								double t2 = (-b1 - Math.Sqrt(D)) / (2 * a1);
								if (a2 * t1 * t1 + b2 * t1 + c2 == 0)

								{
									if (a2 * t2 * t2 + b2 * t2 + c2 == 0)
									{
										txtKQ.Text = "Hệ phương trình vô nghiệm";
									}
									else
									{
										if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) < 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) > 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}


									}
								}
								else
								{
									if (d2 / (a2 * t1 * t1 + b2 * t1 + c2) < 0)
									{
										if (a2 * t2 * t2 + b2 * t2 + c2 == 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) < 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) > 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}
									}
									else if (d2 / (a2 * t1 * t1 + b2 * t1 + c2) > 0)
									{
										if (a2 * t2 * t2 + b2 * t2 + c2 == 0 | d2 / (a2 * t2 * t2 + b2 * t2 + c2) < 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) > 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double y3 = Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double y4 = -Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double x1 = y1 * t1;
											double x2 = y2 * t1;
											double x3 = y3 * t2;
											double x4 = y4 * t2;
											txtKQ.Text = "Hệ phương trình có 4 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString() + "      hoặc";
											txtX3.Text = "x = " + x3.ToString();
											txtY3.Text = "y = " + y3.ToString() + "      hoặc";
											txtX4.Text = "x = " + x4.ToString();
											txtY4.Text = "y = " + y4.ToString();
										}
									}
								}
							}
						}
						else if (d1 != 0 & d2 == 0)
						{
							double D = b2 * b2 - 4 * a2 * c2;
							if (D < 0)
							{
								txtKQ.Text = "Hệ phương trình vô nghiệm";
							}
							else if (D == 0)
							{
								double t = -b2 / (2 * a2);
								if (a1 * t * t + b1 * t + c1 == 0)
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}

								else if (a1 * t * t + b1 * t + c1 != 0)
								{
									if (d1 / (a1 * t * t + b1 * t + c1) < 0)
									{
										txtKQ.Text = "Hệ phương trình vô nghiệm";
									}
									else if (d1 / (a1 * t * t + b1 * t + c1) > 0)
									{
										double y1 = Math.Sqrt(d1 / (a1 * t * t + b1 * t + c1));
										double y2 = -Math.Sqrt(d1 / (a1 * t * t + b1 * t + c1));
										double x1 = y1 * t;
										double x2 = y2 * t;
										txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
										txtX1.Text = "x = " + x1.ToString();
										txtY1.Text = "y = " + y1.ToString() + "      hoặc";
										txtX2.Text = "x = " + x2.ToString();
										txtY2.Text = "y = " + y2.ToString();
									}
								}
							}
							else
							{
								double t1 = (-b2 + Math.Sqrt(D)) / (2 * a2);
								double t2 = (-b2 - Math.Sqrt(D)) / (2 * a2);
								if (a1 * t1 * t1 + b1 * t1 + c1 == 0)

								{
									if (a1 * t2 * t2 + b1 * t2 + c1 == 0)
									{
										txtKQ.Text = "Hệ phương trình vô nghiệm";
									}
									else
									{
										if (d1 / (a1 * t2 * t2 + b1 * t2 + c1) < 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d1 / (a1 * t2 * t2 + b1 * t2 + c1) > 0)
										{
											double y1 = Math.Sqrt(d1 / (a1 * t2 * t2 + b1 * t2 + c1));
											double y2 = -Math.Sqrt(d1 / (a1 * t2 * t2 + b1 * t2 + c1));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}


									}
								}
								else
								{
									if (d1 / (a1 * t1 * t1 + b1 * t1 + c1) < 0)
									{
										if (a1 * t1 * t2 + b1 * t2 + c1 == 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d1 / (a1 * t2 * t2 + b1 * t2 + c1) < 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d1 / (a1 * t2 * t2 + b1 * t2 + c1) > 0)
										{
											double y1 = Math.Sqrt(d1 / (a1 * t2 * t2 + b1 * t2 + c1));
											double y2 = -Math.Sqrt(d2 / (a1 * t2 * t2 + b1 * t2 + c1));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}
									}
									else if (d1 / (a1 * t1 * t1 + b1 * t1 + c1) > 0)
									{
										if (a1 * t2 * t2 + b1 * t2 + c1 == 0 | d1 / (a1 * t2 * t2 + b1 * t2 + c1) < 0)
										{
											double y1 = Math.Sqrt(d1 / (a1 * t1 * t1 + b1 * t1 + c1));
											double y2 = -Math.Sqrt(d2 / (a1 * t1 * t1 + b1 * t1 + c1));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = x1.ToString();
											txtY1.Text = y1.ToString() + "      hoặc";
											txtX2.Text = x2.ToString();
											txtY2.Text = y2.ToString();
										}
										else if (d1 / (a1 * t2 * t2 + b1 * t2 + c1) > 0)
										{
											double y1 = Math.Sqrt(d1 / (a1 * t1 * t1 + b1 * t1 + c1));
											double y2 = -Math.Sqrt(d1 / (a1 * t1 * t1 + b1 * t1 + c1));
											double y3 = Math.Sqrt(d1 / (a1 * t2 * t2 + b1 * t2 + c1));
											double y4 = -Math.Sqrt(d2 / (a1 * t2 * t2 + b1 * t2 + c1));
											double x1 = y1 * t1;
											double x2 = y2 * t1;
											double x3 = y3 * t2;
											double x4 = y4 * t2;
											txtKQ.Text = "Hệ phương trình có 4 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString() + "      hoặc";
											txtX3.Text = "x = " + x3.ToString();
											txtY3.Text = "y = " + y3.ToString() + "      hoặc";
											txtX4.Text = "x = " + x4.ToString();
											txtY4.Text = "y = " + y4.ToString();
										}
									}
								}
							}
						}
						else if (d1 == 0 & d2 == 0)
						{
							if (a1 / a2 == b1 / b2 & b1 / b2 == c1 / c2)
							{
								txtKQ.Text = "Hệ phương trình có nghiệm đúng với mọi x, y thuộc R";
							}

							else
							{
								double D = b1 * b1 - 4 * a1 * c1;
								if (D < 0)
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
								else if (D == 0)
								{
									double t = -b1 / (2 * a1);
									if (a2 * t * t + b2 * t + c2 == 0)
									{
										txtKQ.Text = "Hệ phương trình có nghiệm đúng với mọi x, y thuộc R";
									}
									else
									{
										txtKQ.Text = "Hệ phương trình có nghiệm";
										txtX1.Text = "0";
										txtY1.Text = "0";
									}
								}
								else
								{
									double t1 = (-b1 + Math.Sqrt(D)) / (2 * a1);
									double t2 = (-b1 - Math.Sqrt(D)) / (2 * a1);
									double m1 = a2 * t1 * t1 + b2 * t1 + c2;
									double m2 = a2 * t2 * t2 + b2 * t2 + c2;
									if (m1 * m2 == 0)
									{
										txtKQ.Text = "Hệ phương trình có nghiệm đúng với mọi x, y thuộc R";
									}
									else
									{
										txtKQ.Text = "Hệ phương trình có nghiệm";
										txtX1.Text = "0";
										txtY1.Text = "0";
									}
								}
							}
						}
						else if (d1 != 0 & d2 != 0)
						{
							a1 = a1 * d2 - a2 * d1;
							b1 = b1 * d2 - b2 * d1;
							c1 = c1 * d2 - c2 * d1;
							d1 = 0;
							double D = b1 * b1 - 4 * a1 * c1;
							if (D < 0)
							{
								txtKQ.Text = "Hệ phương trình vô nghiệm";
							}
							else if (D == 0)
							{
								double t = -b1 / (2 * a1);
								if (a2 * t * t + b2 * t + c2 == 0)
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}

								else if (a2 * t * t + b2 * t + c2 != 0)
								{
									if (d2 / (a2 * t * t + b2 * t + c2) < 0)
									{
										txtKQ.Text = "Hệ phương trình vô nghiệm";
									}
									else if (d2 / (a2 * t * t + b2 * t + c2) > 0)
									{
										double y1 = Math.Sqrt(d2 / (a2 * t * t + b2 * t + c2));
										double y2 = -Math.Sqrt(d2 / (a2 * t * t + b2 * t + c2));
										double x1 = y1 * t;
										double x2 = y2 * t;
										txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
										txtX1.Text = "x = " + x1.ToString();
										txtY1.Text = "y = " + y1.ToString() + "      hoặc";
										txtX2.Text = "x = " + x2.ToString();
										txtY2.Text = "y = " + y2.ToString();
									}
								}
							}
							else
							{
								double t1 = (-b1 + Math.Sqrt(D)) / (2 * a1);
								double t2 = (-b1 - Math.Sqrt(D)) / (2 * a1);
								if (a2 * t1 * t1 + b2 * t1 + c2 == 0)

								{
									if (a2 * t2 * t2 + b2 * t2 + c2 == 0)
									{
										txtKQ.Text = "Hệ phương trình vô nghiệm";
									}
									else
									{
										if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) < 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) > 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}


									}
								}
								else
								{
									if (d2 / (a2 * t1 * t1 + b2 * t1 + c2) < 0)
									{
										if (a2 * t2 * t2 + b2 * t2 + c2 == 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) < 0)
										{
											txtKQ.Text = "Hệ phương trình vô nghiệm";
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) > 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}
									}
									else if (d2 / (a2 * t1 * t1 + b2 * t1 + c2) > 0)
									{
										if (a2 * t2 * t2 + b2 * t2 + c2 == 0 | d2 / (a2 * t2 * t2 + b2 * t2 + c2) < 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double x1 = y1 * t2;
											double x2 = y2 * t2;
											txtKQ.Text = "Hệ phương trình có 2 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString();
										}
										else if (d2 / (a2 * t2 * t2 + b2 * t2 + c2) > 0)
										{
											double y1 = Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double y2 = -Math.Sqrt(d2 / (a2 * t1 * t1 + b2 * t1 + c2));
											double y3 = Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double y4 = -Math.Sqrt(d2 / (a2 * t2 * t2 + b2 * t2 + c2));
											double x1 = y1 * t1;
											double x2 = y2 * t1;
											double x3 = y3 * t2;
											double x4 = y4 * t2;
											txtKQ.Text = "Hệ phương trình có 4 cặp nghiệm";
											txtX1.Text = "x = " + x1.ToString();
											txtY1.Text = "y = " + y1.ToString() + "      hoặc";
											txtX2.Text = "x = " + x2.ToString();
											txtY2.Text = "y = " + y2.ToString() + "      hoặc";
											txtX3.Text = "x = " + x3.ToString();
											txtY3.Text = "y = " + y3.ToString() + "      hoặc";
											txtX4.Text = "x = " + x4.ToString();
											txtY4.Text = "y = " + y4.ToString();
										}
									}
								}
							}
						}
					}

				}
				catch (Exception)
				{
					txtA1.Enabled = true;
					txtB1.Enabled = true;
					txtC1.Enabled = true;
					txtD1.Enabled = true;
					txtA2.Enabled = true;
					txtB2.Enabled = true;
					txtC2.Enabled = true;
					txtD2.Enabled = true;
					btnGiai.Enabled = true;
					btnLamMoi.Enabled = true;
					MessageBox.Show("Đã có lỗi xảy ra! \r\nCó thể bạn đã nhập kí tự không phải là số,...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			if (txtA1.Enabled == true)
			{
				txtA1.Text = "0";
				txtB1.Text = "0";
				txtC1.Text = "0";
				txtD1.Text = "0";
				txtA2.Text = "0";
				txtB2.Text = "0";
				txtC2.Text = "0";
				txtD2.Text = "0";
			}

			if ((txtA1.Text == "0") && (txtB1.Text == "0") && (txtC1.Text == "0") && (txtD1.Text == "0") && (txtA2.Text == "0") && (txtB2.Text == "0") && (txtC2.Text == "0") && (txtD2.Text == "0"))
				btnLamMoi.Enabled = false;
			else
				btnLamMoi.Enabled = true;
			txtA1.Enabled = true;
			txtB1.Enabled = true;
			txtC1.Enabled = true;
			txtD1.Enabled = true;
			txtA2.Enabled = true;
			txtB2.Enabled = true;
			txtC2.Enabled = true;
			txtD2.Enabled = true;
			txtKQ.Text = "";
			txtX1.Text = "";
			txtY1.Text = "";
			txtX2.Text = "";
			txtY2.Text = "";
			txtX3.Text = "";
			txtY3.Text = "";
			txtX4.Text = "";
			txtY4.Text = "";
			btnGiai.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
