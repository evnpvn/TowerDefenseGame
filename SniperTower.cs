
namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        //more power
        protected override int Power {get; } = 2;

        public SniperTower(MapLocation location, Map map) : base(location, map)
        { }    

    }
}