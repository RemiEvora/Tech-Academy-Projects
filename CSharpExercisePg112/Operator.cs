using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg112
{



    public class Operator
    {
      public Operator()
        {
            
        }

        //Create a class. In that class, create a void method that takes two integers as parameters. 
        //Have the method do a math operation on the first integer and display the second integer to the screen.
        public void Subtraction(int num01, int num02)
        {
            
            int result = num01 - 5;
            //return (num02); -> Testing method for functionality with public int subtraction + return command. 
            Console.WriteLine(num02);
        }
    }
}
