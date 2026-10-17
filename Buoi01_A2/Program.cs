/*
 * Bài: Buoi01_A2 - Thẻ giới thiệu bản thân
 * Sinh viên: [Tên của bạn]
 * MSSV: [Mã số sinh viên của bạn]
 * Ngày: 17/10/2026
*/

namespace Buoi01_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Phần đầu thẻ
            Console.WriteLine("===============================");
            Console.WriteLine("         THẺ SINH VIÊN");
            Console.WriteLine("===============================");

            //Nhãn in bằng Write, giá trị in bằng Writeline
            Console.Write("Họ tên : ");
            Console.WriteLine("Vương Thục Lan");

            Console.Write("MSSV : ");
            Console.WriteLine("31251022558");

            Console.Write("Lớp : ");
            Console.WriteLine("EE0001");

            Console.Write("Sở thích : ");
            Console.WriteLine("xem phim, mua sắm");

            //Phần cuối thẻ
            Console.WriteLine("==================================");
        }
    }
}
