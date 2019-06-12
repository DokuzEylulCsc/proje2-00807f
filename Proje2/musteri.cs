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


        public void ReserveRoom(otel otel,DateTime start,DateTime end,Oda oda)
        {
           otel.Reservelist.Add(new Reservation(otel.Otelname,start,end,oda.Room_no,this.Username));
        }

        public List<string> SearchOtel(DateTime start, DateTime end,int bednum,string size,bool sea,bool ac,bool bar,string city)
        {
            List<string> tmplist = new List<string>();

            OtelAggregate aggre = new OtelAggregate();
            foreach (otel z in SystemControl.Otellist)
            {
                aggre.Add(z);
            }

            IIterator iter = aggre.CreateIterator();

            while (iter.HasItem())
            {
                if(iter.CurrentItem().City == city)
                { 
                foreach(Reservation res in iter.CurrentItem().Reservelist)
                {
                    if(!(start < res.Enddate && res.Startdate < end))
                        {
                        Oda found = iter.CurrentItem().Odalist.Find(x => x.Room_no == res.Roomnum);
                        if(found.Bed_num == bednum || found.Size == size || found.Seaside == sea || found.Minibar == bar || found.Ac == ac)
                            {
                                tmplist.Add(iter.CurrentItem().Otelname + "-" + found.Room_no.ToString());
                            }
                        }
                }
                foreach(Oda rum in iter.CurrentItem().Odalist)
                    {
                        if (rum.Bed_num == bednum || rum.Size == size || rum.Seaside == sea || rum.Minibar == bar || rum.Ac == ac)
                        {
                            if(iter.CurrentItem().Reservelist.Count > 0)
                            {
                                foreach (Reservation res in iter.CurrentItem().Reservelist)
                                {
                                    if (res.Roomnum != rum.Room_no)
                                    {
                                            tmplist.Add(iter.CurrentItem().Otelname + "-" + rum.Room_no.ToString());
                                    }
                                }
                            }
                            tmplist.Add(iter.CurrentItem().Otelname + "-" + rum.Room_no.ToString());
                        }


                        
                    }
                }

                iter.NextItem();
            }



            return tmplist;
        }

        void ReserveDel(otel otel,string reservid)
        {

        }

    }
}
