using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsCovarianceAndContravariance.Countable;

namespace GenericsCovarianceAndContravariance
{
    class CountRules
    {
        public int CountAll(IEnumerable<ICountable> things)
        {
            return things.Sum(thing => thing.Count);
        }
        public int CountRedApples(IEnumerable<ICountable> things)
        {
            int count = 0;
            count = things.Where(thing=>thing.GetType() ==  typeof(Countable.Things.Apple)
                               && ((Countable.Things.Apple)thing).Colour == Countable.Things.Thing.Colours.Red).Sum(thing => thing.Count);
            count += things.Where(thing => thing.GetType() == typeof(Countable.Containers.Box))
                .Sum(thing=>new Counter<ICountable>(((Countable.Containers.Box)thing).Contents,CountRedApples).Count);
            count += things.Where(thing => thing.GetType() == typeof(Countable.Containers.Cart))
                .Sum(thing => new Counter<ICountable>(((Countable.Containers.Cart)thing).Contents, CountRedApples).Count);
            return count;
        }
    }
}
