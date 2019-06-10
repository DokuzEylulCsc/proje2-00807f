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

        static public List<otel> Otellist { get => otellist; set => otellist = value; }
        static public List<Kullanici> Userlist { get => userlist; set => userlist = value; }
        

    }
}
