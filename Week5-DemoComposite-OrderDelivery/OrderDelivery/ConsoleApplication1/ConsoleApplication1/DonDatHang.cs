using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class DonDatHang
    {
        public int MaSo;
        public float TongTriGia;
        public float TrongLuong;
        public float KhoangCach;

        public abstract int SoNgayToiDaGiaoHang();
        protected PhuongThucVanChuyen ptvc = null;
            

        public int ThoiGianGiaoHang()
        {
            ChonPhuongThucVanChuyen();
            return ptvc.TinhThoiGianGiaoHang(KhoangCach);
        }

        private void ChonPhuongThucVanChuyen()
        {
            if (ptvc == null)
                ptvc =
                    PhuongThucVanChuyen.ChonPhuongThucPhuHop(TrongLuong, KhoangCach, SoNgayToiDaGiaoHang());
        }

        public float ChiPhiGiaoHang()
        {
            ChonPhuongThucVanChuyen();
            return ptvc.TinhChiPhi(TrongLuong, KhoangCach);
        }
    }
}