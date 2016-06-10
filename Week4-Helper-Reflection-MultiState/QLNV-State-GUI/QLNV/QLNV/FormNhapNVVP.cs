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
    public partial class FormNhapNVVP : Form
    {
        public FormNhapNVVP()
        {
            InitializeComponent();
        }

        public int SoNgay;
        public float DonGia;

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSoNgay.Text, out SoNgay))
            {
                MessageBox.Show("Vui lòng nhập số ngày công");
                textBoxSoNgay.Focus();
                return;
            }

            if (!float.TryParse(textBoxDonGia.Text, out DonGia))
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                textBoxSoNgay.Focus();
                return;
            }

            Close();
        }

        private void labelSoNgay_Click(object sender, EventArgs e)
        {

        }

        private void labelDonGia_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSoNgay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
