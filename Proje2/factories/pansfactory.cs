using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class pansfactory : otelfactory
    {
        public override otel GetOtel()
        {
            return Pansiyon();
        }
    }
}
