using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNV
{
    public class NhanVien
    {
        private string _HoTen;
        private string _MSNV;
        private TTRieng_LoaiNhanVien thongtinRieng = new TTRieng_NVVP();


        public string HoTen
        {
            get
            {
                return _HoTen;
            }

            set
            {
                _HoTen = value;
            }
        }

        internal void NhapLieu()
        {
            FormNhapNhanVien formNhapNhanVien = new FormNhapNhanVien();
            formNhapNhanVien.ShowDialog();
            HoTen = formNhapNhanVien.HoTen;
            MSNV = formNhapNhanVien.MSNV;

            thongtinRieng.NhapLieu();
        }

        public string MSNV
        {
            get
            {
                return _MSNV;
            }

            set
            {
                _MSNV = value;
            }
        }

        public bool ChuyenDoiSangBoPhanSanXuat()
        {
            try
            {
                TTRieng_NVVP temp = (TTRieng_NVVP)thongtinRieng;
                thongtinRieng = new TTRieng_NVSX();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public enum LOAI_NHAN_VIEN
        {
            NVVP, NVSX
        };

        private LOAI_NHAN_VIEN _LoaiNV = LOAI_NHAN_VIEN.NVVP;
        protected LOAI_NHAN_VIEN LoaiNV
        {
            get
            {
                return _LoaiNV;
            }
            set
            {
                _LoaiNV = value;
                if (_LoaiNV == LOAI_NHAN_VIEN.NVSX)
                    thongtinRieng = new TTRieng_NVSX();
                else if (_LoaiNV == LOAI_NHAN_VIEN.NVVP)
                    thongtinRieng = new TTRieng_NVVP();
            }
        }
        public bool ChuyenDoiSangBoPhanVanPhong()
        {
            if (_LoaiNV == LOAI_NHAN_VIEN.NVSX)
            {
                //                _LoaiNV = LOAI_NHAN_VIEN.NVVP;
                //              thongtinRieng = new TTRieng_NVVP();
                LoaiNV = LOAI_NHAN_VIEN.NVSX;
                return true;
            }
            return false;

        }


        public float TinhLuong()
        {
            return thongtinRieng.TinhLuong();
        }


    }
}