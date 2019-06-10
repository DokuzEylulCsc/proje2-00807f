using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class koyfactory : otelfactory
    {
        public override otel GetOtel()
        {
            return new TatilKoyu();
        }
    }
}
