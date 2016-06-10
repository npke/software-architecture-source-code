using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

public class SanPham
{
    private int mSSP;
    private string tenSP;
    private double donGia;

    public SanPham()
    {

    }
    public SanPham(int mssp, string tensp, double dongia)
    {
        MSSP = mssp;
        TenSP = tensp;
        DonGia = dongia;
    }

    public int MSSP
    {
        get
        {
            return mSSP;
        }

        set
        {
            mSSP = value;
        }
    }

    public string TenSP
    {
        get
        {
            return tenSP;
        }

        set
        {
            tenSP = value;
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

}