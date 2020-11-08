namespace Intelligent_Calculator_Core
{
	partial class frmUCLN_BCNN
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUCLN_BCNN));
			this.groupBoxKQ = new System.Windows.Forms.GroupBox();
			this.txtBCNN = new System.Windows.Forms.TextBox();
			this.txtUCLN = new System.Windows.Forms.TextBox();
			this.groupBoxNhap = new System.Windows.Forms.GroupBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.lblA = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.lblB = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxKQ.SuspendLayout();
			this.groupBoxNhap.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxKQ
			// 
			this.groupBoxKQ.Controls.Add(this.txtBCNN);
			this.groupBoxKQ.Controls.Add(this.txtUCLN);
			this.groupBoxKQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxKQ.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxKQ.Location = new System.Drawing.Point(6, 256);
			this.groupBoxKQ.Name = "groupBoxKQ";
			this.groupBoxKQ.Size = new System.Drawing.Size(435, 105);
			this.groupBoxKQ.TabIndex = 8;
			this.groupBoxKQ.TabStop = false;
			this.groupBoxKQ.Text = "Kết Quả";
			// 
			// txtBCNN
			// 
			this.txtBCNN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.txtBCNN.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBCNN.ForeColor = System.Drawing.Color.White;
			this.txtBCNN.Location = new System.Drawing.Point(18, 59);
			this.txtBCNN.Multiline = true;
			this.txtBCNN.Name = "txtBCNN";
			this.txtBCNN.ReadOnly = true;
			this.txtBCNN.Size = new System.Drawing.Size(411, 20);
			this.txtBCNN.TabIndex = 5;
			// 
			// txtUCLN
			// 
			this.txtUCLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.txtUCLN.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUCLN.ForeColor = System.Drawing.Color.White;
			this.txtUCLN.Location = new System.Drawing.Point(18, 33);
			this.txtUCLN.Multiline = true;
			this.txtUCLN.Name = "txtUCLN";
			this.txtUCLN.ReadOnly = true;
			this.txtUCLN.Size = new System.Drawing.Size(411, 20);
			this.txtUCLN.TabIndex = 5;
			// 
			// groupBoxNhap
			// 
			this.groupBoxNhap.Controls.Add(this.txtA);
			this.groupBoxNhap.Controls.Add(this.txtB);
			this.groupBoxNhap.Controls.Add(this.btnLamMoi);
			this.groupBoxNhap.Controls.Add(this.lblA);
			this.groupBoxNhap.Controls.Add(this.btnThoat);
			this.groupBoxNhap.Controls.Add(this.btnTim);
			this.groupBoxNhap.Controls.Add(this.lblB);
			this.groupBoxNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxNhap.ForeColor = System.Drawing.Color.LightGray;
			this.groupBoxNhap.Location = new System.Drawing.Point(6, 55);
			this.groupBoxNhap.Name = "groupBoxNhap";
			this.groupBoxNhap.Size = new System.Drawing.Size(435, 202);
			this.groupBoxNhap.TabIndex = 7;
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
			this.txtB.Location = new System.Drawing.Point(148, 112);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(281, 21);
			this.txtB.TabIndex = 2;
			this.txtB.Text = "0";
			this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
			this.txtB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtB_MouseUp);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLamMoi.ForeColor = System.Drawing.Color.White;
			this.btnLamMoi.Location = new System.Drawing.Point(190, 160);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(77, 36);
			this.btnLamMoi.TabIndex = 4;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(15, 54);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(106, 15);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Nhập số thứ nhất: ";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(352, 160);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(77, 36);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTim.ForeColor = System.Drawing.Color.White;
			this.btnTim.Location = new System.Drawing.Point(271, 160);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(77, 36);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(15, 114);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(99, 15);
			this.lblB.TabIndex = 0;
			this.lblB.Text = "Nhập số thứ hai: ";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(136, 24);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(200, 16);
			this.labelName.TabIndex = 6;
			this.labelName.Text = "TÌM ƯCLN, BCNN CỦA 2 SỐ";
			// 
			// frmUCLN_BCNN
			// 
			this.AcceptButton = this.btnTim;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(447, 367);
			this.Controls.Add(this.groupBoxKQ);
			this.Controls.Add(this.groupBoxNhap);
			this.Controls.Add(this.labelName);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmUCLN_BCNN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tìm ƯCLN, BCNN Của 2 Số";
			this.Load += new System.EventHandler(this.frmUCLN_BCNN_Load);
			this.groupBoxKQ.ResumeLayout(false);
			this.groupBoxKQ.PerformLayout();
			this.groupBoxNhap.ResumeLayout(false);
			this.groupBoxNhap.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxKQ;
		private System.Windows.Forms.TextBox txtUCLN;
		private System.Windows.Forms.GroupBox groupBoxNhap;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox txtBCNN;
	}
}