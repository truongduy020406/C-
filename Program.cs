using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle tg = new Circle();
            tg.NhapTron();
            tg.XuatTron();
            Square cn = new Square();
            cn.NhapVuong();
            cn.XuatVuong();

        }
    }
}
