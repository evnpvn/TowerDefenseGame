using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8,5);
            try
            {
                Path path = new Path(
                        new [] 
                        {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map),
                        }
                    );
                Invader[] invaders =
                {
                    new ShieldedInvader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)

                };
                Tower[] towers =
                {
                    new Tower (new MapLocation(1, 3, map), map),
                    new Tower (new MapLocation(3, 3, map), map),
                    new Tower (new MapLocation(5, 3, map), map)
                };

                Level level = new Level(invaders)
                {
                    towers = towers
                };

                bool playwerWon = level.Play();
                Console.WriteLine("Player " + (playwerWon ? "won" : "lost"));


            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouesDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }

    }  
}