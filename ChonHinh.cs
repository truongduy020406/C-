using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh
{
    public class ChonHinh
    {
        private String tenhinh;
        protected String Tenhinh
        {
            get { return tenhinh; }
            set { tenhinh = value; }
        }

        public ChonHinh() { }
        public ChonHinh(String tenhinh)
        {
            this.tenhinh = tenhinh;
        }
        public void NhapHinh()
        {
            Console.Write("Nhap ten hinh:");
            this.tenhinh = Console.ReadLine();
        }
        public void XuatHinh()
        {
            Console.Write("Nhap ten hinh:" + this.tenhinh);
        }
    }
}
