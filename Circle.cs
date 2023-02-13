using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh
{
    public class Circle:ChonHinh
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public Circle() : base() { }
        public Circle(String tenhinh, double r) : base(tenhinh)
        {
            this.r = r;
        }
        public double caculArea()
        {
            return (this.r * this.r) * Math.PI;
        }
        public void NhapTron()
        {
            base.NhapHinh();
            Console.Write("Nhap r:");
            this.r = double.Parse(Console.ReadLine());
        }
        public void XuatTron()
        {
            base.XuatHinh();
            Console.WriteLine("Ban kinh r:" + this.r);
            Console.WriteLine("Dien tich:" + this.caculArea());
        }

    }
    }
