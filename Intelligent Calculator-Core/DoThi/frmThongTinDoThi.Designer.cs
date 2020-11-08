namespace Intelligent_Calculator_Core
{
    partial class ThongTinDoThi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDoThi));
			this.cbBieuThuc = new System.Windows.Forms.ComboBox();
			this.lvXAndFX = new System.Windows.Forms.ListView();
			this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.rbDo = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbRadian = new System.Windows.Forms.RadioButton();
			this.btnXem = new System.Windows.Forms.Button();
			this.btnDong = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbBieuThuc
			// 
			this.cbBieuThuc.BackColor = System.Drawing.Color.Black;
			this.cbBieuThuc.ForeColor = System.Drawing.Color.White;
			this.cbBieuThuc.FormattingEnabled = true;
			this.cbBieuThuc.Location = new System.Drawing.Point(5, 5);
			this.cbBieuThuc.Margin = new System.Windows.Forms.Padding(4);
			this.cbBieuThuc.Name = "cbBieuThuc";
			this.cbBieuThuc.Size = new System.Drawing.Size(445, 24);
			this.cbBieuThuc.TabIndex = 0;
			// 
			// lvXAndFX
			// 
			this.lvXAndFX.BackColor = System.Drawing.Color.Black;
			this.lvXAndFX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvXAndFX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chX,
            this.chFX});
			this.lvXAndFX.ForeColor = System.Drawing.Color.White;
			this.lvXAndFX.FullRowSelect = true;
			this.lvXAndFX.GridLines = true;
			this.lvXAndFX.Location = new System.Drawing.Point(5, 37);
			this.lvXAndFX.Margin = new System.Windows.Forms.Padding(4);
			this.lvXAndFX.Name = "lvXAndFX";
			this.lvXAndFX.Size = new System.Drawing.Size(445, 183);
			this.lvXAndFX.TabIndex = 2;
			this.lvXAndFX.UseCompatibleStateImageBehavior = false;
			this.lvXAndFX.View = System.Windows.Forms.View.Details;
			// 
			// chX
			// 
			this.chX.Text = "x";
			this.chX.Width = 122;
			// 
			// chFX
			// 
			this.chFX.Text = "f(x)";
			this.chFX.Width = 301;
			// 
			// rbDo
			// 
			this.rbDo.AutoSize = true;
			this.rbDo.Location = new System.Drawing.Point(6, 21);
			this.rbDo.Name = "rbDo";
			this.rbDo.Size = new System.Drawing.Size(43, 20);
			this.rbDo.TabIndex = 4;
			this.rbDo.TabStop = true;
			this.rbDo.Text = "Độ";
			this.rbDo.UseVisualStyleBackColor = true;
			this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbRadian);
			this.groupBox1.Controls.Add(this.rbDo);
			this.groupBox1.Location = new System.Drawing.Point(457, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(81, 150);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// rbRadian
			// 
			this.rbRadian.AutoSize = true;
			this.rbRadian.Location = new System.Drawing.Point(6, 47);
			this.rbRadian.Name = "rbRadian";
			this.rbRadian.Size = new System.Drawing.Size(70, 20);
			this.rbRadian.TabIndex = 5;
			this.rbRadian.TabStop = true;
			this.rbRadian.Text = "Radian";
			this.rbRadian.UseVisualStyleBackColor = true;
			this.rbRadian.CheckedChanged += new System.EventHandler(this.rbRadian_CheckedChanged);
			// 
			// btnXem
			// 
			this.btnXem.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnXem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnXem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXem.ForeColor = System.Drawing.Color.White;
			this.btnXem.Location = new System.Drawing.Point(457, 5);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(81, 31);
			this.btnXem.TabIndex = 33;
			this.btnXem.Text = "Xem";
			this.btnXem.UseVisualStyleBackColor = false;
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// btnDong
			// 
			this.btnDong.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnDong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDong.ForeColor = System.Drawing.Color.White;
			this.btnDong.Location = new System.Drawing.Point(457, 42);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(81, 31);
			this.btnDong.TabIndex = 34;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = false;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// ThongTinDoThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(568, 226);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.btnXem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lvXAndFX);
			this.Controls.Add(this.cbBieuThuc);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ThongTinDoThi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông Tin Đồ Thị";
			this.Load += new System.EventHandler(this.ThongTinDoThi_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBieuThuc;
        private System.Windows.Forms.ListView lvXAndFX;
        private System.Windows.Forms.ColumnHeader chX;
        private System.Windows.Forms.ColumnHeader chFX;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRadian;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.Button btnDong;
	}
}