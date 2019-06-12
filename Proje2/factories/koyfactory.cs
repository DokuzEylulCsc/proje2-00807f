using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class koyfactory : otelfactory
    {
        public override otel GetOtel(String sehir, string isim, int star)
        {
            sehir = sehir.ToLower();
            TatilKoyu tmpotel = new TatilKoyu(sehir, isim, star);//her TatilKoyunde minimum 2 deniz kenari medium oda olmali
            tmpotel.Odalist.Add(new Oda(101, 2, "Orta", true, false, false));
            tmpotel.Odalist.Add(new Oda(102, 2, "Orta", true, false, false));

            return tmpotel;
        }


    }
}
