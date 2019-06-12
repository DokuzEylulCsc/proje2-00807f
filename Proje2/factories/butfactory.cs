using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class butfactory : otelfactory
    {
        public override otel GetOtel(String sehir, string isim , int yildiz)
        {
            sehir = sehir.ToLower();
            ButikOtel tmpotel = new ButikOtel(sehir,isim, yildiz);//her butik otelde minimum klimali 2 medium oda olmali
            tmpotel.Odalist.Add(new Oda(101, 2, "Orta", false, false,20 ,true));
            tmpotel.Odalist.Add(new Oda(102, 2, "Orta", false, false, 20, true));

            return tmpotel;
        }
    }
}
