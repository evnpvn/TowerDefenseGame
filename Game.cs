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
            
                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new StrongInvader(path),
                    new FastInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)

                };
                Tower[] towers =
                {
                    new Tower (new MapLocation(1, 3, map), map),
                    new SniperTower (new MapLocation(3, 4, map), map),
                    new PowerTower (new MapLocation(5, 3, map), map),
                    new PowerTower (new MapLocation(6, 3, map), map)
                };

                Level level = new Level(invaders)
                {
                    towers = towers
                };

                bool playwerWon = level.Play();
                Console.WriteLine("You " + (playwerWon ? "Won!" : "lost..."));


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