
namespace TreehouseDefense
{
    class SniperTower : Tower
    {
    public SniperTower(MapLocation location, Map map) : base(location, map)
    {}    
        //more range
        protected override int Range {get; } = 3;
    }
}