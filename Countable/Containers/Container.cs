using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericsCovarianceAndContravariance.Countable.Containers
{
    class Container : ICountable
    {
        protected List<ICountable> _contents = new List<ICountable>();
        public List<ICountable> Contents { get { return _contents; }}
        protected int _count;
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public Container(IEnumerable<ICountable> things)
        {
            if (things != null)
            {
                this._contents = things.ToList();
                _count = _contents.Sum(thing => thing.Count);
            }
        }
        public void Add(int amount, Enum type, Things.Thing.Colours colour = Things.Thing.Colours.Unknown)
        {
            ContainerFiller containerFiller = new ContainerFiller();
            for(int i = 0; i < amount; i++)
            {                
                this._contents.Add(containerFiller.GetInstanceOfThing(type, colour));
            }
            _count = _contents.Sum(thing => thing.Count);
        }
    }
}
