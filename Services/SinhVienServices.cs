using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SinhVienServices
    {
        private readonly List<SinhVien> sv = new List<SinhVien>();
        public void Add(SinhVien s)
        {
            if (string.IsNullOrWhiteSpace(s.MaSV))
            {
                throw new Exception("ko đc để trống ");
            }
            if (sv.Any(x => x.MaSV == s.MaSV))
            {
                throw new Exception("ko đc trùng");
            }
            if (s.Tuoi <= 17)
            {
                throw new Exception("tuoi phai tren 17");
            }
            sv.Add(s);
        }
    }
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public float DiemTrungBinh { get; set; }
        public int KyHoc { get; set; }
        public string ChuyenNganh { get; set; }

        public SinhVien(string maSV, string ten, int tuoi, float diemTrungBinh, int kyHoc, string chuyenNganh)
        {
            MaSV = maSV;
            Ten = ten;
            Tuoi = tuoi;
            DiemTrungBinh = diemTrungBinh;
            KyHoc = kyHoc;
            ChuyenNganh = chuyenNganh;
        }
    }
}
