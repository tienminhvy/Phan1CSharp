using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai10BTTongHop // Note: actual namespace depends on the project name.
{
    class Program
    {
        /// <summary>
        /// Chương trình tạo ra số ngẫu nhiên từ 0 đến 500
        /// </summary>
        /// <returns>số nguyên từ 0 đến 500</returns>
        static int ngauNhien()
        {
            Random rd = new Random();
            return rd.Next(501);
        }
        /// <summary>
        /// Game đoán số ngẫu nhiên từ 0 đến 500
        /// </summary>
        static void doanSo()
        {
            int n,d=1, nNgauNhien;
            bool doanTrung = false;
            string tiepTuc;
            do
            {
                Console.WriteLine("=====================");
                Console.WriteLine("Game đoán số [0..500]");
                nNgauNhien = ngauNhien();
                do
                {
                    Console.Write("Mời thím đoán số: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Số lần thím đã đoán: {0}", d);
                    if (n > nNgauNhien)
                    {
                        Console.WriteLine("Số thím đoán lớn hơn số máy tạo ra.");
                        doanTrung = false;
                    }
                    else if (n < nNgauNhien)
                    {
                        Console.WriteLine("Số thím đoán nhỏ hơn số máy tạo ra.");
                        doanTrung = false;
                    }
                    else if (n == nNgauNhien)
                    {
                        doanTrung = true;
                    }
                    d++;

                    if (doanTrung == true) Console.WriteLine("Chúc mừng thím đã đoán trúng số của máy tạo ra!!1");
                    else if (d > 7)
                    {
                        Console.WriteLine("Trò chơi kết thúc do thím đã đoán sai 7 lần.");
                        Console.WriteLine("Số của máy đã tạo ra là: {0}", nNgauNhien);
                        break;
                    }
                } while (n != nNgauNhien);
                Console.Write("Thím có muốn tiếp tục hay không? (c/k): ");
                tiepTuc = Console.ReadLine();
                if (tiepTuc == "k") break;
                else d = 1;
            } while (true);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            doanSo();
            Console.ReadKey();
        }
    }
}