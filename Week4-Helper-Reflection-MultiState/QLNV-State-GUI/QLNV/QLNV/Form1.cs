using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxLoaiNhanVien.Items.Add("Nhan vien van phong");
            comboBoxLoaiNhanVien.Items.Add("Nhan vien san xuat");
            comboBoxLoaiNhanVien.SelectedIndex = 0;
        }

        private void buttonNhapThongTin_Click(object sender, EventArgs e)
        {
            if (comboBoxLoaiNhanVien.SelectedIndex == -1)
                return;

            QuanLyNhanSu.TuyenNhanVien(
                comboBoxLoaiNhanVien.Items[comboBoxLoaiNhanVien.SelectedIndex].ToString());
        }
    }
}
