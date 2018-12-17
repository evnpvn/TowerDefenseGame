namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        public int Length => _path.Length;
        public Path(MapLocation[] path)
        {
            _path = path;
        }
        public MapLocation GetLocationAt(int pathstep)
        {
            return (pathstep < _path.Length) ? _path[pathstep] : null;
        }
    }
}
