namespace Intelligent_Calculator_Core
{
    partial class Logax
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logax));
			this.btNhapLog = new System.Windows.Forms.Button();
			this.lbCosoa = new System.Windows.Forms.Label();
			this.lbLogdes = new System.Windows.Forms.Label();
			this.picLog = new System.Windows.Forms.PictureBox();
			this.tbCosoa = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
			this.SuspendLayout();
			// 
			// btNhapLog
			// 
			this.btNhapLog.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btNhapLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btNhapLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btNhapLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btNhapLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNhapLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btNhapLog.Location = new System.Drawing.Point(49, 106);
			this.btNhapLog.Margin = new System.Windows.Forms.Padding(4);
			this.btNhapLog.Name = "btNhapLog";
			this.btNhapLog.Size = new System.Drawing.Size(93, 31);
			this.btNhapLog.TabIndex = 2;
			this.btNhapLog.Text = "Nhập";
			this.btNhapLog.UseVisualStyleBackColor = false;
			this.btNhapLog.Click += new System.EventHandler(this.btNhapLog_Click);
			// 
			// lbCosoa
			// 
			this.lbCosoa.AutoSize = true;
			this.lbCosoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCosoa.Location = new System.Drawing.Point(45, 72);
			this.lbCosoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbCosoa.Name = "lbCosoa";
			this.lbCosoa.Size = new System.Drawing.Size(26, 19);
			this.lbCosoa.TabIndex = 3;
			this.lbCosoa.Text = "a: ";
			// 
			// lbLogdes
			// 
			this.lbLogdes.AutoSize = true;
			this.lbLogdes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLogdes.Location = new System.Drawing.Point(13, 22);
			this.lbLogdes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbLogdes.Name = "lbLogdes";
			this.lbLogdes.Size = new System.Drawing.Size(105, 19);
			this.lbLogdes.TabIndex = 5;
			this.lbLogdes.Text = "Nhập cơ số a: ";
			// 
			// picLog
			// 
			this.picLog.ErrorImage = null;
			this.picLog.Image = ((System.Drawing.Image)(resources.GetObject("picLog.Image")));
			this.picLog.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLog.InitialImage")));
			this.picLog.Location = new System.Drawing.Point(120, 17);
			this.picLog.Margin = new System.Windows.Forms.Padding(4);
			this.picLog.Name = "picLog";
			this.picLog.Size = new System.Drawing.Size(54, 31);
			this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLog.TabIndex = 6;
			this.picLog.TabStop = false;
			// 
			// tbCosoa
			// 
			this.tbCosoa.BackColor = System.Drawing.Color.Black;
			this.tbCosoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCosoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCosoa.ForeColor = System.Drawing.Color.White;
			this.tbCosoa.Location = new System.Drawing.Point(75, 69);
			this.tbCosoa.Margin = new System.Windows.Forms.Padding(4);
			this.tbCosoa.Name = "tbCosoa";
			this.tbCosoa.Size = new System.Drawing.Size(67, 26);
			this.tbCosoa.TabIndex = 7;
			// 
			// Logax
			// 
			this.AcceptButton = this.btNhapLog;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(187, 157);
			this.Controls.Add(this.tbCosoa);
			this.Controls.Add(this.picLog);
			this.Controls.Add(this.lbLogdes);
			this.Controls.Add(this.lbCosoa);
			this.Controls.Add(this.btNhapLog);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Logax";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Logarit";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logax_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNhapLog;
        private System.Windows.Forms.Label lbCosoa;
        private System.Windows.Forms.Label lbLogdes;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.TextBox tbCosoa;
    }
}