using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double dai;
        private double rong;
        public ChuNhat() { }
        public ChuNhat(double dai,double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double chieudai
        {
            set { dai = value; }
            get { return dai; }
        }
        public double canh
        {
            set { canh = value; }
            get { return canh; }
        }
        public double chieurong
        {
            set { rong = value; }
            get { return rong; }
        }
        public virtual double Tinhchuvi()
        {
            return (dai + rong) * 2;
        }
        public virtual double Tinhdientich()
        {
            return dai * rong;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Chieu dai: {0} \t-Chieu rong: {1} \t-Chu vi': {2} \tDien tich: {3} ",
                chieudai, chieurong, Tinhchuvi(), Tinhdientich());
        }
    }
}
