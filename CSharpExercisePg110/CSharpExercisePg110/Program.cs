using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg110
{
    class Program
    {
        static void Main(string[] args)
        {
            InputModifier Calculator = new InputModifier();
            double result1;
            double result2;
            double result3;
            

            Console.WriteLine("Give me two numbers of your choice, and I'll run some calculations on them.");
            
            //Request user for first number 
            Console.WriteLine("What do you want to use for your first number?"); 
            double numInput1 = Convert.ToDouble(Console.ReadLine());

            //Request user for second number 
            Console.WriteLine("Ok. What about your second number?");
            double numInput2 = Convert.ToDouble(Console.ReadLine());

            //First Input Modification 
            result1 = Calculator.Addition(numInput1, numInput2);
            Console.WriteLine("Ok. So, adding " + numInput1 + " and " + numInput2 + " equals " + result1 + ".");
            Console.ReadLine();

            //Second Input Modification
            result2 = Calculator.Multiplication(numInput1, numInput2);
            Console.WriteLine("Then, multiplying " + numInput1 + " and " + numInput2 + " will give you " + result2 + ".");
            Console.ReadLine();

            //Third Input Modificication 
            result3 = Calculator.Division(numInput1, numInput2);
            Console.WriteLine("Finally, if you divide " + numInput1 + " by " + numInput2 + " you get " + result3 + ".");
            Console.ReadLine(); 
            
        }
    }
}
