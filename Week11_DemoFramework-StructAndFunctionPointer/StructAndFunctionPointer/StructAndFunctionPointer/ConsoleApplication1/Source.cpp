#include <string>
using namespace std;

struct ExtraNVVP
{
	int NgayCong;
	float DonGiaNgayCong;
};
struct ExtraNVSX
{
	int SoSP;
	float DonGiaSanPham;
};
struct NhanVien
{
	string	HoTen;
	string	MSNV;
	void*	ExtraData;
	float   (*TinhLuong)(NhanVien nv);
};

float	TinhLuongVP(NhanVien nv)
{
	ExtraNVVP* extra = (ExtraNVVP*)nv.ExtraData;
	return extra->NgayCong*extra->DonGiaNgayCong;
}

float	TinhLuongSX(NhanVien nv)
{
	ExtraNVSX* extra = (ExtraNVSX*)nv.ExtraData;
	return extra->DonGiaSanPham *extra->SoSP;
}


void main()
{
	NhanVien nvvp;
	nvvp.HoTen = "NVA"; nvvp.MSNV = "111";
	ExtraNVVP* temp = new ExtraNVVP;
	temp->DonGiaNgayCong = 10000;
	temp->NgayCong = 20;
	nvvp.ExtraData = (void*)temp;
	nvvp.TinhLuong = TinhLuongVP;

	cout << nvvp.TinhLuong(nvvp);
}








