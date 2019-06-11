using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class TatilKoyu : otel
    {       
        public TatilKoyu(String city, string name, int star)
        {
            this.Type = "TatilKoyu";
            this.Otelname = name;
            this.City = city;
            this.Star = star;
        }
    }
}
