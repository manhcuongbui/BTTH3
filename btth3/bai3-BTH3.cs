﻿using System;
using System.Collections.Generic;
using System.Text;

namespace btth3 //baif3-BTTH3: Xây dựng lớp thời gian Time;
{
    class Time
        // dữ liệu vào giờ,phút,giây.
    {
        private int gio, phut, giay;
        public Time()
        {
            this.gio = 0;
            this.phut = 0;
            this.giay = 0;

        }
        public Time(int gio,int phut,int giay)
        {
            this.gio = gio;
            this.giay = giay;
            this.phut = phut;

        }
        public int Gio
        {
            get
            { return gio; }
            set { gio = value; }
        }
        public int Phut
        {
            get
            { return phut; }
            set
            { phut = value; }
        }
        public int Giay
        {
            get
            { return giay; }
            set
            { giay = value; }
        }
        //+++++++++++++++++++++++++++++++++++++++++++
        public Normalize(int gip,int giay,int phut)
        {
            phut += giay / 60;
            giay = giay % 60;
            gio += phut/ 60;
            phut = phut % 60;
            gio = gio % 24;
          


        }
        //====================================

        public Tiem advance(int gio, int phut,int giay)
        {



        }

    }
    class test
    {
        public void Main3()
        {

        }
    }
}
