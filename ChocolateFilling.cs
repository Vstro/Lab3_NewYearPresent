using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class ChocolateFilling : Filling
    {
        public const double SugarPercent = 0.5;
        public ChocolateFilling(double weight) : base(weight) {}
    }
}
