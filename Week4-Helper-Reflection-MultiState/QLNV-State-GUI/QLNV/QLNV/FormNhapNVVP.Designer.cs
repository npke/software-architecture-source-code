namespace QLNV
{
    partial class FormNhapNVVP
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
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelSoNgay = new System.Windows.Forms.Label();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxSoNgay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(24, 49);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(44, 13);
            this.labelDonGia.TabIndex = 9;
            this.labelDonGia.Text = "Đơn giá";
            this.labelDonGia.Click += new System.EventHandler(this.labelDonGia_Click);
            // 
            // labelSoNgay
            // 
            this.labelSoNgay.AutoSize = true;
            this.labelSoNgay.Location = new System.Drawing.Point(24, 12);
            this.labelSoNgay.Name = "labelSoNgay";
            this.labelSoNgay.Size = new System.Drawing.Size(73, 13);
            this.labelSoNgay.TabIndex = 8;
            this.labelSoNgay.Text = "Số ngày công";
            this.labelSoNgay.Click += new System.EventHandler(this.labelSoNgay_Click);
            // 
            // buttonDongY
            // 
            this.buttonDongY.Location = new System.Drawing.Point(116, 82);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(75, 23);
            this.buttonDongY.TabIndex = 7;
            this.buttonDongY.Text = "Đồng ý";
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(116, 46);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(156, 20);
            this.textBoxDonGia.TabIndex = 6;
            this.textBoxDonGia.TextChanged += new System.EventHandler(this.textBoxDonGia_TextChanged);
            // 
            // textBoxSoNgay
            // 
            this.textBoxSoNgay.Location = new System.Drawing.Point(116, 12);
            this.textBoxSoNgay.Name = "textBoxSoNgay";
            this.textBoxSoNgay.Size = new System.Drawing.Size(156, 20);
            this.textBoxSoNgay.TabIndex = 5;
            this.textBoxSoNgay.TextChanged += new System.EventHandler(this.textBoxSoNgay_TextChanged);
            // 
            // FormNhapNVVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.labelDonGia);
            this.Controls.Add(this.labelSoNgay);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.textBoxSoNgay);
            this.Name = "FormNhapNVVP";
            this.Text = "FormNhapNVVP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.Label labelSoNgay;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxSoNgay;
    }
}