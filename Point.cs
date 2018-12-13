using System;
namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        //Point class constructor which takes 2 variables related to the fields
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /*DistanceTo method takes 2 integer variables x and y when called and returns 
        the integer value distance between them to the method that called it */
        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }
        /*DistanceTo method with different parameters. This one takes a Point object of
        the point class and returns with a call to the DistanceTo method that takes
        2 parameters x and y. The x and y values passed to the parameters are the Point
        object's X value and Y value */
        //What I don't get is that you pass it 1 point. The return will be '0'
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }

} 