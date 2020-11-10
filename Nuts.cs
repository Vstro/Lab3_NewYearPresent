using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Nuts : Sweet
    {
        public override double SugarPercent { get; } = 0.05;
        public Nuts(int weight) : base(weight) { }
        public Nuts(SweetSize weight) : base((int)weight) { }
    }
}
