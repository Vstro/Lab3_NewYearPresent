namespace NewYearPresent
{
    class WhiteChocolate : Sweet
    {
        public override double SugarPercent { get; } = 0.6;
        public override string Name { get; } = "white chocolate";

        public WhiteChocolate() { }

        public WhiteChocolate(int weight) : base(weight) { }
        
        public WhiteChocolate(SweetSize weight) : base((int)weight) { }
    }
}
