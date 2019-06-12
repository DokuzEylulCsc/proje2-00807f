using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class OtelAggregate : IAggregate
    {
        List<otel> Otellist = new List<otel>();
        public void Add(otel Model) => Otellist.Add(Model);
        public otel GetItem(int index) => Otellist[index];
        public int Count { get => Otellist.Count; }
        public IIterator CreateIterator() => new OtelIterator(this);

    }
}
