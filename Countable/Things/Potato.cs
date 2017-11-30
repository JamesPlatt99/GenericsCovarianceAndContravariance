using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable.Things
{
    class Potato : Thing
    {
        public Potato(Colours colour = Colours.Unknown) : base(colour)
        {
        }
    }
}
