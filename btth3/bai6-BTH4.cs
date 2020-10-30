using System;
using System.Collections.Generic;
using System.Text;

namespace btth3 /* bai6-BTH4: Xây dựng lớp NGUOI nhằm thể hiện một người bất kỳ. Các thông tin về một
người bao gồm; họ tên, năm sinh, chiều cao(tính bằng m-có số lẻ), trọng lượng(tính bằng
kg-có số lẻ)*/
{
    class NGUOI
    {
        private string hoten;
        private int namsinh;
        private double chieucao, trongluong;
        public NGUOI()
        {
            hoten = " ";
            namsinh = 1900;
            chieucao = trongluong = 0;
        }
        public NGUOI(string hoten, double chieucao,double trongluong, int namsinh)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.chieucao = chieucao;
            this.trongluong = trongluong;
        }
        //---------------------------------------------------------------------------------------------


    }
}
