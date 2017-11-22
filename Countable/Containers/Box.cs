using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable.Containers
{
    class Box: Container<Things.Thing>, ICountable
    {
        public Box(IEnumerable<Things.Thing> things = null) : base(things)
        {
        }
    }
}
