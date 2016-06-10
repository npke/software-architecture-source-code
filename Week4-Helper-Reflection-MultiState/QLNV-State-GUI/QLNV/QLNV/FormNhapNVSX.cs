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
    public partial class FormNhapNVSX : Form
    {
        public FormNhapNVSX()
        {
            InitializeComponent();
        }

        public int SLSanPham;
        public float DonGia;

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSoSanPham.Text, out SLSanPham))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                textBoxSoSanPham.Focus();
                return;
            }

            if (!float.TryParse(textBoxDonGia.Text, out DonGia))
            {
                MessageBox.Show("Vui lòng nhập đơn giá sản phẩm");
                textBoxDonGia.Focus();
                return;
            }

            Close();
        }
    }
}
