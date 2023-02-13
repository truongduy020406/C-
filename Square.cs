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
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public Square() : base()
        { }
        public Square(String tenhinh, int a) : base(tenhinh)
        {
            this.a = a;
        }
        public int caculArea()
        {
            return (this.a * this.a);
        }
        public void NhapVuong()
        {
            base.NhapHinh();
            Console.Write("Canh a:");
            this.a = Int32.Parse(Console.ReadLine());
        }
        public void XuatVuong()
        {
            base.XuatHinh();
            Console.WriteLine("Canh a:" + this.a);
            Console.WriteLine("Dien tich:" + this.caculArea());
        }

    }
}
