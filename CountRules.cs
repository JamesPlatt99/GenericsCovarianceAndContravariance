using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsCovarianceAndContravariance.Countable;
using GenericsCovarianceAndContravariance.Countable.Things;

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
            count = things.Where(thing=>thing.GetType() ==  typeof(Apple)
                               && ((Apple)thing).Colour == Thing.Colours.Red)
                               .Sum(thing => thing.Count);
            count += things.Where(thing=> !(thing.GetType().IsSubclassOf(typeof(Thing))))
                .Sum(thing => new Counter<ICountable>(((Countable.Containers.Container)thing).Contents, CountRedApples).Count);
            return count;
        }
    }
}
