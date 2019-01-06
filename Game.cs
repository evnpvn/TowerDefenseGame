using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main(string[] args)
        {  
            //Game introduction
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to Treehouse Defense!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please review the Readme file for how to Play");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("You should have read the Readme because now it's going to be confusing");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Everything is going to happen all at once after you select a level");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("");
            Console.WriteLine("Ok fine");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Gray; 
            Console.WriteLine("Level 1:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("  _   _   _   _   _   _   _   _");
            Console.WriteLine("| _ | _ | _ | _ | _ | _ | _ | _ |");
            Console.WriteLine("| _ | _ | _ | _ | _ | _ | _ | _ |");
            Console.WriteLine("| _ | _ | _ | _ | _ | _ | _ | _ |");
            Console.WriteLine("| P | A | T | H | X | X | X | X |");
            Console.WriteLine("| _ | _ | _ | _ | _ | _ | _ | _ |");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enemy Invaders:");
            Console.WriteLine("    2 x Basic Invader");
            Console.WriteLine("    1 x Sheilded Invader");
            Console.WriteLine("    1 x Fast Invader");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Your Towers:");
            Console.WriteLine("    3 x Basic Tower");
            Console.WriteLine("    1 x Power Tower");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Level 2:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("  _   _   _   _   _   _   _   _");
            Console.WriteLine("| _ | _ | _ | _ | _ | _ | _ | _ |");
            Console.WriteLine("| P | A | T | H | _ | _ | _ | _ |");
            Console.WriteLine("| _ | _ | _ | X | _ | X | X | X |");
            Console.WriteLine("| _ | _ | _ | X | X | X | _ | _ |");
            Console.WriteLine("| _ | _ | _ | _ | _ | _ | _ | _ |");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enemy Invaders:");
            Console.WriteLine("    2 x Basic Invader");
            Console.WriteLine("    2 x Sheilded Invader");
            Console.WriteLine("    1 x Fast Invader");
            Console.WriteLine("    1 x Strong Invader");
            Console.WriteLine("    2 x Resurrecting Invader");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Your Towers:");
            Console.WriteLine("    2 x Basic Tower");
            Console.WriteLine("    2 x Power Tower");
            Console.WriteLine("    2 x Sniper Tower");
            Console.WriteLine("");
            
            Console.ForegroundColor = ConsoleColor.Gray;
            
            for(int i = 0; i < 5; i++)
            {
                try
                {    
                    if(i == 4)
                    {
                        throw new InvalidEntry();
                    }
            
                    Console.WriteLine("Select a Level by entering \'1\' or \'2\'");
                    string userEntry = Console.ReadLine();

                    try
                    {
                        int userLevel = Int32.Parse(userEntry);

                        if(userLevel > 2 || userLevel < 1)
                        {
                            throw new InvalidEntry();
                        } 

                        if (userLevel == 1)
                        {
                            //create new lvl1 object and start that level up
                            LevelOne lvl1 = new LevelOne();
                        }
                        

                        else if(userLevel == 2)
                        {
                            LevelTwo lvl1 = new LevelTwo();
                        }
                        break;
                    }

                    catch(InvalidEntry)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        System.Console.WriteLine("Not a valid level");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                        continue;
                    }

                    catch(System.FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("That's not even a number");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                        continue;
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
                catch(InvalidEntry)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("None of those were valid entries you dummy...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    
                }
            }    
        }

    }  
}