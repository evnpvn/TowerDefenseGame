namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();
        public ShieldedInvader(Path path) : base(path)
        {
        }
        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < 0.5)
            {
                base.DecreaseHealth(factor); 
                
            }
            else
            {
                System.Console.WriteLine("Shot at a Sheilded invader! Invader didn't flinch");
            }

        }
    } 
}