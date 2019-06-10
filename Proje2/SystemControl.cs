using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class SystemControl
    {
        List<Kullanici> userlist;
        List<otel> otellist;

        internal List<Kullanici> Userlist { get => userlist; set => userlist = value; }
        internal List<otel> Otellist { get => otellist; set => otellist = value; }

    }
}
