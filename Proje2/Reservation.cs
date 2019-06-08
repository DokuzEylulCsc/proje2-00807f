using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Reservation
    {
        DateTime date;
        otel place;
        Oda room;
        musteri user;
        string reserveid;


        public DateTime Date { get => date; set => date = value; }
        public otel Place { get => place; set => place = value; }
        public Oda Room { get => room; set => room = value; }
        public musteri User { get => user; set => user = value; }
        public string Reserveid { get => reserveid; set => reserveid = value; }



        Reservation(DateTime time, otel otel, Oda oda, musteri musteri)
        {
            this.date = time;
            this.place = otel;
            this.room = oda;
            this.user = musteri;

        }

        public Reservation(otel otel, DateTime date, Oda oda, musteri musteri)
        {
            this.date = date;
        }

        void ShowReserv()
        {

        }
    }
}
