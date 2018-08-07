using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg112
{
    class Program
    {
        
        static void Main()
        {
            //Instantiate class. 
            Operator Calculator = new Operator();


            //Call the method in the class, passing in two numbers.
            int answer = Calculator.Subtraction(5, 2);  


            //Call the method in the class, specifying the parameters by name. 
            int answer2 = Calculator.Subtraction(num01: 20, num02: 15);

            Console.WriteLine(answer);
            Console.WriteLine(answer2);
            Console.ReadLine(); 
        }

    }
}
