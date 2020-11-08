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
	public partial class frmToHop : Form
	{
		public frmToHop()
		{
			InitializeComponent();
		}

		private void frmToHop_Load(object sender, EventArgs e)
		{
			SetBounds(Screen.GetWorkingArea(this).Width * 5 / 100 + 825, Screen.GetWorkingArea(this).Height * 20 / 52, Width, Height);
		}

		private void frmToHop_FormClosing(object sender, FormClosingEventArgs e)
		{
			total.showCh = false;
			btTruyenkqth_clicked = null;
			this.Hide();
			e.Cancel = true;
		}
		public event EventHandler btTruyenkqth_clicked;

		public TextBox _kqth
		{
			set
			{
				tbKQ = value;
			}
			get
			{
				return tbKQ;
			}
		}
		public Boolean _visibleTh
		{
			set
			{
				Visible = value;
			}
			get
			{
				return Visible;
			}
		}

		private void btKq_Click(object sender, EventArgs e)
		{
			if (tbK.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị k", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (tbN.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập giá trị n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					double k = double.Parse(tbK.Text);
					double n = double.Parse(tbN.Text);
					if (k % 1 == 0 && n % 1 == 0 && k >= 0 && n >= k)
					{
						double ketQua = 1;
						for (int i = 1; i <= k; i++, n--)
						{
							ketQua = ketQua * n / i;
						}
						tbKQ.Text = ketQua.ToString();
					}
					else
					{
						MessageBox.Show("k, n không được là số thực, n phải lớn hơn hoặc bằng k", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch
				{
					MessageBox.Show("Đã có lỗi xảy ra, đảm bảo bạn thao tác đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btTruyenkqth_Click(object sender, EventArgs e)
		{
			if (this.btTruyenkqth_clicked != null)
			{
				this.btTruyenkqth_clicked(sender, e);
			}
		}
	}
}
