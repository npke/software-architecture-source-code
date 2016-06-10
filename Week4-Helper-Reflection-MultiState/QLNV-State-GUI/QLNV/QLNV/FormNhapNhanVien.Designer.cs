namespace QLNV
{
    partial class FormNhapNhanVien
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
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxMSNV = new System.Windows.Forms.TextBox();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelMSNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(105, 32);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(156, 20);
            this.textBoxHoTen.TabIndex = 0;
            // 
            // textBoxMSNV
            // 
            this.textBoxMSNV.Location = new System.Drawing.Point(105, 66);
            this.textBoxMSNV.Name = "textBoxMSNV";
            this.textBoxMSNV.Size = new System.Drawing.Size(156, 20);
            this.textBoxMSNV.TabIndex = 1;
            // 
            // buttonDongY
            // 
            this.buttonDongY.Location = new System.Drawing.Point(105, 102);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(75, 23);
            this.buttonDongY.TabIndex = 2;
            this.buttonDongY.Text = "Đồng ý";
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(13, 32);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(39, 13);
            this.labelHoTen.TabIndex = 3;
            this.labelHoTen.Text = "Họ tên";
            // 
            // labelMSNV
            // 
            this.labelMSNV.AutoSize = true;
            this.labelMSNV.Location = new System.Drawing.Point(13, 69);
            this.labelMSNV.Name = "labelMSNV";
            this.labelMSNV.Size = new System.Drawing.Size(86, 13);
            this.labelMSNV.TabIndex = 4;
            this.labelMSNV.Text = "Mã số nhân viên";
            // 
            // NhapNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.labelMSNV);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.textBoxMSNV);
            this.Controls.Add(this.textBoxHoTen);
            this.Name = "NhapNhanVien";
            this.Text = "Thông tin nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxMSNV;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelMSNV;
    }
}