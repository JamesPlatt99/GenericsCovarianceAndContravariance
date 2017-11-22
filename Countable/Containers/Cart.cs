using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable.Containers
{
    class Cart : Container<Box>, ICountable
    {
        public Cart(IEnumerable<Box> things = null) : base(things)
        {
        }
    }
}
