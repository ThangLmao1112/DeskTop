using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu2
{
    internal class GiaoVien
    {
        public string Maso { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso, string hoten, DateTime ngaysinh,
        DanhMucMonHoc ds, string gt, string[] nn,
        string sdt, string mail)

        {
        this. MaSo - maso;
        this. HoTen = hoten;
        this.NgaySinh = ngaysinh;
        this.dsMonHoc = ds;
        this.GioiTinh = gt;
        this.NgoaiNgu = nn;
        this. SoDT - sdt;
        this.Mail = mail;
        }
public override string ToString()
    { 
            string s = "Ma so;" + Maso + "\n" + "Ho ten:" + HoTen + "\n"
        + "Ngay Sinh:" + NgaySinh.ToString() + "\n"
        + "Gioi tinh:" + GioiTinh + "\n"
        + "SO DT;" + SoDT + "\n"
        + "Mail:" + Mail + "\n";
        string sngoaingu = "Ngoai ngu;";
        foreach (string t in NgoaiNgu)
        sngoaingu += t + ";";
        string Monday = "Danh sach mon day:";
        foreach (MonHoc mh in dsMonHoc.ds)
        Monday += mh + ":"
        s += "\n" + sngoaingu + "\n" + Monday;
        return s;
    }
}
