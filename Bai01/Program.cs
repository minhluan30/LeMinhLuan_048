using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class SinhVien
    {
        private string Hoten;
        private double Diemtoan;
        private double Diemvan;
        private double DiemNgoaiNgu;
        private string KhoiHoc;
        public SinhVien()
        {
        }
        public string HoTen
        {
            set { Hoten = value; }
            get { return Hoten; }
        }
        public double DiemToan
        {
            set { DiemToan = value; }
            get { return DiemToan; }
        }
        public double DiemVan
        {
            set { DiemVan = value; }
            get { return DiemVan; }
        }
        public double Diemngoaingu
        {
            set { DiemNgoaiNgu = value; }
            get { return DiemNgoaiNgu; }
        }
        public string Khoihoc
        {
            set { KhoiHoc = value; }
            get { return KhoiHoc; }
        }
        public double TinhDiemTrungBinh()
        {
            double Heso = 1;
            switch (KhoiHoc)
            {
                case 'A':
                    Heso = 2;
                    break;

                case 'B':
                    Heso = 2;
                    break;

                case 'C':
                    Heso = 2;
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
