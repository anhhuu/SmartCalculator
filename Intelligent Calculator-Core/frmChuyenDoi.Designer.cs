namespace Intelligent_Calculator_Core
{
	partial class frmChuyenDoi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenDoi));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDau = new System.Windows.Forms.TextBox();
			this.cbCuoi = new System.Windows.Forms.ComboBox();
			this.txtCuoi = new System.Windows.Forms.TextBox();
			this.cbDau = new System.Windows.Forms.ComboBox();
			this.rdkhoiluong = new System.Windows.Forms.RadioButton();
			this.rdthetich = new System.Windows.Forms.RadioButton();
			this.rddientich = new System.Windows.Forms.RadioButton();
			this.rddodai = new System.Windows.Forms.RadioButton();
			this.rddungluong = new System.Windows.Forms.RadioButton();
			this.rdhecoso = new System.Windows.Forms.RadioButton();
			this.rdnangluong = new System.Windows.Forms.RadioButton();
			this.rdvantoc = new System.Windows.Forms.RadioButton();
			this.rdapsuat = new System.Windows.Forms.RadioButton();
			this.rdnhietdo = new System.Windows.Forms.RadioButton();
			this.labelName = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnTinh = new System.Windows.Forms.Button();
			this.groupBoxNhap = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBoxNhap.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.groupBox1.Controls.Add(this.btnThoat);
			this.groupBox1.Controls.Add(this.btnLamMoi);
			this.groupBox1.Controls.Add(this.btnTinh);
			this.groupBox1.Controls.Add(this.txtDau);
			this.groupBox1.Controls.Add(this.cbCuoi);
			this.groupBox1.Controls.Add(this.txtCuoi);
			this.groupBox1.Controls.Add(this.cbDau);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
			this.groupBox1.Location = new System.Drawing.Point(7, 303);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 138);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chuyển đổi";
			// 
			// txtDau
			// 
			this.txtDau.BackColor = System.Drawing.Color.Black;
			this.txtDau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDau.ForeColor = System.Drawing.Color.White;
			this.txtDau.Location = new System.Drawing.Point(6, 41);
			this.txtDau.Name = "txtDau";
			this.txtDau.Size = new System.Drawing.Size(115, 20);
			this.txtDau.TabIndex = 3;
			// 
			// cbCuoi
			// 
			this.cbCuoi.BackColor = System.Drawing.Color.Black;
			this.cbCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCuoi.ForeColor = System.Drawing.Color.White;
			this.cbCuoi.FormattingEnabled = true;
			this.cbCuoi.Location = new System.Drawing.Point(154, 19);
			this.cbCuoi.Name = "cbCuoi";
			this.cbCuoi.Size = new System.Drawing.Size(115, 21);
			this.cbCuoi.TabIndex = 2;
			// 
			// txtCuoi
			// 
			this.txtCuoi.BackColor = System.Drawing.Color.Black;
			this.txtCuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuoi.ForeColor = System.Drawing.Color.White;
			this.txtCuoi.Location = new System.Drawing.Point(154, 41);
			this.txtCuoi.Name = "txtCuoi";
			this.txtCuoi.ReadOnly = true;
			this.txtCuoi.Size = new System.Drawing.Size(115, 20);
			this.txtCuoi.TabIndex = 3;
			// 
			// cbDau
			// 
			this.cbDau.BackColor = System.Drawing.Color.Black;
			this.cbDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbDau.ForeColor = System.Drawing.Color.White;
			this.cbDau.FormattingEnabled = true;
			this.cbDau.Location = new System.Drawing.Point(6, 19);
			this.cbDau.Name = "cbDau";
			this.cbDau.Size = new System.Drawing.Size(115, 21);
			this.cbDau.TabIndex = 2;
			// 
			// rdkhoiluong
			// 
			this.rdkhoiluong.AutoSize = true;
			this.rdkhoiluong.Location = new System.Drawing.Point(22, 193);
			this.rdkhoiluong.Name = "rdkhoiluong";
			this.rdkhoiluong.Size = new System.Drawing.Size(84, 19);
			this.rdkhoiluong.TabIndex = 6;
			this.rdkhoiluong.TabStop = true;
			this.rdkhoiluong.Text = "Khối lượng";
			this.rdkhoiluong.UseVisualStyleBackColor = true;
			this.rdkhoiluong.CheckedChanged += new System.EventHandler(this.rdkhoiluong_CheckedChanged);
			// 
			// rdthetich
			// 
			this.rdthetich.AutoSize = true;
			this.rdthetich.Location = new System.Drawing.Point(22, 152);
			this.rdthetich.Name = "rdthetich";
			this.rdthetich.Size = new System.Drawing.Size(68, 19);
			this.rdthetich.TabIndex = 7;
			this.rdthetich.TabStop = true;
			this.rdthetich.Text = "Thể tích";
			this.rdthetich.UseVisualStyleBackColor = true;
			this.rdthetich.CheckedChanged += new System.EventHandler(this.rdthetich_CheckedChanged);
			// 
			// rddientich
			// 
			this.rddientich.AutoSize = true;
			this.rddientich.Location = new System.Drawing.Point(22, 110);
			this.rddientich.Name = "rddientich";
			this.rddientich.Size = new System.Drawing.Size(73, 19);
			this.rddientich.TabIndex = 8;
			this.rddientich.TabStop = true;
			this.rddientich.Text = "Diện tích";
			this.rddientich.UseVisualStyleBackColor = true;
			this.rddientich.CheckedChanged += new System.EventHandler(this.rddientich_CheckedChanged);
			// 
			// rddodai
			// 
			this.rddodai.AutoSize = true;
			this.rddodai.Location = new System.Drawing.Point(22, 71);
			this.rddodai.Name = "rddodai";
			this.rddodai.Size = new System.Drawing.Size(61, 19);
			this.rddodai.TabIndex = 9;
			this.rddodai.TabStop = true;
			this.rddodai.Text = "Độ dài";
			this.rddodai.UseVisualStyleBackColor = true;
			this.rddodai.CheckedChanged += new System.EventHandler(this.rddodai_CheckedChanged);
			// 
			// rddungluong
			// 
			this.rddungluong.AutoSize = true;
			this.rddungluong.Location = new System.Drawing.Point(180, 193);
			this.rddungluong.Name = "rddungluong";
			this.rddungluong.Size = new System.Drawing.Size(89, 19);
			this.rddungluong.TabIndex = 10;
			this.rddungluong.TabStop = true;
			this.rddungluong.Text = "Dung lượng";
			this.rddungluong.UseVisualStyleBackColor = true;
			this.rddungluong.CheckedChanged += new System.EventHandler(this.rddungluong_CheckedChanged);
			// 
			// rdhecoso
			// 
			this.rdhecoso.AutoSize = true;
			this.rdhecoso.Location = new System.Drawing.Point(180, 152);
			this.rdhecoso.Name = "rdhecoso";
			this.rdhecoso.Size = new System.Drawing.Size(73, 19);
			this.rdhecoso.TabIndex = 11;
			this.rdhecoso.TabStop = true;
			this.rdhecoso.Text = "Hệ cơ số";
			this.rdhecoso.UseVisualStyleBackColor = true;
			this.rdhecoso.CheckedChanged += new System.EventHandler(this.rdhecoso_CheckedChanged);
			// 
			// rdnangluong
			// 
			this.rdnangluong.AutoSize = true;
			this.rdnangluong.Location = new System.Drawing.Point(180, 110);
			this.rdnangluong.Name = "rdnangluong";
			this.rdnangluong.Size = new System.Drawing.Size(89, 19);
			this.rdnangluong.TabIndex = 12;
			this.rdnangluong.TabStop = true;
			this.rdnangluong.Text = "Năng lượng";
			this.rdnangluong.UseVisualStyleBackColor = true;
			this.rdnangluong.CheckedChanged += new System.EventHandler(this.rdnangluong_CheckedChanged);
			// 
			// rdvantoc
			// 
			this.rdvantoc.AutoSize = true;
			this.rdvantoc.Location = new System.Drawing.Point(180, 71);
			this.rdvantoc.Name = "rdvantoc";
			this.rdvantoc.Size = new System.Drawing.Size(65, 19);
			this.rdvantoc.TabIndex = 13;
			this.rdvantoc.TabStop = true;
			this.rdvantoc.Text = "Vận tốc";
			this.rdvantoc.UseVisualStyleBackColor = true;
			this.rdvantoc.CheckedChanged += new System.EventHandler(this.rdvantoc_CheckedChanged);
			// 
			// rdapsuat
			// 
			this.rdapsuat.AutoSize = true;
			this.rdapsuat.Location = new System.Drawing.Point(180, 33);
			this.rdapsuat.Name = "rdapsuat";
			this.rdapsuat.Size = new System.Drawing.Size(65, 19);
			this.rdapsuat.TabIndex = 14;
			this.rdapsuat.TabStop = true;
			this.rdapsuat.Text = "Áp suất";
			this.rdapsuat.UseVisualStyleBackColor = true;
			this.rdapsuat.CheckedChanged += new System.EventHandler(this.rdapsuat_CheckedChanged);
			// 
			// rdnhietdo
			// 
			this.rdnhietdo.AutoSize = true;
			this.rdnhietdo.Location = new System.Drawing.Point(22, 33);
			this.rdnhietdo.Name = "rdnhietdo";
			this.rdnhietdo.Size = new System.Drawing.Size(71, 19);
			this.rdnhietdo.TabIndex = 15;
			this.rdnhietdo.TabStop = true;
			this.rdnhietdo.Text = "Nhiệt độ";
			this.rdnhietdo.UseVisualStyleBackColor = true;
			this.rdnhietdo.CheckedChanged += new System.EventHandler(this.rdnhietdo_CheckedChanged);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(72, 25);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(154, 16);
			this.labelName.TabIndex = 21;
			this.labelName.Text = "CHUYỂN ĐỔI ĐƠN VỊ";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(198, 96);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(77, 36);
			this.btnThoat.TabIndex = 36;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(36, 96);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(77, 36);
			this.btnLamMoi.TabIndex = 35;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnTinh
			// 
			this.btnTinh.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnTinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnTinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTinh.ForeColor = System.Drawing.Color.White;
			this.btnTinh.Location = new System.Drawing.Point(117, 96);
			this.btnTinh.Name = "btnTinh";
			this.btnTinh.Size = new System.Drawing.Size(77, 36);
			this.btnTinh.TabIndex = 34;
			this.btnTinh.Text = "Chuyển Đổi";
			this.btnTinh.UseVisualStyleBackColor = false;
			this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
			// 
			// groupBoxNhap
			// 
			this.groupBoxNhap.Controls.Add(this.rdnangluong);
			this.groupBoxNhap.Controls.Add(this.rdnhietdo);
			this.groupBoxNhap.Controls.Add(this.rdapsuat);
			this.groupBoxNhap.Controls.Add(this.rdkhoiluong);
			this.groupBoxNhap.Controls.Add(this.rdvantoc);
			this.groupBoxNhap.Controls.Add(this.rdthetich);
			this.groupBoxNhap.Controls.Add(this.rdhecoso);
			this.groupBoxNhap.Controls.Add(this.rddientich);
			this.groupBoxNhap.Controls.Add(this.rddungluong);
			this.groupBoxNhap.Controls.Add(this.rddodai);
			this.groupBoxNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxNhap.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxNhap.Location = new System.Drawing.Point(7, 61);
			this.groupBoxNhap.Name = "groupBoxNhap";
			this.groupBoxNhap.Size = new System.Drawing.Size(280, 241);
			this.groupBoxNhap.TabIndex = 22;
			this.groupBoxNhap.TabStop = false;
			this.groupBoxNhap.Text = "Chọn đại lượng";
			// 
			// frmChuyenDoi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(294, 449);
			this.Controls.Add(this.groupBoxNhap);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmChuyenDoi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chuyển Đổi Đơn Vị";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBoxNhap.ResumeLayout(false);
			this.groupBoxNhap.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDau;
		private System.Windows.Forms.ComboBox cbCuoi;
		private System.Windows.Forms.TextBox txtCuoi;
		private System.Windows.Forms.ComboBox cbDau;
		private System.Windows.Forms.RadioButton rdkhoiluong;
		private System.Windows.Forms.RadioButton rdthetich;
		private System.Windows.Forms.RadioButton rddientich;
		private System.Windows.Forms.RadioButton rddodai;
		private System.Windows.Forms.RadioButton rddungluong;
		private System.Windows.Forms.RadioButton rdhecoso;
		private System.Windows.Forms.RadioButton rdnangluong;
		private System.Windows.Forms.RadioButton rdvantoc;
		private System.Windows.Forms.RadioButton rdapsuat;
		private System.Windows.Forms.RadioButton rdnhietdo;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnTinh;
		private System.Windows.Forms.GroupBox groupBoxNhap;
	}
}