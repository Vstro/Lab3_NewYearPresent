using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    abstract class Sweet
    {
        public int Weight { get; private set; }
        public abstract double SugarPercent { get; }
        public Sweet(int weight)
        {
            Weight = weight;
        }
        public Sweet(SweetSize weight) : this((int)weight) { }
    }
}
