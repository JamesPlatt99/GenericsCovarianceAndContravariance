using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable.Things
{
    public class Thing : ICountable
    {
        public Colours Colour { get { return _colour; } }
        protected Colours _colour;
        public int Count{ get { return _count; } }
        private readonly int _count;

        public Thing(Colours colour = Colours.Unknown)
        {
            this._colour = colour;
            this._count = 1;
        }

        public enum Colours
        {
            Unknown,
            Green,
            Red
        };

    }
}
