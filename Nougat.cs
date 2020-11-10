namespace NewYearPresent
{
    class Nougat : Sweet
    {
        public override double SugarPercent { get; } = 0.75;
        public override string Name { get; } = "nougat";

        public Nougat() { }

        public Nougat(int weight) : base(weight) { }

        public Nougat(SweetSize weight) : base((int)weight) { }
    }
}
