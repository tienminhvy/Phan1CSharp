using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai4 // Note: actual namespace depends on the project name.
{
    class Program
    {

        /// <summary>
        /// Hàm tính toán abc
        /// </summary>
        /// <param name="a">a giá trị nguyên</param>
        /// <param name="b">b giá trị nguyên</param>
        static void abc(int a, int b)
        {

        }

        static void Main(string[] args)
        {
            int soA, soB;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Hãy nhập số A: ");
            soA = int.Parse(Console.ReadLine());
            Console.Write("Hãy nhập số B: ");
            soB = int.Parse(Console.ReadLine());
            Console.WriteLine("Kết quả của phép toán A+B là {0}", soA + soB);

            abc(soA, soB);
        }

    }
}