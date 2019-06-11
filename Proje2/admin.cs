using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proje2
{
    class admin : Kullanici
    {
        public admin(String usern,String pass)
        {
            this.Username = usern;


            using (SHA512 shaM = new SHA512Managed())
            {
                this.Pass_hash = BitConverter.ToString(shaM.ComputeHash(Encoding.UTF8.GetBytes(pass))).Replace("-", "");
            }
            if (SystemControl.Userlist.Count == 0)
            {
                this.Id = 0.ToString();
            }
            else
            {
                this.Id = (Convert.ToInt32(SystemControl.Userlist.Last().Id) + 1).ToString();
            }

        }




        void CreateOtel(String type, String sehir, string isim, int star)
        {

           // SystemControl.Otellist.Add(otel);
        }

        void DelUser(int id)
        {
            
        }

        void AddRoom(otel otelname, int rno, int bno, string size, bool sea, bool bar, bool ac)
        {
            otelname.Odalist.Add(new Oda(rno,bno,size,sea,bar,ac));
        }

        void ShowReport()
        {

        }

    }
}
