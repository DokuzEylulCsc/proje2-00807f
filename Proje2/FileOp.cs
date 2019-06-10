using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Proje2
{
    class FileOp
    {


        public void filewrite()
        {
            XmlSerializer x = new XmlSerializer(SystemControl.Otellist.GetType());
            x.Serialize(Console.Out, SystemControl.Otellist);
        }

        void fileread()
        {

        }

    }
}
