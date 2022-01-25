using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Bai12 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void hocBietLe1()
        {
            try
            {
                Console.Write("Mời thím nhập vào ngày tháng năm sinh: ");
                string s = Console.ReadLine();

                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine($"Thím vừa nhập ngày tháng năm sinh: {birthday.ToString("dd/MM/yyyy")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Chạy bất chấp lỗi hay không.");
            }
        }
        static void hocBietLe2()
        {
            Console.Write("Mời thím nhập tử số: ");
            int tu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời thím nhập mẫu số: ");
            int mau = Convert.ToInt32(Console.ReadLine());
            if (mau == 0)
                throw new ArithmeticException("Mẫu số phải khác 0");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                hocBietLe2();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}