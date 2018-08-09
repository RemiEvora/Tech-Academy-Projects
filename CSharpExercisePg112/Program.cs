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


//There are couple things wrong with this drill:
//1) The reason that you are getting this error is that a void method is not returning a value. That is what the 'void' classification means when creating this method.
//2) Your method has no datatype defined and is not returning a value to be assigned to the int variables in your Program.cs. 

//Try reworking your code and resubmitting based on the notes given above. If you need to discuss further, please let me know. I'd be more than happy to help.  - Cole