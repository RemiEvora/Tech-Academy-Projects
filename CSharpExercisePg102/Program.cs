using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {




        //===========================Exercise 1===========================//
        //Create a one-dimensional Array of strings.Ask the user to input some text.
        //Create a loop that goes through each string in the Array, adding the user’s 
        //text to the string.Then create a loop that prints off each string in the Array on a separate line.
        //================================================================//
        //string[] storyArray = {"I got up at ", "I arrived at work in the morning. I work at ", "For lunch, I went to ",
        //        "For dinner, I was feeling lazy, so I microwaved some ", "I went to sleep at " };
        //string[] storyAnswer = new string[5];
        //int answerPosition; 

        //Console.WriteLine("Tell me about your day. What time did you wake up today?");
        //storyAnswer[0] = Console.ReadLine();

        //Console.WriteLine("Where do you work?");
        //storyAnswer[1] = Console.ReadLine();

        //Console.WriteLine("What's your favorite fast food restaurant?");
        //storyAnswer[2] = Console.ReadLine();

        //Console.WriteLine("What's your favorite food?");
        //storyAnswer[3] = Console.ReadLine();

        //Console.WriteLine("What time do you usually go to bed?");
        //storyAnswer[4] = Console.ReadLine();

        //Console.WriteLine("\nSo, this is basically a typical day for you, right? If I were you, I'd say...\n");

        //for (answerPosition = 0; answerPosition <storyArray.Length; answerPosition++)
        //{

        //    Console.WriteLine(storyArray[answerPosition] + storyAnswer[answerPosition] + ".\n");
        //}
        //Console.WriteLine("Did I get that about right?");
        //Console.ReadLine();



        //===========================Exercise 2===========================//
        //Create an infinite loop.
        //================================================================//

        //====Infinite Loop====//
        //Console.WriteLine("Press any key to continue.");
        //while (true)
        //{
        //    Console.WriteLine("You triggered my trap card!!");
        //    //Adding 'break' here will only cause the code to execute once then close console screen. (Possible Infinite Loop fix solution) 

        //}
        //Console.ReadLine();


        //===========================Exercise 3,4=========================//
        //Fix the infinite loop so it will execute.
        //Create a loop where the comparison used to determine whether to continue 
        //iterating the loop is a “<” operator.
        //================================================================//
        //Fixed using a realistic, achievable condition via positive number and incrementing counter. 
        //int counter = 0;


        //Console.WriteLine("Press any key to continue.");
        //Console.ReadLine(); 
        //do
        //{
        //    Console.WriteLine("You triggered my trap card!!");
        //    counter++;

        //}
        //while (counter < 15);

        //Console.WriteLine("You escaped? Good for you.");
        //Console.ReadLine();



        //===========================Exercise 5===========================//
        //Create a loop where the comparison used to determine whether to continue 
        //iterating the loop is a “<=” operator.
        //================================================================//
        //int counter = 25;


        //Console.WriteLine("Press any key to continue.");
        //Console.ReadLine(); 
        //do
        //{
        //    Console.WriteLine("Looping with a <= operator.");
        //    counter--;

        //}
        //while (0 <= counter);

        //Console.WriteLine("Done.");
        //Console.ReadLine();

        //=======================Exercise 6,7,8===========================// 
        //Create a List of strings where each item in the list is unique. Ask the user 
        //to select text to search for in the List. Create a loop that iterates through the 
        //loop and then displays the index of the array that contains matching text on the screen.
        //Add code to that above loop that tells a user if they put in text that isn’t in the List.
        //Add code to that above loop that stops it from executing once a match has been found.
        //================================================================//
        //List<string> zooArray = new List<string>() { "Gorilla", "Lion", "Zebra", "Tiger", "Rhino", "Giraffe", "Hippo", "Snake" };


        //Console.WriteLine("Please select one of the following: Giraffe, Gorilla, Hippo, Lion, \nRhino, Snake, Tiger, Zebra");

        //bool matchFlag = false;
        //string searchWord = Console.ReadLine();
        //while (matchFlag == false)
        //{

        //    for (int counter = 0; counter < zooArray.Count; counter++)
        //    {
        //        if (zooArray[counter] == searchWord)
        //        {
        //            matchFlag = true;
        //            Console.WriteLine("The " + searchWord + " is located at index " + counter + ".");
        //            searchWord = Console.ReadLine();
        //        }
        //    }

        //    Console.WriteLine("Incorrect input. Please choose from one of the following: \nGiraffe, Gorilla, Hippo, Lion, Rhino, Snake, Tiger, Zebra");
        //    searchWord = Console.ReadLine();
        //}


        //===========================Exercise 9, 10=======================//
        //Create a List of strings that has at least two identical strings in the List. Ask the user 
        //to select text to search for in the List. Create a loop that iterates through the loop and then 
        //displays the indices of the array that contain matching text on the screen.
        //Add code to that above loop that tells a user if they put in text that isn’t in the List.
        //================================================================//

        //List<string> numberList = new List<string>()
        //    {"one", "two", "three", "ten", "three", "four", "five", "six", "seven",
        //    "six", "eight", "six", "two", "five", "ten" };

        //Console.WriteLine("Please write out a number from \"one\" to \"ten\" and i'll show you " +
        //    "\nif there are copies or not.");
        //var searchword = Console.ReadLine();

        //int count = 0;
        //bool found = false;
        //foreach (string numWord in numberList)
        //{
        //    count++;

        //    if (numWord == searchword)
        //    {
        //        found = true;
        //        Console.WriteLine("The number chosen is located on the list at position: " + count.ToString());
        //    }
        //}
        //if (found == false) Console.WriteLine("The number chosen is not contained in the number list.");
        //Console.ReadLine();





        //===========================Exercise 11==========================//
        //Create a List of strings that has at least two identical strings in the List.
        //Create a foreach loop that evaluates each item in the list, and displays a message showing the 
        //string and whether or not it has already appeared in the list.
        //================================================================//


        List<string> numberList = new List<string>()
            {"one", "two", "three", "ten", "three", "four", "five", "six", "seven",
            "six", "eight", "six", "two", "nine", "ten" };

        var seenList = new List<string>();

        //  select each element of 'numberList' as 'numWord'
        foreach (string numWord in numberList)
        {
            if (seenList.Contains(numWord))
            {
                seenList.Add(numWord + " (REPEAT)");
            }
            else seenList.Add(numWord.ToString());
        }

        //  print each 'word' in 'counterList'
        foreach (var word in seenList)
        {
            Console.WriteLine(word);
        }

        
        Console.ReadLine();


    }
}
