
namespace TreehouseDefense
{
    class PowerTower : Tower
    {
        public PowerTower(MapLocation location, Map map) : base(location, map)
        {}
        //more power
        protected override int Power {get; } = 2;
    }
}