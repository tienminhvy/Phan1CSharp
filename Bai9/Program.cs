using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai9 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void testingMath()
        {
            Console.Write("Mời thím nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Căn bậc 2 của a là: {0}",Math.Sqrt(a));
            Console.Write("Mời thím nhập góc: ");
            int goc = Convert.ToInt32(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("sin({0})={1}", goc, Math.Sin(radian));

            double n = 7.1454695651465232848;
            Console.WriteLine("n ban dau: {0}",n);
            n = Math.Round(n, 2);
            Console.WriteLine("n sau khi lam tron: {0}", n);
        }

        static void testRandom()
        {
            // khởi tạo random
            Random rd = new Random();
            Console.WriteLine(rd.Next(101));
            Console.WriteLine(rd.Next(-50,-48));
            Console.WriteLine(rd.NextDouble());
        }

        static void testNgayThang()
        {
            DateTime dt = new DateTime(2022,6,10);
            string sinhNhat = dt.ToString("dd/MM/yyyy");
            Console.WriteLine("Sinh nhật của thím là: {0}", sinhNhat);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // testingMath();
            // testRandom();
            testNgayThang();
        }

    }
}