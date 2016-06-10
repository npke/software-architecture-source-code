using System;

namespace QLNV
{
    internal class QuanLyNhanSu
    {
        internal static NhanVien TuyenNhanVien(string strLoaiNhanVien)
        {
            NhanVien nv = new NhanVien();
            if (strLoaiNhanVien == "Nhan vien van phong")
            {
                nv.ChuyenDoiSangBoPhanVanPhong();
            }
            else if (strLoaiNhanVien == "Nhan vien san xuat")
            {
                nv.ChuyenDoiSangBoPhanSanXuat();
            }
            nv.NhapLieu();
            return nv;
        }
    }
}