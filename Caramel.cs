using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Caramel : Sweet
    {
        public override double SugarPercent { get; } = 0.8;
        public Caramel(int weight) : base(weight) { }
        public Caramel(SweetSize weight) : base((int)weight) { }
    }
}
