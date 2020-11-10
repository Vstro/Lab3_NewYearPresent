using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Nougat : Sweet
    {
        public override double SugarPercent { get; } = 0.75;
        public Nougat(int weight) : base(weight) { }
        public Nougat(SweetSize weight) : base((int)weight) { }
    }
}
