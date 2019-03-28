using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            sachgiaokhoa a = new sachgiaokhoa();
            a.In();
            sachgiaokhoa b = new sachgiaokhoa();
            b.nhap();
            b.In();
            Console.ReadLine();
        }
    }
}
