using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    abstract class otel
    {
        List<Oda> odalist = new List<Oda>();
        List<Reservation> reservelist = new List<Reservation>();
        int star;
        String city;
        string type;
        string otelname;

        public List<Reservation> Reservelist { get => reservelist; set => reservelist = value; }
        public List<Oda> Odalist { get => odalist; set => odalist = value; }
        public string Type { get => type; set => type = value; }
        public string City { get => city; set => city = value; }
        public int Star { get => star; set => star = value; }
        public string Otelname { get => otelname; set => otelname = value; }




    }
}
