using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class NutFilling : Filling
    {
        public const double SugarPercent = 0.05;
        public NutFilling(double weight) : base(weight) { }
    }
}
