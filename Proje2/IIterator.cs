using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    interface IIterator
    {        
        bool HasItem();  
        //otel NextItem();       
        otel CurrentItem();
    }
}
