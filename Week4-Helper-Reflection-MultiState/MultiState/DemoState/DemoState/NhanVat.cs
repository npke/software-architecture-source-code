using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoState
{
    public class NhanVat
    {
        private float TocDoDiChuyenCoBan = 1.0f;
        List<TrangThai> TrangThaiHienHanh = new List<TrangThai>();
        public float TocDoDiChuyen
        {
            get
            {
                float HeSo = 1;
                for (int i = 0; i < TrangThaiHienHanh.Count; i++)
                    HeSo += TrangThaiHienHanh[i].TyLeDiChuyen();
                if (HeSo < 0)
                    HeSo = 0;
                return TocDoDiChuyenCoBan * HeSo;
            }
        }

        public float TyLeMayMan
        {
            get
            {
                float kq = 0.1f;
                kq += TongMayManDoTrangBi();
                for (int i = 0; i < TrangThaiHienHanh.Count; i++)
                    kq += TrangThaiHienHanh[i].TyLeMayMan();
                
                if (kq < 0)
                    kq = 0;
                if (kq > 1)
                    kq = 1;
                return kq;
            }
        }

        List<TrangBi> trangbi = new List<TrangBi>();
        private float TongMayManDoTrangBi()
        {
            float kq = 0;
            for (int i = 0; i < trangbi.Count; i++)
                kq += trangbi[i].TyLeMayMan();
            return kq;
        }
    }

    class TrangBi
    {
        internal float TyLeMayMan()
        {
            throw new NotImplementedException();
        }
    }
}