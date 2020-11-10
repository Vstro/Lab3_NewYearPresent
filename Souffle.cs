namespace NewYearPresent
{
    class Souffle : Sweet
    {
        public override double SugarPercent { get; } = 0.03;
        public override string Name { get; } = "souffle";

        public Souffle() { }

        public Souffle(int weight) : base(weight) { }

        public Souffle(SweetSize weight) : base((int)weight) { }
    }
}
