using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class sach
    {
        string masach;
        string ngaynhap;
        public sach()
        {
            this.masach = "123a";
            this.ngaynhap = "12/03/2019";
        }
        public void nhap()
        {
            Console.WriteLine("nhap ma sach");
            this.masach = Console.ReadLine();
            Console.WriteLine("nhap ngay nhap");
            this.ngaynhap = Console.ReadLine();

        }
        public void In()
        {
            Console.WriteLine("ma sach la {0} co ngay nhap la {1} ", this.masach, this.ngaynhap);

        }
    }
}