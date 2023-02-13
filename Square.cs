using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh
{
    public class Square:ChonHinh
    {
        private int a;
        public int R
        {
            get { return a; }
            set { a = value; }
        }
        public Square() : base() { }
        public Square(String tenhinh, int a) : base(tenhinh)
        {
            this.a = a;
        }
        public double tinhDienTich()
        {
            return (this.a * this.a) ;
        }
        public void NhapVuong()
        {
            base.NhapHinh();
            Console.Write("Nhap a:");
            this.a = int.Parse(Console.ReadLine());
        }
        public void XuatVuong()
        {
            base.XuatHinh();
            Console.WriteLine(" nhập cạnh a:" + this.a);
            Console.WriteLine("Dien tich hinh vuông là :" + this.tinhDienTich());
        }

    }
}
