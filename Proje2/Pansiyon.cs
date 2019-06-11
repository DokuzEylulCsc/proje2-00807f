using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Pansiyon : otel
    {        
        public Pansiyon(String city, string name, int star)
        {
            this.Type = "Pansiyon";
            this.Otelname = name;
            this.City = city;
            this.Star = star;
        }
    }
}
