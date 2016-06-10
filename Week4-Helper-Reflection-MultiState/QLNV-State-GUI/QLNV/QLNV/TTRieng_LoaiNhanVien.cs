using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNV
{
    public abstract class TTRieng_LoaiNhanVien
    {
        internal virtual float TinhLuong()
        {
            return 0;
        }

        internal abstract void NhapLieu();
    }
}