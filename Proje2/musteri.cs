using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


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

        public musteri(string username, string tel, string f_name, string l_name, string password)
        {
            this.Username = username;
            this.f_name = f_name;
            this.l_name = l_name;
            this.tel_no = tel;
            using (SHA512 shaM = new SHA512Managed())
            {
                this.Pass_hash = BitConverter.ToString(shaM.ComputeHash(Encoding.UTF8.GetBytes(password))).Replace("-", "");
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
