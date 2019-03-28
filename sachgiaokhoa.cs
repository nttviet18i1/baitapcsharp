using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class sachgiaokhoa : sach
    {
        string tinhtrangsach;
        int dongia;
        int soluong;
        int tien;
        public sachgiaokhoa() : base() {
            this.tinhtrangsach = "moi";
            this.dongia = 9000;
            this.soluong = 5;
        }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap tinh trang sach");
            this.tinhtrangsach = Console.ReadLine();
            Console.WriteLine("nhap don gia");
            this.dongia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong");
            this.soluong = Int32.Parse(Console.ReadLine());
        }
        public int tiensach()
        {
            int tien = 0;
            if (this.tinhtrangsach == "moi")
            {
                tien = this.soluong * this.dongia;
            }
            else if (this.tinhtrangsach == "cu")
            {
                tien = this.soluong * this.dongia * 50;
            }
            return tien;
        }
            public new void In() {
            base.In();
            Console.WriteLine("sach co tien la:" + this.tiensach());
        }

    }
}
         
          

       
