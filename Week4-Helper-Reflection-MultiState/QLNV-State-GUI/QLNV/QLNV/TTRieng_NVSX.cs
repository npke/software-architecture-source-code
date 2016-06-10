using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNV
{
    public class TTRieng_NVSX : TTRieng_LoaiNhanVien
    {
        private int _SLSanPham;
        private float _DonGiaSanPham;
        internal override float TinhLuong()
        {
            return _SLSanPham * _DonGiaSanPham;
        }
        internal override void NhapLieu()
        {
            FormNhapNVSX formNhapNVSX = new FormNhapNVSX();
            formNhapNVSX.ShowDialog();
            _SLSanPham = formNhapNVSX.SLSanPham;
            _DonGiaSanPham = formNhapNVSX.DonGia;
        }
    }
}