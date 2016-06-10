using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    /*    [WebMethod]
        public string HelloWorld() {
            return "Hello World";
        }
        */
        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

    static private List<SanPham> sp = new List<SanPham>();
    static private List<DonDatHang> dondathang = new List<DonDatHang>();

    [WebMethod]
    public void Init()
    {
        sp.Add(new SanPham(1, "iPhone 6s", 700));
        sp.Add(new SanPham(2, "iPhone 7s", 600));
        sp.Add(new SanPham(3, "Macbook Pro", 1400));
    }
    //stateful


    [WebMethod]
    public SanPham[] TimSanPhamTheoTen(string TenSP)
    {
        List<SanPham> temp = new List<SanPham>();
        for (int i = 0; i < sp.Count; i++)
            if (sp[i].TenSP.Contains(TenSP))
                temp.Add(sp[i]);
        return temp.ToArray();
    }

    [WebMethod]
    public int DatHang(ChiTietDonDatHang[] chitiet)
    {
        DonDatHang kq = new DonDatHang();
        kq.ChiTiet = chitiet;
        return kq.MSDDH;
    }

    [WebMethod]
    public double TongTriGiaDonDatHang(int MSDDH)
    {
        DonDatHang ddh = null;
        for (int i=0; i<dondathang.Count; i++)
        {
            if (ddh.MSDDH == MSDDH)
                return ddh.TongTriGia();
        }
        return -1;
    }
    [WebMethod]
    public string LayTenSanPhamTheoMSSP(int MSSP)
    {
        for (int i = 0; i < sp.Count; i++)
            if (sp[i].MSSP == MSSP)
                return sp[i].TenSP;
        return "";
    }
    [WebMethod]
    public void CapNhatTenSanPhamTheoMSSP(int MSSP, string TenSP)
    {
        for (int i = 0; i < sp.Count; i++)
            if (sp[i].MSSP == MSSP)
            {
                sp[i].TenSP = TenSP;
                return;
            } 
    }




}