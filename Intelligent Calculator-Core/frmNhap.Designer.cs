namespace Intelligent_Calculator_Core
{
    partial class frmNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhap));
			this.tbNhap = new System.Windows.Forms.TextBox();
			this.lbNhap = new System.Windows.Forms.Label();
			this.btnNhap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbNhap
			// 
			this.tbNhap.BackColor = System.Drawing.Color.Black;
			this.tbNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNhap.ForeColor = System.Drawing.Color.White;
			this.tbNhap.Location = new System.Drawing.Point(13, 32);
			this.tbNhap.Name = "tbNhap";
			this.tbNhap.Size = new System.Drawing.Size(515, 26);
			this.tbNhap.TabIndex = 0;
			// 
			// lbNhap
			// 
			this.lbNhap.AutoSize = true;
			this.lbNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNhap.Location = new System.Drawing.Point(9, 9);
			this.lbNhap.Name = "lbNhap";
			this.lbNhap.Size = new System.Drawing.Size(310, 19);
			this.lbNhap.TabIndex = 2;
			this.lbNhap.Text = "Nhập biểu thức từ bàn phím của chương trình:";
			// 
			// btnNhap
			// 
			this.btnNhap.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhap.ForeColor = System.Drawing.Color.White;
			this.btnNhap.Location = new System.Drawing.Point(221, 64);
			this.btnNhap.Name = "btnNhap";
			this.btnNhap.Size = new System.Drawing.Size(130, 27);
			this.btnNhap.TabIndex = 32;
			this.btnNhap.Text = "Nhập";
			this.btnNhap.UseVisualStyleBackColor = false;
			this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
			// 
			// frmNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(540, 103);
			this.Controls.Add(this.btnNhap);
			this.Controls.Add(this.lbNhap);
			this.Controls.Add(this.tbNhap);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập F(x):";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nhap_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNhap;
        private System.Windows.Forms.Label lbNhap;
		private System.Windows.Forms.Button btnNhap;
	}
}