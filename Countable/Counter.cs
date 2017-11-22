using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable
{
    class Counter<TThing> : ICountable where TThing : ICountable
    {
        private int _count;
        private List<TThing> things;
        public int Count { get { return _count;  } }
        public Counter(IEnumerable<TThing> things)
        {
            this.things = things.ToList();
            _count = things.Sum(n=>n.Count);
        }
        public void Add(TThing item)
        {
            this.things.Add(item);
            _count = things.Sum(thing => thing.Count);
        }
    }
}
