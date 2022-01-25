using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai8 // Note: actual namespace depends on the project name.
{
    class Program
    {

        static void ham1(ref int a)
        {
            a += 5;
            Console.WriteLine("a trong ham1 la {0}", a);
        }

        static void ham2(out int b)
        {
            b = 10;
            b += 5;
            Console.WriteLine("b trong ham1 la {0}", b);
        }

        static void Main(string[] args)
        {
            /*
             Tham biến ref cần khởi tạo giá trị trước khi tham biến

            Tham biến out không cần khởi tạo giá trị trước khi tham biến
            nhưng phải gán giá trị trước khi thoát hàm
             */
            Console.OutputEncoding = Encoding.UTF8;
            int a = 5;
            Console.WriteLine("a truoc khi goi ham1 la {0}", a);
            ham1(ref a);
            Console.WriteLine("a sau khi goi ham1 la {0}", a);
            int b;
            ham2(out b);
            Console.WriteLine("b sau khi goi ham2 la {0}", b);
        }

    }
}