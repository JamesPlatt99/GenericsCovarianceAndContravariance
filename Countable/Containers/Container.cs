using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericsCovarianceAndContravariance.Countable.Containers
{
    class Container<TThing> : ICountable where TThing : Countable.ICountable
    {
        private List<ICountable> _contents;
        protected List<ICountable> Contents {
            get
            {
                if(_contents == null)
                {
                    _contents = new List<ICountable>();
                }
                return _contents;
            }
            set
            {
                _contents = value;
            }
        }
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
                this.Contents = things.ToList();
                _count = Contents.Sum(thing => thing.Count);
            }
        }
        public void Add(int amount, Enum type)
        {
            for(int i = 0; i < amount; i++)
            {                
                this.Contents.Add(GetInstanceOfThing(type));
            }
            _count = Contents.Sum(thing => thing.Count);
        }
        private ICountable GetInstanceOfThing(Enum type)
        {
            Things.Thing thing;
            switch(type){
                case Program.ThingTypes.Apple:
                    thing = new Things.Apple();
                    break;
                case Program.ThingTypes.Potato:
                    thing = new Things.Potato();
                    break;
                default:
                    thing = null;
                    break;
            }
            return thing;
        }
        public Container() { }
    }
}
