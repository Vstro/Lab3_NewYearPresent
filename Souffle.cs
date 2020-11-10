using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Souffle : Sweet
    {
        public override double SugarPercent { get; } = 0.03;
        public Souffle(int weight) : base(weight) { }
        public Souffle(SweetSize weight) : base((int)weight) { }
    }
}
