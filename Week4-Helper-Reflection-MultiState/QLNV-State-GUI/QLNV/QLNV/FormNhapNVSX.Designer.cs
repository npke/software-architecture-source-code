namespace QLNV
{
    partial class FormNhapNVSX
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
            this.labelSoSanPham = new System.Windows.Forms.Label();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxSoSanPham = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(12, 49);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(44, 13);
            this.labelDonGia.TabIndex = 14;
            this.labelDonGia.Text = "Đơn giá";
            // 
            // labelSoSanPham
            // 
            this.labelSoSanPham.AutoSize = true;
            this.labelSoSanPham.Location = new System.Drawing.Point(12, 15);
            this.labelSoSanPham.Name = "labelSoSanPham";
            this.labelSoSanPham.Size = new System.Drawing.Size(98, 13);
            this.labelSoSanPham.TabIndex = 13;
            this.labelSoSanPham.Text = "Số lượng sản phẩm";
            // 
            // buttonDongY
            // 
            this.buttonDongY.Location = new System.Drawing.Point(116, 82);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(75, 23);
            this.buttonDongY.TabIndex = 12;
            this.buttonDongY.Text = "Đồng ý";
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(116, 46);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(156, 20);
            this.textBoxDonGia.TabIndex = 11;
            // 
            // textBoxSoSanPham
            // 
            this.textBoxSoSanPham.Location = new System.Drawing.Point(116, 12);
            this.textBoxSoSanPham.Name = "textBoxSoSanPham";
            this.textBoxSoSanPham.Size = new System.Drawing.Size(156, 20);
            this.textBoxSoSanPham.TabIndex = 10;
            // 
            // FormNhapNVSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.labelDonGia);
            this.Controls.Add(this.labelSoSanPham);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.textBoxSoSanPham);
            this.Name = "FormNhapNVSX";
            this.Text = "FormNhapNVSX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.Label labelSoSanPham;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxSoSanPham;
    }
}