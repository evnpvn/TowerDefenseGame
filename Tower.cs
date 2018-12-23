using System;
namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range {get; } = 1;
        protected virtual int Power {get; } = 1;
        protected virtual double Accuracy {get; } = 0.75;

        private readonly MapLocation _location;
        private static readonly Random _random = new Random();

        public Tower(MapLocation location, Map map)
        {
            _location = location;
            
            /*validation for whether the tower is on the Map.
            Uses the OnMap method which valides a point
            The location variable is a MapLocation which is a sub-class 
            of the point class which makes this work*/
            if (!map.OnMap(this._location))
            {
                throw new OutOfBoundsException("Tower is outside of the map.");
            }

        }
        public bool IsSucessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                //Check if the tower's distance for each invader is less than the shooting range
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSucessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Killed an invader!");
                        }
                    }
                    break;
                }
            }
        }
    }
}

