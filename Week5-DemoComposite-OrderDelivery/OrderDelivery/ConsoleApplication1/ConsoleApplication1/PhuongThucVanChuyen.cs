using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class PhuongThucVanChuyen
    {

        private static PhuongThucVanChuyen[] sample = new PhuongThucVanChuyen[]
        {
            new VanChuyenDuongBien(),
            new VanChuyenDuongHangKhong()
        };

        internal static PhuongThucVanChuyen ChonPhuongThucPhuHop(float trongLuong, float khoangCach, int soNgaymax)
        {
            PhuongThucVanChuyen kq = null;
            int SoNgay0, SoNgay1;
            SoNgay0 = sample[0].TinhThoiGianGiaoHang(khoangCach);
            SoNgay1 = sample[1].TinhThoiGianGiaoHang(khoangCach);
            float GiaTien0, GiaTien1;
            GiaTien0 = sample[0].TinhChiPhi(trongLuong, khoangCach);
            GiaTien1 = sample[1].TinhChiPhi(trongLuong, khoangCach);
            int idx = TinhPhuongAnTotHon(SoNgay0, SoNgay1, GiaTien0, GiaTien1);
            if (idx == -1)
                //return null; // huy don dat hang, potay
                return sample[LayPhuongThucMacDinh()];
            return sample[idx];
        }

        private static int LayPhuongThucMacDinh()
        {
            return 1;
        }

        private static int TinhPhuongAnTotHon(int soNgay0, int soNgay1, float giaTien0, float giaTien1)
        {
            return 0; // dummy
        }

        internal virtual int TinhThoiGianGiaoHang(float khoangCach)
        {
            return 0;
        }

        internal virtual float TinhChiPhi(float trongLuong, float khoangCach)
        {
            return 0.0f;
        }
    }
}