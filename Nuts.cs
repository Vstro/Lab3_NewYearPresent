namespace NewYearPresent
{
    class Nuts : Sweet
    {
        public override double SugarPercent { get; } = 0.05;
        public override string Name { get; } = "nuts";

        public Nuts() { }

        public Nuts(int weight) : base(weight) { }

        public Nuts(SweetSize weight) : base(weight) { }
    }
}
