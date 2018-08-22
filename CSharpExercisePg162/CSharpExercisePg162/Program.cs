using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg162
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a const variable
            const string schoolName = "Starfleet Academy";

            //2.Create a variable using the keyword "var".

            Console.WriteLine("Welcome to {0}, civilian. What's your name?", schoolName);
            var Name = Console.ReadLine();

            Console.WriteLine("\nWelcome, " + Name + ", to {0}. Here at {0}, we pride \nourselves on the best and brightest the universe has to offer.", schoolName);

            Console.WriteLine("To be as accomodating as we can, {0} likes to ask \nnew recruits what color they'd like their regulation shirt to be. \nDo you have a preference?", schoolName);
            string weDontCare = Console.ReadLine();

            Cadet cannonFodder = new Cadet(Name);
            Console.WriteLine("\n\nCongratulations on joining the greatest military force in the known galaxy! \nWe've got high hopes for you!");
            Console.WriteLine("From here on in, you'll be known as Cadet " + Name + "!");
            Console.WriteLine("\n\n...and looks like we're fresh out of " + weDontCare + " shirts. Sorry about that. \nBut we've got a nice " + cannonFodder.Shirt + " one, just for you! Congratulations!");
            Console.ReadLine();


        }
    }
}
