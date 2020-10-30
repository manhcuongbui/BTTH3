using System;
using System.Text;

namespace btth3 /* bài 5-BTH3:Xây dựng một lớp vecto và hiện các phép toán trên vector gồm có tổng, hiệu, tích
hai vecto */
{  
class Vecto
    {
        private int n;
        private int[] a;
        //- Phương thức khởi tạo 

        public Vecto()
        {
            n = 2;
            a = new int[2];
        }
        public Vecto(int n)
        {
            this.n = n;
            a = new int[n];
        }
        // phương thức nhập
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin của vecto");
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        // phương thức hiện
        public void Hien()
        {
            Console.WriteLine("Thông tin của vecto:");
            for (int i = 0; i < n; ++i)
                Console.Write("{0},", i);
        }
        //=====================================================================
        // tổng hai vecto
        public Vecto Tong(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.a[i] = this.a[i] + t2.a[i];
                return t;
            }
            else return null;
        }
        //=====================================================================
        // hiệu hai vecto
        public Vecto Hieu(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.a[i] = this.a[i] + t2.a[i];
                return t;
            }
            else return null;
        }

    }
    // test 
    //=======================================================================
    class TEST
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vecto tin cho vecto 1:");
            Vecto t1 = new Vecto(5); t1.Nhap();
            Console.WriteLine("Nhập thông tin cho vecto 2:");
            Vecto t2 = new Vecto(5); t2.Nhap();
            Console.WriteLine("Tổng hai vecto:");
            Vecto t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("Hai vecto không cùng kích thước ----> không tính được");
            else
            {
                Console.WriteLine("Tổng hai vecto:");
                t3.Hien();
            }
            Console.ReadKey();

        }
    }


}
