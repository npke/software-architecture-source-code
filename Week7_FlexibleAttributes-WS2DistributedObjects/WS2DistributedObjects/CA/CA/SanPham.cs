using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class SanPham
    {
        private int MSSP;

        public string TenSanPham
        {
            get
            {
                return ServerConnectionHelper.Helper.LayTenSanPhamTheoMSSP(this.MSSP);
            }
            set
            {
                ServerConnectionHelper.Helper.CapNhatTenSanPhamTheoMSSP(this.MSSP, value);
            }
        }

        internal static SanPham[] TimSanPhamTheoTen(string tenSP)
        {
            ServiceReference.SanPham[] kqTemp = ServerConnectionHelper.Helper.TimSanPhamTheoTen(tenSP);
            SanPham[] kq = new SanPham[kqTemp.Length];
            for (int i=0; i<kq.Length; i++)
            {
                kq[i] = new SanPham();
                kq[i].MSSP = kqTemp[i].MSSP;
            }

            return kq;
        }
    }
}