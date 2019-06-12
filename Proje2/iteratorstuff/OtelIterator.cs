using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class OtelIterator : IIterator
    {//https://www.gencayyildiz.com/blog/c-iterator-design-patterniterator-tasarim-deseni/
        OtelAggregate aggregate;
        int currentindex;
        public OtelIterator(OtelAggregate aggregate) => this.aggregate = aggregate;
        public otel CurrentItem() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public otel NextItem()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);
            return null ;
        }
    }
}
