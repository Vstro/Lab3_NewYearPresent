namespace NewYearPresent
{
    class Caramel : Sweet
    {
        public override double SugarPercent { get; } = 0.8;
        public override string Name { get; } = "caramel";

        public Caramel() { }

        public Caramel(int weight) : base(weight) { }

        public Caramel(SweetSize weight) : base((int)weight) { }
    }
}
