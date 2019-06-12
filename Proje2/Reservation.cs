using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Reservation
    {
        DateTime startdate;
        DateTime enddate;

        string placename;
        int roomnum;
        string username;
        string reserveid;



        public string Reserveid { get => reserveid; set => reserveid = value; }
        public DateTime Startdate { get => startdate; set => startdate = value; }
        public DateTime Enddate { get => enddate; set => enddate = value; }
        public string Placename { get => placename; set => placename = value; }
        public int Roomnum { get => roomnum; set => roomnum = value; }
        public string Username { get => username; set => username = value; }


        void ShowReserv()
        {

        }
    }
}
