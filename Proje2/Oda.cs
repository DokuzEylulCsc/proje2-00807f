using System;
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

        public int Room_no { get => room_no; set => room_no = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
        public int Bed_num { get => bed_num; set => bed_num = value; }
        public string Size { get => size; set => size = value; }
        public bool Seaside { get => seaside; set => seaside = value; }

        void getinfo()
        {

        }

    }

 

}
