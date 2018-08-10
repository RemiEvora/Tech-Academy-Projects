using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg116
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassMethod Class instantiation 
            ClassMethods Calculator = new ClassMethods();


            //Request user input of number//
            Console.WriteLine("Give me a number to work on: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Calculator.DivisionOp(userNumber); //When Line 21 is re-typed, overloaded method options appear 


            //==========================================//
            string fName;
            string lName;

            Console.WriteLine("What's your name?");
            fName = Console.ReadLine();

            Console.WriteLine("Great. What's your family/last name?");
            lName = Console.ReadLine();

            Calculator.NameWriter(out string newF, out string newL);

            Console.WriteLine("No, not anymore.");
            Console.WriteLine("From here on out, your new name will be " + newF + " " + newL + ".");
            Console.ReadLine();

            //==========================================//

            Console.WriteLine("I want to see how old you are if you were a dog.");
            Console.WriteLine("How old are you?");

            double userAge = Convert.ToDouble(Console.ReadLine());

            userAge = StaticMethod.DogYearConverter(userAge);
            Console.WriteLine("So that makes you approximately" + userAge + "in dog years.");
            Console.ReadLine();
        }
    }
}
