using System;
using System.Collections.Generic;
using System.Text;

namespace btth3 // bai3-BTH4:/* */
{/* : Xây dựng lớp Person để quản lý họ tên, năm sinh, điểm chín môn học của tất cả
các học viên của lớp học. Cho biết bao nhiêu học viên trong lớp được phép làm luận văn
tốt nghiệp, bao nhiêu học viên thi tốt nghiệp, bao nhiêu người phải thi lại và tên môn thi
lại. Tiêu chuẩn để xét:
- Làm luận văn phải có điểm trung bình lớn hơn 7 trong đó không có môn nào dưới 5.
- Thi tốt nghiệp khi điểm trung bình không lớn hơn 7 và điểm các môn không dưới 5.
- Thi lại có môn dưới 5. */
    // same bai4-BTH3!
    class Person
    {
        private string hoten;
        private int namsinh;
        private double diemthi;

        public Person()
        {
            hoten = " ";
            diemthi = 0;
            namsinh = 1900;

        }
        //======================================================
        public Person(string hoten, double diemthi, int namsinh)
        {
            this.hoten = hoten;
            this.diemthi = diemthi;
            this.namsinh = namsinh;
        }
        // nhập thông tin 

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Họ tên học viên : ");
            hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Điểm thi= ");
            diemthi = double.Parse(Console.ReadLine());
            Console.Write("Năm sinh");
            namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //===========================================================================
        }
        // hiển thị thông tin học sinh
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("HỌ TÊN HỌC VIÊN {0}", hoten);
            Console.WriteLine("NĂM SINH{0} ", namsinh);
            Console.WriteLine("ĐIỂM THI{0} ", diemthi);
        }
        //

    }
    class TEst
    {
        static void Main(string[] args)
        {

        }
    }
}


