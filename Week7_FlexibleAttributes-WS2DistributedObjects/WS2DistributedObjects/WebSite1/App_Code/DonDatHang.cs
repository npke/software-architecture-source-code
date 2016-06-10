using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

public class DonDatHang
{
    public int MSDDH;
    public ChiTietDonDatHang[] ChiTiet;
    private static int NextMSDDH = 1;
    public DonDatHang()
    {
        this.MSDDH = DonDatHang.NextMSDDH++;

    }
    public double TongTriGia()
    {
        double kq = 0;
        for (int i = 0; i < ChiTiet.Length; i++)
            kq += ChiTiet[i].DonGia * ChiTiet[i].SoLuong;
        return kq;
    }
}