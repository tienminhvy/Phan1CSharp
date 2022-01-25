using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai3 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            double diemToan = 9.8;

            Console.WriteLine("Điểm toán = {0}", diemToan);

            var test = 8;
            Console.WriteLine(test.GetType().ToString());
        }
    }
}