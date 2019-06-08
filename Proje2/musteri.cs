using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class musteri : Kullanici
    {
        String tel_no;
        String f_name;
        String l_name;

        public string Tel_no { get => tel_no; set => tel_no = value; }
        public string F_name { get => f_name; set => f_name = value; }
        public string L_name { get => l_name; set => l_name = value; }

        void ReserveRoom(otel otel,DateTime date,Oda oda)
        {
            otel.Reservelist.Add(new Reservation(otel,date,oda,this));
        }

        void SearchOtel()
        {
           
        }

        void ReserveDel()
        {

        }

    }
}
