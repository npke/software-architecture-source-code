using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoMessageBroker
{
    public class CGVFilmImporter : FilmImporter
    {
        public override SuatChieuPhim Convert(object input)
        {
            CGVFilmInfo info = (CGVFilmInfo)input;
            SuatChieuPhim result = new SuatChieuPhim();
            result.TenPhim = info.Title;
            result.TenRap = info.Cinema;
            result.NgayGioChieu = info.StartTime;
            result.MaSoPhong = -1 ;
            return result;

        }

        public override bool IsValidInput(object input)
        {
            try
            {
                CGVFilmInfo info = (CGVFilmInfo)input;
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}