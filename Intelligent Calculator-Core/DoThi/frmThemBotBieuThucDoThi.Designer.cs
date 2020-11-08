namespace Intelligent_Calculator_Core
{
    partial class ThemBotBieuThuc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemBotBieuThuc));
			this.clbExpression = new System.Windows.Forms.CheckedListBox();
			this.btnDongY = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// clbExpression
			// 
			this.clbExpression.BackColor = System.Drawing.Color.Black;
			this.clbExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clbExpression.ForeColor = System.Drawing.Color.White;
			this.clbExpression.FormattingEnabled = true;
			this.clbExpression.Location = new System.Drawing.Point(12, 12);
			this.clbExpression.Name = "clbExpression";
			this.clbExpression.Size = new System.Drawing.Size(209, 123);
			this.clbExpression.TabIndex = 0;
			this.clbExpression.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// btnDongY
			// 
			this.btnDongY.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnDongY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnDongY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDongY.ForeColor = System.Drawing.Color.White;
			this.btnDongY.Location = new System.Drawing.Point(224, 12);
			this.btnDongY.Name = "btnDongY";
			this.btnDongY.Size = new System.Drawing.Size(77, 31);
			this.btnDongY.TabIndex = 33;
			this.btnDongY.Text = "Đồng Ý";
			this.btnDongY.UseVisualStyleBackColor = false;
			this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(224, 99);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(77, 34);
			this.btnXoa.TabIndex = 34;
			this.btnXoa.Text = "Đóng";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// ThemBotBieuThuc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(313, 148);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnDongY);
			this.Controls.Add(this.clbExpression);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ThemBotBieuThuc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm Bớt Biểu Thức";
			this.Load += new System.EventHandler(this.ThemBotBieuThuc_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbExpression;
		private System.Windows.Forms.Button btnDongY;
		private System.Windows.Forms.Button btnXoa;
	}
}