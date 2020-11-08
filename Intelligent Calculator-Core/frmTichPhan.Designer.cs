namespace Intelligent_Calculator_Core
{ 

	partial class frmTichPhan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTichPhan));
			this.cbNhapdl = new System.Windows.Forms.CheckBox();
			this.lbKqtp = new System.Windows.Forms.Label();
			this.lbFxtp = new System.Windows.Forms.Label();
			this.lbCanA = new System.Windows.Forms.Label();
			this.btTruyenkqtp = new System.Windows.Forms.Button();
			this.tbKqtp = new System.Windows.Forms.TextBox();
			this.btKqdtp = new System.Windows.Forms.Button();
			this.tbFx = new System.Windows.Forms.TextBox();
			this.tbCanA = new System.Windows.Forms.TextBox();
			this.lbCanB = new System.Windows.Forms.Label();
			this.tbCanB = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cbNhapdl
			// 
			this.cbNhapdl.AutoSize = true;
			this.cbNhapdl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNhapdl.Location = new System.Drawing.Point(13, 90);
			this.cbNhapdl.Name = "cbNhapdl";
			this.cbNhapdl.Size = new System.Drawing.Size(262, 19);
			this.cbNhapdl.TabIndex = 17;
			this.cbNhapdl.Text = "Nhập hàm số từ bàn phím của chương trình";
			this.cbNhapdl.UseVisualStyleBackColor = true;
			this.cbNhapdl.CheckedChanged += new System.EventHandler(this.cbNhapdl_CheckedChanged);
			// 
			// lbKqtp
			// 
			this.lbKqtp.AutoSize = true;
			this.lbKqtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKqtp.Location = new System.Drawing.Point(104, 180);
			this.lbKqtp.Name = "lbKqtp";
			this.lbKqtp.Size = new System.Drawing.Size(154, 17);
			this.lbKqtp.TabIndex = 16;
			this.lbKqtp.Text = "Kết quả (gần đúng):";
			// 
			// lbFxtp
			// 
			this.lbFxtp.AutoSize = true;
			this.lbFxtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFxtp.Location = new System.Drawing.Point(90, 68);
			this.lbFxtp.Name = "lbFxtp";
			this.lbFxtp.Size = new System.Drawing.Size(100, 17);
			this.lbFxtp.TabIndex = 15;
			this.lbFxtp.Text = "Hàm số F(x):";
			// 
			// lbCanA
			// 
			this.lbCanA.AutoSize = true;
			this.lbCanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCanA.Location = new System.Drawing.Point(29, 18);
			this.lbCanA.Name = "lbCanA";
			this.lbCanA.Size = new System.Drawing.Size(60, 17);
			this.lbCanA.TabIndex = 14;
			this.lbCanA.Text = "Cận a: ";
			// 
			// btTruyenkqtp
			// 
			this.btTruyenkqtp.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btTruyenkqtp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btTruyenkqtp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btTruyenkqtp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btTruyenkqtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTruyenkqtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTruyenkqtp.Location = new System.Drawing.Point(12, 233);
			this.btTruyenkqtp.Name = "btTruyenkqtp";
			this.btTruyenkqtp.Size = new System.Drawing.Size(315, 31);
			this.btTruyenkqtp.TabIndex = 13;
			this.btTruyenkqtp.Text = "Truyền kết quả vào biểu thức chính";
			this.btTruyenkqtp.UseVisualStyleBackColor = false;
			this.btTruyenkqtp.Click += new System.EventHandler(this.btTruyenkqtp_Click);
			// 
			// tbKqtp
			// 
			this.tbKqtp.BackColor = System.Drawing.Color.Black;
			this.tbKqtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbKqtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbKqtp.ForeColor = System.Drawing.Color.White;
			this.tbKqtp.Location = new System.Drawing.Point(13, 204);
			this.tbKqtp.Name = "tbKqtp";
			this.tbKqtp.ReadOnly = true;
			this.tbKqtp.Size = new System.Drawing.Size(314, 23);
			this.tbKqtp.TabIndex = 12;
			// 
			// btKqdtp
			// 
			this.btKqdtp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btKqdtp.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btKqdtp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btKqdtp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btKqdtp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btKqdtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btKqdtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btKqdtp.Location = new System.Drawing.Point(13, 144);
			this.btKqdtp.Name = "btKqdtp";
			this.btKqdtp.Size = new System.Drawing.Size(314, 27);
			this.btKqdtp.TabIndex = 11;
			this.btKqdtp.Text = "Tính";
			this.btKqdtp.UseVisualStyleBackColor = false;
			this.btKqdtp.Click += new System.EventHandler(this.btKqtp_Click);
			// 
			// tbFx
			// 
			this.tbFx.BackColor = System.Drawing.Color.Black;
			this.tbFx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFx.ForeColor = System.Drawing.Color.White;
			this.tbFx.Location = new System.Drawing.Point(13, 115);
			this.tbFx.Name = "tbFx";
			this.tbFx.Size = new System.Drawing.Size(314, 23);
			this.tbFx.TabIndex = 10;
			// 
			// tbCanA
			// 
			this.tbCanA.BackColor = System.Drawing.Color.Black;
			this.tbCanA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCanA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCanA.ForeColor = System.Drawing.Color.White;
			this.tbCanA.Location = new System.Drawing.Point(93, 15);
			this.tbCanA.Name = "tbCanA";
			this.tbCanA.Size = new System.Drawing.Size(97, 23);
			this.tbCanA.TabIndex = 9;
			// 
			// lbCanB
			// 
			this.lbCanB.AutoSize = true;
			this.lbCanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCanB.Location = new System.Drawing.Point(29, 45);
			this.lbCanB.Name = "lbCanB";
			this.lbCanB.Size = new System.Drawing.Size(55, 17);
			this.lbCanB.TabIndex = 19;
			this.lbCanB.Text = "Cận b:\r\n";
			// 
			// tbCanB
			// 
			this.tbCanB.BackColor = System.Drawing.Color.Black;
			this.tbCanB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCanB.ForeColor = System.Drawing.Color.White;
			this.tbCanB.Location = new System.Drawing.Point(93, 42);
			this.tbCanB.Name = "tbCanB";
			this.tbCanB.Size = new System.Drawing.Size(97, 23);
			this.tbCanB.TabIndex = 18;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(238, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(89, 49);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// frmTichPhan
			// 
			this.AcceptButton = this.btKqdtp;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(339, 274);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbCanB);
			this.Controls.Add(this.tbCanB);
			this.Controls.Add(this.cbNhapdl);
			this.Controls.Add(this.lbKqtp);
			this.Controls.Add(this.lbFxtp);
			this.Controls.Add(this.lbCanA);
			this.Controls.Add(this.btTruyenkqtp);
			this.Controls.Add(this.tbKqtp);
			this.Controls.Add(this.btKqdtp);
			this.Controls.Add(this.tbFx);
			this.Controls.Add(this.tbCanA);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmTichPhan";
			this.Text = "Tính Tích Phân";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tichphan_FormClosing);
			this.Load += new System.EventHandler(this.Tichphan_Load);
			this.VisibleChanged += new System.EventHandler(this.Tichphan_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbNhapdl;
        private System.Windows.Forms.Label lbKqtp;
        private System.Windows.Forms.Label lbFxtp;
        private System.Windows.Forms.Label lbCanA;
        private System.Windows.Forms.Button btTruyenkqtp;
        private System.Windows.Forms.TextBox tbKqtp;
        private System.Windows.Forms.Button btKqdtp;
        private System.Windows.Forms.TextBox tbFx;
        private System.Windows.Forms.TextBox tbCanA;
        private System.Windows.Forms.Label lbCanB;
        private System.Windows.Forms.TextBox tbCanB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}