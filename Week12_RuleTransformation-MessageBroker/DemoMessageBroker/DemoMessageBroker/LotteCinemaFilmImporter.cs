using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoMessageBroker
{
    public class LotteCinemaFilmImporter : FilmImporter
    {
        public override SuatChieuPhim Convert(object input)
        {
            ThongTinFilmLotteCinema info = (ThongTinFilmLotteCinema)input;
            SuatChieuPhim result = new SuatChieuPhim();
            result.TenPhim = info.TenPhim;
            result.TenRap = info.TenRap;
            result.NgayGioChieu = ConvertFromStringsToDateTime(info.NgayChieu, info.GioChieu);
            result.MaSoPhong = info.PhongChieu;
            return result;
        }

        private DateTime ConvertFromStringsToDateTime(string ngayChieu, string gioChieu)
        {
            return DateTime.Now; // dummy implementation, hic
        }

        public override bool IsValidInput(object input)
        {
            try
            {
                ThongTinFilmLotteCinema info = (ThongTinFilmLotteCinema)input;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}