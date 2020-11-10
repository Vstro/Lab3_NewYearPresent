using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class WhiteChocolate : Sweet
    {
        public override double SugarPercent { get; } = 0.6;
        public WhiteChocolate(int weight) : base(weight) { }
        public WhiteChocolate(SweetSize weight) : base((int)weight) { }
    }
}
