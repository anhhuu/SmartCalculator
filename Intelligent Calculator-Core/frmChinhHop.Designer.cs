namespace Intelligent_Calculator_Core
{
	partial class frmChinhHop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinhHop));
			this.labelA = new System.Windows.Forms.Label();
			this.tbK = new System.Windows.Forms.TextBox();
			this.tbN = new System.Windows.Forms.TextBox();
			this.tbKQ = new System.Windows.Forms.TextBox();
			this.btKq = new System.Windows.Forms.Button();
			this.btTruyenkqdh = new System.Windows.Forms.Button();
			this.labelk = new System.Windows.Forms.Label();
			this.labeln = new System.Windows.Forms.Label();
			this.labelTile = new System.Windows.Forms.Label();
			this.lblNhapK = new System.Windows.Forms.Label();
			this.lblNhapN = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelA.Location = new System.Drawing.Point(227, 7);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(56, 55);
			this.labelA.TabIndex = 0;
			this.labelA.Text = "A";
			// 
			// tbK
			// 
			this.tbK.BackColor = System.Drawing.Color.Black;
			this.tbK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbK.ForeColor = System.Drawing.Color.White;
			this.tbK.Location = new System.Drawing.Point(63, 77);
			this.tbK.Name = "tbK";
			this.tbK.Size = new System.Drawing.Size(78, 23);
			this.tbK.TabIndex = 1;
			// 
			// tbN
			// 
			this.tbN.BackColor = System.Drawing.Color.Black;
			this.tbN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbN.ForeColor = System.Drawing.Color.White;
			this.tbN.Location = new System.Drawing.Point(63, 129);
			this.tbN.Name = "tbN";
			this.tbN.Size = new System.Drawing.Size(78, 23);
			this.tbN.TabIndex = 2;
			// 
			// tbKQ
			// 
			this.tbKQ.BackColor = System.Drawing.Color.Black;
			this.tbKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbKQ.ForeColor = System.Drawing.Color.White;
			this.tbKQ.Location = new System.Drawing.Point(233, 102);
			this.tbKQ.Name = "tbKQ";
			this.tbKQ.ReadOnly = true;
			this.tbKQ.Size = new System.Drawing.Size(94, 23);
			this.tbKQ.TabIndex = 3;
			// 
			// btKq
			// 
			this.btKq.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btKq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btKq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btKq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btKq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btKq.Location = new System.Drawing.Point(159, 99);
			this.btKq.Name = "btKq";
			this.btKq.Size = new System.Drawing.Size(63, 27);
			this.btKq.TabIndex = 4;
			this.btKq.Text = "=";
			this.btKq.UseVisualStyleBackColor = false;
			this.btKq.Click += new System.EventHandler(this.btKq_Click);
			// 
			// btTruyenkqdh
			// 
			this.btTruyenkqdh.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btTruyenkqdh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btTruyenkqdh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btTruyenkqdh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btTruyenkqdh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTruyenkqdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTruyenkqdh.Location = new System.Drawing.Point(15, 176);
			this.btTruyenkqdh.Name = "btTruyenkqdh";
			this.btTruyenkqdh.Size = new System.Drawing.Size(312, 31);
			this.btTruyenkqdh.TabIndex = 5;
			this.btTruyenkqdh.Text = "Truyền kết quả vào biểu thức chính";
			this.btTruyenkqdh.UseVisualStyleBackColor = false;
			this.btTruyenkqdh.Click += new System.EventHandler(this.btTruyenkqch_Click);
			// 
			// labelk
			// 
			this.labelk.AutoSize = true;
			this.labelk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelk.Location = new System.Drawing.Point(270, 7);
			this.labelk.Name = "labelk";
			this.labelk.Size = new System.Drawing.Size(15, 16);
			this.labelk.TabIndex = 6;
			this.labelk.Text = "k";
			// 
			// labeln
			// 
			this.labeln.AutoSize = true;
			this.labeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeln.Location = new System.Drawing.Point(270, 49);
			this.labeln.Name = "labeln";
			this.labeln.Size = new System.Drawing.Size(15, 16);
			this.labeln.TabIndex = 6;
			this.labeln.Text = "n";
			// 
			// labelTile
			// 
			this.labelTile.AutoSize = true;
			this.labelTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTile.Location = new System.Drawing.Point(11, 25);
			this.labelTile.Name = "labelTile";
			this.labelTile.Size = new System.Drawing.Size(188, 20);
			this.labelTile.TabIndex = 7;
			this.labelTile.Text = "Chỉnh Hợp Chập k Của n:";
			// 
			// lblNhapK
			// 
			this.lblNhapK.AutoSize = true;
			this.lblNhapK.Location = new System.Drawing.Point(12, 81);
			this.lblNhapK.Name = "lblNhapK";
			this.lblNhapK.Size = new System.Drawing.Size(45, 13);
			this.lblNhapK.TabIndex = 8;
			this.lblNhapK.Text = "Nhập k:";
			// 
			// lblNhapN
			// 
			this.lblNhapN.AutoSize = true;
			this.lblNhapN.Location = new System.Drawing.Point(12, 133);
			this.lblNhapN.Name = "lblNhapN";
			this.lblNhapN.Size = new System.Drawing.Size(45, 13);
			this.lblNhapN.TabIndex = 9;
			this.lblNhapN.Text = "Nhập n:";
			// 
			// frmChinhHop
			// 
			this.AcceptButton = this.btKq;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(339, 219);
			this.Controls.Add(this.lblNhapN);
			this.Controls.Add(this.lblNhapK);
			this.Controls.Add(this.labelTile);
			this.Controls.Add(this.labeln);
			this.Controls.Add(this.labelk);
			this.Controls.Add(this.btTruyenkqdh);
			this.Controls.Add(this.btKq);
			this.Controls.Add(this.tbKQ);
			this.Controls.Add(this.tbN);
			this.Controls.Add(this.tbK);
			this.Controls.Add(this.labelA);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmChinhHop";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tính Chỉnh Hợp";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChinhHop_FormClosing);
			this.Load += new System.EventHandler(this.frmChinhHop_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.TextBox tbK;
		private System.Windows.Forms.TextBox tbN;
		private System.Windows.Forms.TextBox tbKQ;
		private System.Windows.Forms.Button btKq;
		private System.Windows.Forms.Button btTruyenkqdh;
		private System.Windows.Forms.Label labelk;
		private System.Windows.Forms.Label labeln;
		private System.Windows.Forms.Label labelTile;
		private System.Windows.Forms.Label lblNhapK;
		private System.Windows.Forms.Label lblNhapN;
	}
}