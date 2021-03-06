using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class pansfactory : otelfactory
    {
        public override otel GetOtel(String sehir, string isim, int star)
        {
            sehir = sehir.ToLower();
            Pansiyon tmpotel = new Pansiyon(sehir, isim, star);//her pansiyonda minimum 2 barli medium oda olmali
            tmpotel.Odalist.Add(new Oda(101, 2, "Orta", false, true, 20, false));
            tmpotel.Odalist.Add(new Oda(102, 2, "Orta", false, true, 20, false));

            return tmpotel;
        }
    }
}
