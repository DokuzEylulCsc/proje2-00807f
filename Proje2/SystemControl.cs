using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class SystemControl
    {
        static List<Kullanici> userlist = new List<Kullanici>();
        static List<otel> otellist = new List<otel>();
        public static admin currentadmin; //o an giris yapan kullanıcı
        public static musteri currentmusteri;

        static public List<otel> Otellist { get => otellist; set => otellist = value; }
        static public List<Kullanici> Userlist { get => userlist; set => userlist = value; }
        

        static public List<admin> getadminlist()
        {
            List<admin> templist = new List<admin>();
            foreach (admin i in userlist.OfType<admin>())
            {
                templist.Add(i);
            }
            return templist;
        }

        static public List<musteri> getcustlist()
        {
            List<musteri> templist = new List<musteri>();
            foreach (musteri i in userlist.OfType<musteri>())
            {
                templist.Add(i);
            }
            return templist;
        }





    }
}
