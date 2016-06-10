namespace QLNV
{
    partial class Form1
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
            this.comboBoxLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.buttonNhapThongTin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLoaiNhanVien
            // 
            this.comboBoxLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiNhanVien.FormattingEnabled = true;
            this.comboBoxLoaiNhanVien.Location = new System.Drawing.Point(30, 13);
            this.comboBoxLoaiNhanVien.Name = "comboBoxLoaiNhanVien";
            this.comboBoxLoaiNhanVien.Size = new System.Drawing.Size(141, 21);
            this.comboBoxLoaiNhanVien.TabIndex = 0;
            // 
            // buttonNhapThongTin
            // 
            this.buttonNhapThongTin.Location = new System.Drawing.Point(30, 40);
            this.buttonNhapThongTin.Name = "buttonNhapThongTin";
            this.buttonNhapThongTin.Size = new System.Drawing.Size(141, 23);
            this.buttonNhapThongTin.TabIndex = 1;
            this.buttonNhapThongTin.Text = "Nhập thông tin";
            this.buttonNhapThongTin.UseVisualStyleBackColor = true;
            this.buttonNhapThongTin.Click += new System.EventHandler(this.buttonNhapThongTin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 84);
            this.Controls.Add(this.buttonNhapThongTin);
            this.Controls.Add(this.comboBoxLoaiNhanVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLoaiNhanVien;
        private System.Windows.Forms.Button buttonNhapThongTin;
    }
}

