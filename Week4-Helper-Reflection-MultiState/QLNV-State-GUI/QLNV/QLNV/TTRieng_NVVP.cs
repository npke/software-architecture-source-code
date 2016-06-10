using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNV
{
    public class TTRieng_NVVP : TTRieng_LoaiNhanVien
    {
        private int _SoNgay;
        private float _DonGia;
        internal override float TinhLuong()
        {
            return _SoNgay * _DonGia;
        }
        internal override void NhapLieu()
        {
            FormNhapNVVP formNhapNVVP = new FormNhapNVVP();
            formNhapNVVP.ShowDialog();
            _SoNgay= formNhapNVVP.SoNgay;
            _DonGia= formNhapNVVP.DonGia;
        }

    }
}