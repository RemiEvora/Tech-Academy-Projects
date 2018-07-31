using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndNetFrameworkCourseExPg99
{
    class Program
    {
        static void Main()
        {
            //===========================================//
            //===========Exercise Instructions===========//
            //===========================================//
            //1.Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.

            //2.Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.

            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.


              

            ////=========1. String Array Exercise=========// 
            string[] stringArray = { "I can't see that happening", "Concentrate and ask again.",   "Most Likely", "Signs point to yes",
                "Better not tell you now.", "Can't predict now.", "Yes",  "No", "Very doubtful.", "It doesn't look like it.",
                "It's hazy. Try Again", "Without a doubt" };

            Console.WriteLine("I'm your computer's magic 8-ball. Think of a question in your head,\nthen choose a number from 0 to 11, then I'll give you my impressions.");
            int choice = int.Parse(Console.ReadLine());
            bool choiceRange = choice > 0 && choice < 11;

            do
            {


                if (choice < 0 || choice > 12)
                {
                    Console.WriteLine("I said choose a number between 0 and 11. Try again."); // 3. Index does not exist exercise requirement. 
                    choice = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine(stringArray.GetValue(choice));
                    Console.ReadLine();
                    break;
                }
            }
            while (!choiceRange);

            Console.ReadLine();

            ////=========2. Int Array Exercise=========// 
            int[] intArray = { 1000, 2, 20, 5, 10, 500, 50, 5, 525, 10, 2, 5, 1000000, 600, 8, 800 };

            Console.WriteLine("This is your virtual \"Million-Dollar Scratch Card\" ticket. \nPick a number from 0 to 15 to see how much you've won!");
            int scratchchoice = int.Parse(Console.ReadLine());
            bool scratchRange = scratchchoice > 0 && scratchchoice < 15;

            do
            {


                if (scratchchoice < 0 || scratchchoice > 15)
                {
                    Console.WriteLine("I said choose a number between 0 and 15. Try again."); // 3. Index does not exist exercise requirement. 
                    scratchchoice = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("And... it looks like you've won " + intArray.GetValue(scratchchoice) + " dollars!");
                    Console.ReadLine();
                    break;
                }
            }

            while (!scratchRange);
            Console.ReadLine();



            //=========4. String List Exercise=========// 
            List<string> songList = new List<string>();
            songList.Add("\"We Will Rock You\"");
            songList.Add("\"Somebody to Love\"");
            songList.Add("\"Show Must Go On\"");
            songList.Add("\"Under Pressure\"");
            songList.Add("\"I Want It All\"");
            songList.Add("\"Love of My Life\"");
            songList.Add("\"Killer Queen\"");
            songList.Add("\"Another One Bites the Dust\"");
            songList.Add("\"We Are the Champions\"");
            songList.Add("\"Princes of the Universe\"");
            songList.Add("\"Show Must Go On\"");

            Console.WriteLine("What Queen song fits your day today? Pick a number from 0 to 10 and find out!");
            int songChoice = int.Parse(Console.ReadLine());
            bool queenApproved = songChoice > 0 && songChoice < 10;

            do
            {


                if (songChoice < 0 || songChoice > 10)
                {
                    Console.WriteLine("Are you daft? I said pick a number between 0 and 10!"); // 3. Index does not exist exercise requirement.
                    songChoice = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Looks like the song that fits your day is... " + songList[songChoice] + "...\nQueue the operatic instrumental!!");
                    Console.ReadLine();
                    break;
                }


            }
            while (!queenApproved);
            Console.ReadLine();






        }
    }
}
