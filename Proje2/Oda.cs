﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Oda
    {
        int room_no;
        bool reserved;
        int bed_num;
        string size;
        bool seaside;
        bool minibar;
        bool ac;//klima
        int price;


        public int Room_no { get => room_no; set => room_no = value; }
        //public bool Reserved { get => reserved; set => reserved = value; }
        public int Bed_num { get => bed_num; set => bed_num = value; }
        public string Size { get => size; set => size = value; }
        public bool Seaside { get => seaside; set => seaside = value; }
        public bool Minibar { get => minibar; set => minibar = value; }
        public bool Ac { get => ac; set => ac = value; }
        public int Price { get => price; set => price = value; }

        public Oda(int rno,int bno,string size, bool sea, bool bar,int price ,bool ac)
        {
            //this.reserved = false;
            this.room_no = rno;
            this.bed_num = bno;
            this.size = size;
            this.seaside = sea;
            this.minibar = bar;
            this.price = price;
            this.ac = ac;
        }



        void getinfo()
        {

        }

    }

 

}
