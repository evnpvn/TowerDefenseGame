namespace TreehouseDefense
{
    interface IMovable
    {
        void Move();
    }

    interface IMappable
    {
        MapLocation Location { get; }
    }
    
    interface IInvader : IMappable, IMovable
    {
        int Health { get; }

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);
    }
}