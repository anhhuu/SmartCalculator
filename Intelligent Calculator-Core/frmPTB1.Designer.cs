namespace Intelligent_Calculator_Core
{
	partial class frmPTB1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPTB1));
			this.labelName = new System.Windows.Forms.Label();
			this.btnGiai = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.groupBoxNhap = new System.Windows.Forms.GroupBox();
			this.groupBoxKQ = new System.Windows.Forms.GroupBox();
			this.txtKQ = new System.Windows.Forms.TextBox();
			this.groupBoxNhap.SuspendLayout();
			this.groupBoxKQ.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(74, 18);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(282, 16);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "GIẢI PHƯƠNG TRÌNH BẬC 1 (ax + b = 0)";
			// 
			// btnGiai
			// 
			this.btnGiai.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnGiai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnGiai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnGiai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnGiai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGiai.ForeColor = System.Drawing.Color.White;
			this.btnGiai.Location = new System.Drawing.Point(235, 159);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(77, 36);
			this.btnGiai.TabIndex = 3;
			this.btnGiai.Text = "Giải";
			this.btnGiai.UseVisualStyleBackColor = false;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(316, 159);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(77, 36);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(154, 159);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(77, 36);
			this.btnLamMoi.TabIndex = 4;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// txtA
			// 
			this.txtA.BackColor = System.Drawing.Color.Black;
			this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtA.ForeColor = System.Drawing.Color.White;
			this.txtA.Location = new System.Drawing.Point(112, 52);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(281, 21);
			this.txtA.TabIndex = 1;
			this.txtA.Text = "0";
			this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
			this.txtA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtA_MouseUp);
			// 
			// txtB
			// 
			this.txtB.BackColor = System.Drawing.Color.Black;
			this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtB.ForeColor = System.Drawing.Color.White;
			this.txtB.Location = new System.Drawing.Point(112, 112);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(281, 21);
			this.txtB.TabIndex = 2;
			this.txtB.Text = "0";
			this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
			this.txtB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtB_MouseUp);
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(15, 54);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(53, 15);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Nhập a: ";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(15, 114);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(53, 15);
			this.lblB.TabIndex = 0;
			this.lblB.Text = "Nhập b: ";
			// 
			// groupBoxNhap
			// 
			this.groupBoxNhap.Controls.Add(this.txtA);
			this.groupBoxNhap.Controls.Add(this.txtB);
			this.groupBoxNhap.Controls.Add(this.btnLamMoi);
			this.groupBoxNhap.Controls.Add(this.lblA);
			this.groupBoxNhap.Controls.Add(this.btnThoat);
			this.groupBoxNhap.Controls.Add(this.btnGiai);
			this.groupBoxNhap.Controls.Add(this.lblB);
			this.groupBoxNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxNhap.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxNhap.Location = new System.Drawing.Point(7, 49);
			this.groupBoxNhap.Name = "groupBoxNhap";
			this.groupBoxNhap.Size = new System.Drawing.Size(399, 202);
			this.groupBoxNhap.TabIndex = 5;
			this.groupBoxNhap.TabStop = false;
			this.groupBoxNhap.Text = "Nhập Giá Trị";
			// 
			// groupBoxKQ
			// 
			this.groupBoxKQ.Controls.Add(this.txtKQ);
			this.groupBoxKQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxKQ.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxKQ.Location = new System.Drawing.Point(7, 250);
			this.groupBoxKQ.Name = "groupBoxKQ";
			this.groupBoxKQ.Size = new System.Drawing.Size(399, 105);
			this.groupBoxKQ.TabIndex = 5;
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
			this.txtKQ.Size = new System.Drawing.Size(375, 20);
			this.txtKQ.TabIndex = 5;
			// 
			// frmPTB1
			// 
			this.AcceptButton = this.btnGiai;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(413, 361);
			this.Controls.Add(this.groupBoxKQ);
			this.Controls.Add(this.groupBoxNhap);
			this.Controls.Add(this.labelName);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPTB1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giải Phương Trình Bậc 1";
			this.Load += new System.EventHandler(this.frmPTB1_Load);
			this.groupBoxNhap.ResumeLayout(false);
			this.groupBoxNhap.PerformLayout();
			this.groupBoxKQ.ResumeLayout(false);
			this.groupBoxKQ.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button btnGiai;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.GroupBox groupBoxNhap;
		private System.Windows.Forms.GroupBox groupBoxKQ;
		private System.Windows.Forms.TextBox txtKQ;
	}
}