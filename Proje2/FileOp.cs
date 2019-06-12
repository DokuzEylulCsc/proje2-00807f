using System;
using System.Collections.Generic;
using System.IO;
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

        {//serialize yerine linq kullanılıyor kullanıcıları ve otelleri xmle çevir
            XElement data = new XElement("data", new XElement("Users", new XElement("admins", from admin in SystemControl.getadminlist()
                                                                                              select new XElement("Admin", new XElement("username", admin.Username),
                                                                                                                          new XElement("passhash", admin.Pass_hash),
                                                                                                                          new XElement("id", admin.Id))),
                                                                                 new XElement("customers", from customer in SystemControl.getcustlist()
                                                                                                           select new XElement("musteri", new XElement("username", customer.Username),
                                                                                                                                          new XElement("passhash", customer.Pass_hash),
                                                                                                                                          new XElement("id", customer.Id),
                                                                                                                                          new XElement("tel", customer.Tel_no),
                                                                                                                                          new XElement("fname", customer.F_name),
                                                                                                                                          new XElement("lname", customer.L_name)))),
                                                                                new XElement("otels", from otel in SystemControl.Otellist select new XElement("otel", new XElement("type", otel.Type),
                                                                               new XElement("star", otel.Star),
                                                                               new XElement("city", otel.City),
                                                                               new XElement("name", otel.Otelname),
                                                                               new XElement("rooms", from oda in otel.Odalist
                                                                                                     select new XElement("oda", new XElement("roomno", oda.Room_no),
                                                                                                                                                                     /*new XElement("Reserved", oda.Reserved),*/
                                                                                                                                                                     new XElement("Bednum", oda.Bed_num),
                                                                                                                                                                     new XElement("Size", oda.Size),
                                                                                                                                                                     new XElement("seaside", oda.Seaside),
                                                                                                                                                                     new XElement("minibar", oda.Minibar),
                                                                                                                                                                     new XElement("price", oda.Price),
                                                                                                                                                                     new XElement("AC", oda.Ac))),
                                                                               new XElement("reservations", (from reservation in otel.Reservelist
                                                                                                             select new XElement("reservation", new XElement("startdate", reservation.Startdate),
                                                                                                             new XElement("enddate", reservation.Enddate),
                                                                                                             new XElement("otelname", reservation.Placename),
                                                                                                                                                                                    new XElement("username", reservation.Username),
                                                                                                                                                                                    new XElement("reserveid", reservation.Reserveid)))))));

              

            using (StreamWriter writetext = new StreamWriter("write.xml"))
            {
                writetext.WriteLine(data.ToString());
                //writetext.WriteLine(otels.ToString());
            }


            //debug stuff
            Console.WriteLine(data.ToString());           
            //Console.WriteLine(otels.ToString());
        }

        static public void fileread()
        {



            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("write.xml");

            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes[0].ChildNodes[0].ChildNodes)//adminleri al
            {
                admin placeholder = new admin(node.ChildNodes[0].InnerText, node.ChildNodes[1].InnerText);
                placeholder.Pass_hash = node.ChildNodes[1].InnerText;
                SystemControl.Userlist.Add(placeholder);
                Console.WriteLine(node.ChildNodes[0].InnerText);
            }

            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes[0].ChildNodes[1].ChildNodes)//musterileri al
            {
                musteri placeholder = new musteri(node.ChildNodes[0].InnerText, node.ChildNodes[3].InnerText, node.ChildNodes[4].InnerText, node.ChildNodes[5].InnerText, node.ChildNodes[1].InnerText);
                placeholder.Pass_hash = node.ChildNodes[1].InnerText;
                SystemControl.Userlist.Add(placeholder);//node.ChildNodes[0].InnerText, node.ChildNodes[1].InnerText));
               
            }

            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes[1].ChildNodes)
            {
                switch (node.ChildNodes[0].InnerText)
                {
                    case "Pansiyon":
                        Pansiyon placeholderP = new Pansiyon(node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText,Convert.ToInt32(node.ChildNodes[1].InnerText));
                        foreach(XmlNode roomnode in node.ChildNodes[4].ChildNodes)
                        {
                            placeholderP.Odalist.Add(new Oda(Convert.ToInt32(roomnode.ChildNodes[0].InnerText), Convert.ToInt32(roomnode.ChildNodes[1].InnerText), roomnode.ChildNodes[2].InnerText,bool.Parse(roomnode.ChildNodes[3].InnerText), bool.Parse(roomnode.ChildNodes[4].InnerText),Convert.ToInt32(roomnode.ChildNodes[5].InnerText),bool.Parse(roomnode.ChildNodes[6].InnerText)));
                           // Console.WriteLine(roomnode.ChildNodes[0].InnerText);
                        }                    
                        SystemControl.Otellist.Add(placeholderP);
                        break;
                    case "TatilKoyu":
                        TatilKoyu placeholderT = new TatilKoyu(node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText, Convert.ToInt32(node.ChildNodes[1].InnerText));
                        foreach (XmlNode roomnode in node.ChildNodes[4].ChildNodes)
                        {
                            placeholderT.Odalist.Add(new Oda(Convert.ToInt32(roomnode.ChildNodes[0].InnerText), Convert.ToInt32(roomnode.ChildNodes[1].InnerText), roomnode.ChildNodes[2].InnerText, bool.Parse(roomnode.ChildNodes[3].InnerText), bool.Parse(roomnode.ChildNodes[4].InnerText), Convert.ToInt32(roomnode.ChildNodes[5].InnerText), bool.Parse(roomnode.ChildNodes[6].InnerText)));
                            // Console.WriteLine(roomnode.ChildNodes[0].InnerText);
                        }
                        SystemControl.Otellist.Add(placeholderT);
                        break;
                    case "ButikOtel":
                        ButikOtel placeholderB = new ButikOtel(node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText, Convert.ToInt32(node.ChildNodes[1].InnerText));
                        foreach (XmlNode roomnode in node.ChildNodes[4].ChildNodes)
                        {
                            placeholderB.Odalist.Add(new Oda(Convert.ToInt32(roomnode.ChildNodes[0].InnerText), Convert.ToInt32(roomnode.ChildNodes[1].InnerText), roomnode.ChildNodes[2].InnerText, bool.Parse(roomnode.ChildNodes[3].InnerText), bool.Parse(roomnode.ChildNodes[4].InnerText), Convert.ToInt32(roomnode.ChildNodes[5].InnerText), bool.Parse(roomnode.ChildNodes[6].InnerText)));
                            // Console.WriteLine(roomnode.ChildNodes[0].InnerText);
                        }
                        SystemControl.Otellist.Add(placeholderB);
                        break;
                    default:
                        break;
                }

                /*SystemControl.Otellist.Add(ButikOtel )
                Console.WriteLine(node.ChildNodes[0].InnerText);*/
            }

        }

    }
}
