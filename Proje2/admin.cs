using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class admin : Kullanici
    {
        void CreateOtel(otel otel)
        {
            SystemControl.Otellist.Add(otel);
        }

        void DelUser()
        {

        }

        void AddRoom(otel otelname)
        {
            //otelname.Odalist.Add(new Oda());
        }

        void ShowReport()
        {

        }

    }
}
