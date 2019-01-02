using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main(string[] args)
        {  
            //Game introduction
            /* Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to Treehouse Defense!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(3000);
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please review the Readme file for how to Play");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("You should have read the Readme because now it's going to be confusing");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Everything is going to happen all at once after you select a level");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Then you will be all like, \'Man what a terrible game\'");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("But is actually not terrible");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("It's you that is terrible and you should feel terrible");
            System.Threading.Thread.Sleep(5500);
            Console.WriteLine("");
            Console.WriteLine("Ok fine");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            */
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Select a Level by entering \'1\' or \'2\'");

            string userEntry = Console.ReadLine();

            int userLevel = Int32.Parse(userEntry);

            //need to parse readline to int
            //need to determine if I should create a new instance of the 'Level' object from the Console.ReadLine method
            //Then from that I could create a Level in the level file with it.
            //I think I'm overthinking this since it's just a variable and should have never been a class

            /*
            Creating some if statements here.
            These should stay here. The level files will contain the details for building that level.
            The level object itself will get created here depending on what level was entered.
            In reality as well what I should do is have a separate InvadersLevel1 file that the user can override the locations of but that's it.
            That would be a decent test of understanding extensibility.
            if (level == 1)
            {

            }
            else if()
            */



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
                    new ResurrectingInvader(path),
                    //new StrongInvader(path),
                    new FastInvader(path),
                    new BasicInvader(path)
                    
                };
                Tower[] towers =
                {
                    new Tower (new MapLocation(1, 3, map), map),
                    new SniperTower (new MapLocation(3, 4, map), map),
                    new PowerTower (new MapLocation(5, 3, map), map),
                    new PowerTower (new MapLocation(6, 3, map), map),
                    new Tower (new MapLocation(3, 1, map), map)
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
        
            //Console.ResetColor();

        }

    }  
}