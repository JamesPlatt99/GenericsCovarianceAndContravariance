using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCovarianceAndContravariance.Countable.Things
{
    class Thing : ICountable
    {
        public Thing()
        {
            _count = 1;
        }
        private readonly int _count;
        public int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
