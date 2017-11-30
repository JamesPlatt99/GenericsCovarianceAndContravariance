using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable.Things
{
    public class Apple : Thing
    {
        public Apple(Colours colour = Colours.Unknown) : base(colour)
        {
        }
    }
}
