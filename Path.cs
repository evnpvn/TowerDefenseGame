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

        //method to validate if the MapLocation is on the Path
        public bool IsOnPath(MapLocation location)
        {
            foreach(var pathLocation in _path)
            {
                if (pathLocation.Equals(location))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
