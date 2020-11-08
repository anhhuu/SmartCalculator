namespace Intelligent_Calculator_Core
{
    partial class frmDaoHam
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDaoHam));
			this.tbX = new System.Windows.Forms.TextBox();
			this.tbFx = new System.Windows.Forms.TextBox();
			this.btKqdh = new System.Windows.Forms.Button();
			this.tbKqdh = new System.Windows.Forms.TextBox();
			this.btTruyenkqdh = new System.Windows.Forms.Button();
			this.lbXdh = new System.Windows.Forms.Label();
			this.lbFxdh = new System.Windows.Forms.Label();
			this.lbKqdh = new System.Windows.Forms.Label();
			this.cbNhapdl = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbX
			// 
			this.tbX.BackColor = System.Drawing.Color.Black;
			this.tbX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbX.ForeColor = System.Drawing.Color.White;
			this.tbX.Location = new System.Drawing.Point(169, 25);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(78, 23);
			this.tbX.TabIndex = 0;
			// 
			// tbFx
			// 
			this.tbFx.BackColor = System.Drawing.Color.Black;
			this.tbFx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFx.ForeColor = System.Drawing.Color.White;
			this.tbFx.Location = new System.Drawing.Point(12, 115);
			this.tbFx.Name = "tbFx";
			this.tbFx.Size = new System.Drawing.Size(317, 23);
			this.tbFx.TabIndex = 1;
			// 
			// btKqdh
			// 
			this.btKqdh.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btKqdh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btKqdh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btKqdh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btKqdh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btKqdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btKqdh.Location = new System.Drawing.Point(12, 144);
			this.btKqdh.Name = "btKqdh";
			this.btKqdh.Size = new System.Drawing.Size(317, 27);
			this.btKqdh.TabIndex = 2;
			this.btKqdh.Text = "Tính";
			this.btKqdh.UseVisualStyleBackColor = false;
			this.btKqdh.Click += new System.EventHandler(this.btKqdh_Click);
			// 
			// tbKqdh
			// 
			this.tbKqdh.BackColor = System.Drawing.Color.Black;
			this.tbKqdh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbKqdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbKqdh.ForeColor = System.Drawing.Color.White;
			this.tbKqdh.Location = new System.Drawing.Point(11, 204);
			this.tbKqdh.Name = "tbKqdh";
			this.tbKqdh.ReadOnly = true;
			this.tbKqdh.Size = new System.Drawing.Size(317, 23);
			this.tbKqdh.TabIndex = 3;
			// 
			// btTruyenkqdh
			// 
			this.btTruyenkqdh.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btTruyenkqdh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btTruyenkqdh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btTruyenkqdh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btTruyenkqdh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTruyenkqdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTruyenkqdh.Location = new System.Drawing.Point(11, 233);
			this.btTruyenkqdh.Name = "btTruyenkqdh";
			this.btTruyenkqdh.Size = new System.Drawing.Size(318, 31);
			this.btTruyenkqdh.TabIndex = 4;
			this.btTruyenkqdh.Text = "Truyền kết quả vào biểu thức chính";
			this.btTruyenkqdh.UseVisualStyleBackColor = false;
			this.btTruyenkqdh.Click += new System.EventHandler(this.btTruyenkqdh_Click);
			// 
			// lbXdh
			// 
			this.lbXdh.AutoSize = true;
			this.lbXdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbXdh.Location = new System.Drawing.Point(12, 28);
			this.lbXdh.Name = "lbXdh";
			this.lbXdh.Size = new System.Drawing.Size(151, 17);
			this.lbXdh.TabIndex = 5;
			this.lbXdh.Text = "Đạo hàm tại điểm x:\r\n";
			// 
			// lbFxdh
			// 
			this.lbFxdh.AutoSize = true;
			this.lbFxdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFxdh.Location = new System.Drawing.Point(89, 68);
			this.lbFxdh.Name = "lbFxdh";
			this.lbFxdh.Size = new System.Drawing.Size(100, 17);
			this.lbFxdh.TabIndex = 6;
			this.lbFxdh.Text = "Hàm số F(x):";
			// 
			// lbKqdh
			// 
			this.lbKqdh.AutoSize = true;
			this.lbKqdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKqdh.Location = new System.Drawing.Point(12, 178);
			this.lbKqdh.Name = "lbKqdh";
			this.lbKqdh.Size = new System.Drawing.Size(154, 17);
			this.lbKqdh.TabIndex = 7;
			this.lbKqdh.Text = "Kết quả (gần đúng):";
			// 
			// cbNhapdl
			// 
			this.cbNhapdl.AutoSize = true;
			this.cbNhapdl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNhapdl.Location = new System.Drawing.Point(12, 90);
			this.cbNhapdl.Name = "cbNhapdl";
			this.cbNhapdl.Size = new System.Drawing.Size(262, 19);
			this.cbNhapdl.TabIndex = 8;
			this.cbNhapdl.Text = "Nhập hàm số từ bàn phím của chương trình";
			this.cbNhapdl.UseVisualStyleBackColor = true;
			this.cbNhapdl.CheckedChanged += new System.EventHandler(this.cbNhapdl_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(253, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(76, 52);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// frmDaoHam
			// 
			this.AcceptButton = this.btKqdh;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(339, 276);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cbNhapdl);
			this.Controls.Add(this.lbKqdh);
			this.Controls.Add(this.lbFxdh);
			this.Controls.Add(this.lbXdh);
			this.Controls.Add(this.btTruyenkqdh);
			this.Controls.Add(this.tbKqdh);
			this.Controls.Add(this.btKqdh);
			this.Controls.Add(this.tbFx);
			this.Controls.Add(this.tbX);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmDaoHam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tính Đạo Hàm";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Daoham_FormClosing);
			this.Load += new System.EventHandler(this.Daoham_Load);
			this.VisibleChanged += new System.EventHandler(this.Daoham_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbFx;
        private System.Windows.Forms.Button btKqdh;
        private System.Windows.Forms.TextBox tbKqdh;
        private System.Windows.Forms.Button btTruyenkqdh;
        private System.Windows.Forms.Label lbXdh;
        private System.Windows.Forms.Label lbFxdh;
        private System.Windows.Forms.Label lbKqdh;
        private System.Windows.Forms.CheckBox cbNhapdl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}