namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        public FastInvader(Path path) : base(path)
        {}
        protected override int StepSize { get; } = 2;
    }
}