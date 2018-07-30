using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndNetFrameworkCourseExPg96
{
    class Program
    {
        static void Main(string[] args)
        {
            //======Concatenate three strings======// 
            string threeStringsConcat = "Humpty Dumpty sat on a wall. \n" +
                                        "Humpty Dumpty had a great fall. \n" +
                                        "Guy shoulda been more careful.";

            Console.WriteLine(threeStringsConcat);
            Console.ReadLine();

            //======Convert string to uppercase======// 

            string allLowerCase = "i need this sentence in all caps so it looks like i'm yelling!";
            allLowerCase = allLowerCase.ToUpper();

            Console.WriteLine(allLowerCase);
            Console.ReadLine();

            //======Create a stringbuilder and build a paragraph of text, one sentence at a time.======// 

            StringBuilder storyWriter = new StringBuilder();

            storyWriter.Append("This is a practical exercise of the StringBuilder class. \n");

            storyWriter.Append("Using the Stringbuilder, I can add sentences to the same string\nto avoid memory allocation issues using simple strings. ");

            storyWriter.Append("Notice what\nI've done in all of sentences, using Escapes to format sentences \nso that they don't run off the screen. ");

            storyWriter.Append("Of course, this was done after\nI ran-then-edited the appended string values several times...\n"); 

            storyWriter.Append("You can adjust the length to however you want it to look, though.");
            Console.WriteLine(storyWriter);
            Console.ReadLine(); 

        }
    }
}
