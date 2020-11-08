namespace Intelligent_Calculator_Core
{
	partial class frmSNT
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSNT));
			this.groupBoxKQ = new System.Windows.Forms.GroupBox();
			this.txtKQ = new System.Windows.Forms.TextBox();
			this.groupBoxNhap = new System.Windows.Forms.GroupBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.lblNum = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnKiemTra = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxKQ.SuspendLayout();
			this.groupBoxNhap.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxKQ
			// 
			this.groupBoxKQ.Controls.Add(this.txtKQ);
			this.groupBoxKQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxKQ.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxKQ.Location = new System.Drawing.Point(6, 199);
			this.groupBoxKQ.Name = "groupBoxKQ";
			this.groupBoxKQ.Size = new System.Drawing.Size(435, 80);
			this.groupBoxKQ.TabIndex = 11;
			this.groupBoxKQ.TabStop = false;
			this.groupBoxKQ.Text = "Kết Quả";
			// 
			// txtKQ
			// 
			this.txtKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.txtKQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKQ.ForeColor = System.Drawing.Color.White;
			this.txtKQ.Location = new System.Drawing.Point(18, 33);
			this.txtKQ.Multiline = true;
			this.txtKQ.Name = "txtKQ";
			this.txtKQ.ReadOnly = true;
			this.txtKQ.Size = new System.Drawing.Size(411, 20);
			this.txtKQ.TabIndex = 5;
			// 
			// groupBoxNhap
			// 
			this.groupBoxNhap.Controls.Add(this.txtA);
			this.groupBoxNhap.Controls.Add(this.btnLamMoi);
			this.groupBoxNhap.Controls.Add(this.lblNum);
			this.groupBoxNhap.Controls.Add(this.btnThoat);
			this.groupBoxNhap.Controls.Add(this.btnKiemTra);
			this.groupBoxNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxNhap.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxNhap.Location = new System.Drawing.Point(6, 54);
			this.groupBoxNhap.Name = "groupBoxNhap";
			this.groupBoxNhap.Size = new System.Drawing.Size(435, 146);
			this.groupBoxNhap.TabIndex = 10;
			this.groupBoxNhap.TabStop = false;
			this.groupBoxNhap.Text = "Nhập Giá Trị";
			// 
			// txtA
			// 
			this.txtA.BackColor = System.Drawing.Color.Black;
			this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtA.ForeColor = System.Drawing.Color.White;
			this.txtA.Location = new System.Drawing.Point(148, 54);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(281, 21);
			this.txtA.TabIndex = 1;
			this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(190, 94);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(77, 36);
			this.btnLamMoi.TabIndex = 4;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// lblNum
			// 
			this.lblNum.AutoSize = true;
			this.lblNum.Location = new System.Drawing.Point(15, 54);
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(126, 15);
			this.lblNum.TabIndex = 0;
			this.lblNum.Text = "Nhập số cần kiểm tra:";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(352, 94);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(77, 36);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnKiemTra
			// 
			this.btnKiemTra.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnKiemTra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnKiemTra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnKiemTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKiemTra.ForeColor = System.Drawing.Color.White;
			this.btnKiemTra.Location = new System.Drawing.Point(271, 94);
			this.btnKiemTra.Name = "btnKiemTra";
			this.btnKiemTra.Size = new System.Drawing.Size(77, 36);
			this.btnKiemTra.TabIndex = 3;
			this.btnKiemTra.Text = "Kiểm Tra";
			this.btnKiemTra.UseVisualStyleBackColor = false;
			this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(136, 23);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(196, 16);
			this.labelName.TabIndex = 9;
			this.labelName.Text = "KIỂM TRA SỐ NGUYÊN TỐ";
			// 
			// frmSNT
			// 
			this.AcceptButton = this.btnKiemTra;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(448, 285);
			this.Controls.Add(this.groupBoxKQ);
			this.Controls.Add(this.groupBoxNhap);
			this.Controls.Add(this.labelName);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmSNT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kiểm Tra Số Nguyên Tố";
			this.Load += new System.EventHandler(this.frmSNT_Load);
			this.groupBoxKQ.ResumeLayout(false);
			this.groupBoxKQ.PerformLayout();
			this.groupBoxNhap.ResumeLayout(false);
			this.groupBoxNhap.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxKQ;
		private System.Windows.Forms.TextBox txtKQ;
		private System.Windows.Forms.GroupBox groupBoxNhap;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Label lblNum;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnKiemTra;
		private System.Windows.Forms.Label labelName;
	}
}