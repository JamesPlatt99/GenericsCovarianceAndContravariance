using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable
{
    class Counter<TThing> : ICountable where TThing : ICountable
    {      
        public delegate int Rule(IEnumerable<TThing> things);
        public int Count { get { return _count;  } }

        private int _count;
        private List<TThing> things;

        public Counter(IEnumerable<TThing> things, Rule rule)
        {
            this.things = things.ToList();
            _count = GetCount(rule);
        }
        public void Add(TThing item)
        {
            this.things.Add(item);
        }

        private int GetCount(Rule rule)
        {
            return rule(things);
        }
    }
}
