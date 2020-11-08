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
	public partial class frmHPTXYZ : Form
	{
		public frmHPTXYZ()
		{
			InitializeComponent();
		}

		private void frmHPTXYZ_Load(object sender, EventArgs e)
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
		private void txtA3_TextChanged(object sender, EventArgs e)
		{
			check(txtA3);
		}

		private void txtB3_TextChanged(object sender, EventArgs e)
		{
			check(txtB3);
		}

		private void txtC3_TextChanged(object sender, EventArgs e)
		{
			check(txtC3);
		}

		private void txtD3_TextChanged(object sender, EventArgs e)
		{
			check(txtD3);
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

		private void txtA3_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtA3.Text == "0")
			{
				txtA3.Text = "";
			}
		}

		private void txtB3_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtB3.Text == "0")
			{
				txtB3.Text = "";
			}
		}

		private void txtC3_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtC3.Text == "0")
			{
				txtC3.Text = "";
			}
		}

		private void txtD3_MouseUp(object sender, MouseEventArgs e)
		{
			if (txtD3.Text == "0")
			{
				txtD3.Text = "";
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
			else if (txtA3.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị a3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtB3.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị b3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtC3.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị c3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtD3.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị d3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
					txtA3.Enabled = false;
					txtB3.Enabled = false;
					txtC3.Enabled = false;
					txtD3.Enabled = false;
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
					double a3 = 0;
					double b3 = 0;
					double c3 = 0;
					double d3 = 0;

					a1 = lamtron(txtA1, a1);
					b1 = lamtron(txtB1, b1);
					c1 = lamtron(txtC1, c1);
					d1 = lamtron(txtD1, d1);
					a2 = lamtron(txtA2, a2);
					b2 = lamtron(txtB2, b2);
					c2 = lamtron(txtC2, c2);
					d2 = lamtron(txtD2, d2);
					a3 = lamtron(txtA3, a3);
					b3 = lamtron(txtB3, b3);
					c3 = lamtron(txtC3, c3);
					d3 = lamtron(txtD3, d3);

					txtA1.Text = (a1).ToString();
					txtB1.Text = (b1).ToString();
					txtC1.Text = (c1).ToString();
					txtD1.Text = (d1).ToString();
					txtA2.Text = (a2).ToString();
					txtB2.Text = (b2).ToString();
					txtC2.Text = (c2).ToString();
					txtD2.Text = (d2).ToString();
					txtA3.Text = (a3).ToString();
					txtB3.Text = (b3).ToString();
					txtC3.Text = (c3).ToString();
					txtD3.Text = (d3).ToString();

					if (c1 * c1 + c2 * c2 == 0)
					{
						double dx = d1 * b2 - d2 * b1;
						double dy = a1 * d2 - a2 * d1;
						double d = a1 * b2 - a2 * b1;
						if (d == 0 & dx == 0 & dy == 0)
						{
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dx * dx + dy * dy != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double x = dx / d;
							double y = dy / d;
							if (c3 == 0)
							{
								if (a3 * x + b3 * y == d3)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = " + x.ToString();
									txtY.Text = " y = " + y.ToString();
									txtZ.Text = " z = R";
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double z = (d3 - a3 * x - b3 * y) / c3;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dx * dx + dy * dy != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double x = dx / d;
							double y = dy / d;
							if (c2 == 0)
							{
								if (a2 * x + b2 * y == d2)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = " + x.ToString();
									txtY.Text = " y = " + y.ToString();
									txtZ.Text = " z = R ";
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double z = (d2 - a2 * x - b2 * y) / c2;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dx * dx + dy * dy != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double x = dx / d;
							double y = dy / d;
							if (c1 == 0)
							{
								if (a1 * x + b1 * y == d1)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = " + x.ToString();
									txtY.Text = " y = " + y.ToString();
									txtZ.Text = " z = R ";
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double z = (d1 - a1 * x - b1 * y) / c1;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dx * dx + dz * dz != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double x = dx / d;
							double z = dz / d;
							if (b3 == 0)
							{
								if (a3 * x + c3 * z == d3)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = " + x.ToString();
									txtY.Text = " y = R ";
									txtZ.Text = " z = " + z.ToString();
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double y = (d3 - a3 * x - c3 * z) / b3;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dx * dx + dz * dz != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double x = dx / d;
							double z = dz / d;
							if (b2 == 0)
							{
								if (a2 * x + c2 * z == d2)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = " + x.ToString();
									txtY.Text = " y = R ";
									txtZ.Text = " z = " + z.ToString();
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double y = (d2 - a2 * x - c2 * z) / b2;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dx * dx + dz * dz != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double x = dx / d;
							double z = dz / d;
							if (b1 == 0)
							{
								if (a1 * x + c1 * z == d1)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = " + x.ToString();
									txtY.Text = " y = R ";
									txtZ.Text = " z = " + z.ToString();
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double y = (d1 - a1 * x - c1 * z) / b1;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dy * dy + dz * dz != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double y = dy / d;
							double z = dz / d;
							if (a3 == 0)
							{
								if (b3 * y + c3 * z == d3)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = R ";
									txtY.Text = " y = " + y.ToString();
									txtZ.Text = " z = " + z.ToString();
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double x = (d3 - b3 * y - c3 * z) / a3;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dy * dy + dz * dz != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double y = dy / d;
							double z = dz / d;
							if (a2 == 0)
							{
								if (b2 * y + c2 * z == d2)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = R ";
									txtY.Text = " y = " + y.ToString();
									txtZ.Text = " z = " + z.ToString();
								}
								else
								{
									txtKQ.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double x = (d2 - b2 * y - c2 * z) / a2;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
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
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if ((d == 0) & (dy * dy + dz * dz != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (d != 0)
						{
							double y = dy / d;
							double z = dz / d;
							if (a1 == 0)
							{
								if (b1 * y + c1 * z == d1)
								{
									txtKQ.Text = "Hệ phương trình có nghiệm";
									txtX.Text = " x = R ";
									txtY.Text = " y = " + y.ToString();
									txtZ.Text = " z = " + z.ToString();
								}
								else
								{
									txtX.Text = "Hệ phương trình vô nghiệm";
								}
							}
							else
							{
								double x = (d1 - b1 * y - c1 * z) / a1;
								txtKQ.Text = "Hệ phương trình có nghiệm";
								txtX.Text = " x = " + x.ToString();
								txtY.Text = " y = " + y.ToString();
								txtZ.Text = " z = " + z.ToString();
							}
						}
					}
					else if (c1 == 0)
					{
						double a = a2 * c3 - a3 * c2;
						double b = b2 * c3 - b3 * c2;
						double d = d2 * c3 - d3 * c2;
						double dx = d * b1 - b * d1;
						double dy = a * d1 - a1 * d;
						double D = a * b1 - a1 * b;
						if (D == 0 & (dx * dx + dy * dy == 0))
						{
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if (D == 0 & (dx * dx + dy * dy != 0))
						{
							txtX.Text = "Hệ phương trình vô nghiệm";
						}
						else if (D != 0)
						{
							double x = dx / D;
							double y = dy / D;
							double z = (d2 - a2 * x - b2 * y) / c2;
							txtKQ.Text = "Hệ phương trình có nghiệm";
							txtX.Text = " x = " + x.ToString();
							txtY.Text = " y = " + y.ToString();
							txtZ.Text = " z = " + z.ToString();
						}
					}
					else if (c2 == 0)
					{
						double a = a1 * c3 - a3 * c1;
						double b = b1 * c3 - b3 * c1;
						double d = d1 * c3 - d3 * c1;
						double dx = d * b2 - b * d2;
						double dy = a * d2 - a2 * d;
						double D = a * b2 - a2 * b;
						if (D == 0 & (dx * dx + dy * dy == 0))
						{
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if (D == 0 & (dx * dx + dy * dy != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (D != 0)
						{
							double x = dx / D;
							double y = dy / D;
							double z = (d1 - a1 * x - b1 * y) / c1;
							txtKQ.Text = "Hệ phương trình có nghiệm";
							txtX.Text = " x = " + x.ToString();
							txtY.Text = " y = " + y.ToString();
							txtZ.Text = " z = " + z.ToString();
						}
					}
					else if (c3 == 0)
					{
						double a = a1 * c2 - a2 * c1;
						double b = b1 * c2 - b2 * c1;
						double d = d1 * c2 - d2 * c1;
						double dx = d * b3 - b * d3;
						double dy = a * d3 - a3 * d;
						double D = a * b3 - a3 * b;
						if (D == 0 & (dx * dx + dy * dy == 0))
						{
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if (D == 0 & (dx * dx + dy * dy != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (D != 0)
						{
							double x = dx / D;
							double y = dy / D;
							double z = (d1 - a1 * x - b1 * y) / c1;
							txtKQ.Text = "Hệ phương trình có nghiệm";
							txtX.Text = " x = " + x.ToString();
							txtY.Text = " y = " + y.ToString();
							txtZ.Text = " z = " + z.ToString();
						}
					}
					else if (c1 != 0 & c2 != 0 & c3 != 0)
					{
						double a = a1 * c2 - a2 * c1;
						double b = b1 * c2 - b2 * c1;
						double d = d1 * c2 - d2 * c1;
						double aa = a2 * c3 - a3 * c2;
						double bb = b2 * c3 - b3 * c2;
						double dd = d2 * c3 - d3 * c2;
						double dx = d * bb - b * dd;
						double dy = a * dd - d * aa;
						double D = a * bb - b * aa;
						if (D == 0 & (dx * dx + dy * dy == 0))
						{
							txtKQ.Text = "Hệ phương trình đã cho có nghiệm đúng với mọi x, y, z thuộc R";
						}
						else if (D == 0 & (dx * dx + dy * dy != 0))
						{
							txtKQ.Text = "Hệ phương trình vô nghiệm";
						}
						else if (D != 0)
						{
							double x = dx / D;
							double y = dy / D;
							double z = (d1 - a1 * x - b1 * y) / c1;
							txtKQ.Text = "Hệ phương trình có nghiệm";
							txtX.Text = " x = " + x.ToString();
							txtY.Text = " y = " + y.ToString();
							txtZ.Text = " z = " + z.ToString();
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
					txtA3.Enabled = true;
					txtB3.Enabled = true;
					txtC3.Enabled = true;
					txtD3.Enabled = true;
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
				txtA3.Text = "0";
				txtB3.Text = "0";
				txtC3.Text = "0";
				txtD3.Text = "0";
			}

			if ((txtA1.Text == "0") && (txtB1.Text == "0") && (txtC1.Text == "0") && (txtD1.Text == "0") && (txtA2.Text == "0") && (txtB2.Text == "0") && (txtC2.Text == "0") && (txtA3.Text == "0") && (txtB3.Text == "0") && (txtC3.Text == "0") && (txtD3.Text == "0"))
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
			txtA3.Enabled = true;
			txtB3.Enabled = true;
			txtC3.Enabled = true;
			txtD3.Enabled = true;
			txtKQ.Text = "";
			txtX.Text = "";
			txtY.Text = "";
			txtZ.Text = "";
			btnGiai.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
