using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Proje2
{
    class FileOp
    {


        static public void filewrite()
        {//serialize yerine linq kullanılıyor 
            
            XElement admins = new XElement("admins", from admin in SystemControl.getadminlist() select new XElement("Kullanici", 
                                                   new XElement("username", admin.Username),
                                                   new XElement("passhash",admin.Pass_hash),
                                                   new XElement("id", admin.Id)));

            XElement customers = new XElement("customers", from customer in SystemControl.getcustlist() select new XElement("musteri",
                                                    new XElement("username", customer.Username),
                                                    new XElement("passhash", customer.Pass_hash),
                                                    new XElement("id", customer.Id),
                                                    new XElement("tel", customer.Tel_no),
                                                    new XElement("fname", customer.F_name),
                                                    new XElement("lname",customer.L_name)));
            XElement otels = new XElement("otels", from otel in SystemControl.Otellist//i want to kill myself
                                                   select new XElement("otel", new XElement("type", otel.Type),
                                                                               new XElement("star", otel.Star),
                                                                               new XElement("city", otel.City),
                                                                               new XElement("name", otel.Otelname),
                                                                               new XElement("rooms", (from oda in otel.Odalist select new XElement("oda", new XElement("roomno", oda.Room_no),
                                                                                                                                                          new XElement("Reserved", oda.Reserved),
                                                                                                                                                          new XElement("Bednum", oda.Bed_num),
                                                                                                                                                          new XElement("Size", oda.Size),
                                                                                                                                                          new XElement("seaside", oda.Seaside),
                                                                                                                                                          new XElement("minibar", oda.Minibar),
                                                                                                                                                          new XElement("AC", oda.Ac)))),
                                                                               new XElement("reservations", (from reservation in otel.Reservelist select new XElement("reservation", new XElement("date", reservation.Date),
                                                                                                                                                                                     new XElement("username",reservation.User.Username),
                                                                                                                                                                                     new XElement("reserveid", reservation.Reserveid))))));

        }

        void fileread()
        {

        }

    }
}
