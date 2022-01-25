using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai11 // Note: actual namespace depends on the project name.
{
    class Program
    {
        /// <summary>
        /// Giải phương trình bậc 2
        /// </summary>
        /// <param name="a">Hệ số a</param>
        /// <param name="b">Hệ số b</param>
        /// <param name="c">Hệ số c</param>
        /// <returns>String</returns>
        static string giaiPhuongTrinhBac2(int a,int b,int c)
        {
            if (a == 0)
            {
                if (b == 0 && c == 0)
                    return "Vô số nghiệm";
                if (b == 0 && c != 0)
                    return "Vô nghiệm";
                return "x=" + (-c*1.0 / b);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    return "Vô nghiệm";
                if (delta == 0)
                {
                    double x = -b/2*a;
                    return "Nghiệm kép x1 = x2 = " + x;
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    return "x1 = " + x1 + ", x2 = " + x2;
                }
            } 
                
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // th1
            string kq = giaiPhuongTrinhBac2(0, 0, 0);
            Console.WriteLine(kq);
            // th2
            kq = giaiPhuongTrinhBac2(0, 0, 5);
            Console.WriteLine(kq);
            // th3
            /*
             0x^2+8x+3=0
            8x=-3
            x=-3/8=-0.375
             */
            kq = giaiPhuongTrinhBac2(0, 8, 3);
            Console.WriteLine(kq);
            // th4
            /*
             2x^2+5x-7=0
             */
            kq = giaiPhuongTrinhBac2(2, 5, -7);
            Console.WriteLine(kq);
            Console.ReadKey();
        }
    }
}