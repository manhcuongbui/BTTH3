using System;
using System.Collections.Generic;
using System.Text;

namespace btth3 //BAI2-bth4: Xây dựng chương trình quản lý lương cho công ty ABC
/* Thông tin để tính lương
cho mỗi Nhân viên trong công ty bao gồm: Họ tên, quê quán, hệ số lương, lương cơ bản.
Hãy nhập váo một danh sách các Nhân viên của công ty sau đó thực hiện các yêu cầu
sau:
- Tính và hiện thị lương của các Nhân viên có trong danh sách
- Liệt kê những nhân viên có hệ số lương cao nhất
- Sắp xếp danh sách theo thứ tự tăng dần của trường Họ tên*/
// TUONG TU VD20_QUAN LY NV
{
    class NHANVIEN
    {
        private string hoten, quequan;
        private double hesoluong;
        private static int luongcoban = 1050;

        public NHANVIEN()
        {
            hoten = quequan = "";
            hesoluong = 0;
        }

        public NHANVIEN(string hoten, string quequan, double hesoluong)
        {
            this.hoten = hoten;
            this.quequan = quequan;
            this.hesoluong = hesoluong;
        }

        public static int Luongcoban
        {
            get
            {
                return luongcoban;
            }
            set
            {
                if (value > 1050) 
                    luongcoban = value;
            }
        }

        public double Hesoluong
        {
            get
            {
                return hesoluong;
            }
        }

        public string Hoten
        {
            get
            {
                int n = hoten.LastIndexOf(" ");
                return hoten.Substring(n + 1) + " " + hoten.Substring(0, n);
            }
        }
        //=================================================================================
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("họ tên: ");
            hoten = Console.ReadLine();
            Console.Write("Que Quan: ");
            quequan = Console.ReadLine();
            Console.Write("He So Luong: ");
            hesoluong = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("{0}\n\n{1}\n\n{2}", Hoten, quequan, hesoluong); ;
            Console.WriteLine();
        }

        public double TinhLuong()
        {
            return hesoluong * luongcoban;
        }

    }

    class QLNV
    {
        private NHANVIEN[] ds;
        private int slnv;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("số lượng nhân viên:");
            slnv = int.Parse(Console.ReadLine());
            ds = new NHANVIEN
                [slnv];
            for (int i = 0; i < slnv; i++)
            {
                ds[i] = new NHANVIEN();
                ds[i].Nhap();
            }
        }
        /// <summary>
        /// /============================================================================
        /// </summary>
        public void Hien()
        {
            for (int i = 0; i < slnv; i++)
                ds[i].Hien();
        }
        //========================================================================================
        public double MaxHsl()
        {
            double max = ds[0].Hesoluong;
            for (int i = 0; i < slnv; i++)
                if (ds[i].Hesoluong > max) max = ds[i].Hesoluong;
            return max;
        }
        //=========================================================================================
        // hiên thị hệ số lương cao nhất

        public void HienMaxHsl()
        {
            double max = MaxHsl();
            for (int i = 0; i < slnv; i++)
                if (ds[i].Hesoluong == max) ds[i].Hien();
        }

        public void SapXep()
        {
            for (int i = 0; i < slnv - 1; i++)
                for (int j = i + 1; j < slnv; j++)
                    if (string.Compare(ds[i].Hoten, ds[j].Hoten) > 0)
                    {
                        NHANVIEN tg = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tg;
                    }
        }
    }
    //=================================================================================================
    class Test
    {
        static void Main6(string[] args)
        {
            QLNV t = new QLNV();
            t.Nhap();
            t.Hien();
            Console.WriteLine("Nhan vien sau khi sap xep");
            t.SapXep();
            t.Hien();
            Console.ReadKey();
        }
    }
}
