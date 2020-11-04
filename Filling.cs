using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    abstract class Filling
    {
        public double Weight { get; private set; }

        public Filling(double weight)
        {
            Weight = weight;
        }
    }
}
