using System;

namespace TreehouseDefense
{
    class LevelOne
    {
        public LevelOne()
        {
            Map map = new Map(8,5);
            try
            {
                Path path = new Path(
                        new [] 
                        {
                        new MapLocation(0, 1, map),
                        new MapLocation(1, 1, map),
                        new MapLocation(2, 1, map),
                        new MapLocation(3, 1, map),
                        new MapLocation(4, 1, map),
                        new MapLocation(5, 1, map),
                        new MapLocation(6, 1, map),
                        new MapLocation(7, 1, map),
                        }
                    );
            
                IInvader[] invaders =
                {
                    new BasicInvader(path),
                    new BasicInvader(path),
                    new ShieldedInvader(path),
                    new FastInvader(path)
                };

                Tower[] towers =
                {
                    new Tower (new MapLocation((PlayersTowers1.tower1X - 1), (PlayersTowers1.tower1Y - 1), map), map),
                    new Tower (new MapLocation((PlayersTowers1.tower2X - 1), (PlayersTowers1.tower2Y - 1), map), map),
                    new Tower (new MapLocation((PlayersTowers1.tower3X - 1), (PlayersTowers1.tower3Y - 1), map), map),
                    new PowerTower (new MapLocation((PlayersTowers1.tower4X - 1), (PlayersTowers1.tower4Y - 1), map), map)
                };

                Level level = new Level(invaders)
                {
                    towers = towers
                };

                bool playwerWon = level.Play();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You " + (playwerWon ? "Won!" : "lost..."));
                Console.ForegroundColor = ConsoleColor.Gray;
                

            }
            catch(OutOfBoundsException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch(TreehouesDefenseException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Unhandled TreehouseDefenseException");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Unhandled Exception: " + ex);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}