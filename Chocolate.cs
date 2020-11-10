namespace NewYearPresent
{
    class Chocolate : Sweet
    {
        public override double SugarPercent { get; } = 0.5;
        public override string Name { get; } = "chocolate";

        public Chocolate() { }

        public Chocolate(int weight) : base(weight) {}

        public Chocolate(SweetSize weight) : base((int)weight) { }
    }
}
