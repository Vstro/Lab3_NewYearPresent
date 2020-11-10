using System;

namespace NewYearPresent
{
    abstract class Sweet
    {
        public int Weight { get; private set; }
        public abstract double SugarPercent { get; }
        public abstract String Name { get; }

        public Sweet(int weight)
        {
            Weight = weight;
        }

        public Sweet(SweetSize weight = SweetSize.Average) : this((int)weight) { }
    }
}
