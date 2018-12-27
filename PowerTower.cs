
namespace TreehouseDefense
{
    class PowerTower : Tower
    {
        //moar power
        protected override int Power {get; } = 2;
        public PowerTower(MapLocation location, Map map) : base(location, map)
        {}
    }
}