using System;

namespace TreehouseDefense
{
    class LevelTwo
    {
        public LevelTwo()
        {
            Map map = new Map(8,5);
            try
            {
                Path path = new Path(
                        new [] 
                        {
                        new MapLocation(0, 3, map),
                        new MapLocation(1, 3, map),
                        new MapLocation(2, 3, map),
                        new MapLocation(3, 3, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(3, 1, map),
                        new MapLocation(4, 1, map),
                        new MapLocation(5, 1, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                        }
                    );
            
                IInvader[] invaders =
                {
                    new BasicInvader(path),
                    new BasicInvader(path),
                    new ShieldedInvader(path),
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new ResurrectingInvader(path),
                    new ResurrectingInvader(path)                 
                };

                Tower[] towers =
                {
                    new Tower (new MapLocation((PlayersTowers2.tower1x - 1), (PlayersTowers2.tower1y - 1), map), map),
                    new Tower (new MapLocation((PlayersTowers2.tower2x - 1), (PlayersTowers2.tower2y - 1), map), map),
                    new PowerTower (new MapLocation((PlayersTowers2.tower3x - 1), (PlayersTowers2.tower2y - 1), map), map),
                    new PowerTower (new MapLocation((PlayersTowers2.tower4x - 1), (PlayersTowers2.tower3y - 1), map), map),
                    new SniperTower (new MapLocation((PlayersTowers2.tower5x - 1), (PlayersTowers2.tower4y - 1), map), map),
                    new SniperTower (new MapLocation((PlayersTowers2.tower6x - 1), (PlayersTowers2.tower5y - 1), map), map),
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