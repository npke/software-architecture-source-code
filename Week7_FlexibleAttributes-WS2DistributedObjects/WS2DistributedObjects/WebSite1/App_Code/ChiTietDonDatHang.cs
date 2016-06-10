using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

public class ChiTietDonDatHang
{
    private SanPham sP;
    private double donGia;
    private int soLuong;

    public SanPham SP
    {
        get
        {
            return sP;
        }

        set
        {
            sP = value;
        }
    }

    public double DonGia
    {
        get
        {
            return donGia;
        }

        set
        {
            donGia = value;
        }
    }

    public int SoLuong
    {
        get
        {
            return soLuong;
        }

        set
        {
            soLuong = value;
        }
    }
}