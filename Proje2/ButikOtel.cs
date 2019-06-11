using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class ButikOtel : otel
    {
              

        public ButikOtel(String city, string name,int star)
        {
            this.Type = "ButikOtel";
            this.Otelname = name;
            this.City = city;
            this.Star = star;
        }
    }
}
