using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOnePt6
{
    class Program
    {
        static void Main(string[] args)
        {
            //=======READ IN A FILE TEXT=======//
            //string text = File.ReadAllText(@"C:\Users\Rembrandt.Evora\Desktop\2018 Tech Academy Bootcamp\C# & .NET Framework Course Documents\logtest.txt"); //Reading back previously created file. 


            //=======WRITE IN A FILE TEXT=======//
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Rembrandt.Evora\Desktop\2018 Tech Academy Bootcamp\C# & .NET Framework Course Documents\logtest.txt", text); //If 'logtest.txt' does not exist, it will create it or overwrite a current version of it. 
            //If you do not have the '@' symbol, the address will require double \\ symbols, -> C:\\Users\\ etc. 


            Console.WriteLine("Welcome to the Grand Hotel & Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true; 
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing."); 

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read(); 
        }
    }
}
