using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Chocolate : Sweet
    {
        public override double SugarPercent { get; } = 0.5;
        public Chocolate(int weight) : base(weight) {}
        public Chocolate(SweetSize weight) : base((int)weight) { }
    }
}
