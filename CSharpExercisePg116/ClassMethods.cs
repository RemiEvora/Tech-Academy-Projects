using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg116
{
    
    //Create a class. 
    public class ClassMethods
    {
        //In that class, create a void method that outputs an integer. Have the method  
        //divide the data passed to it by 2. 
        public void DivisionOp(int userNumber)
        {
            int result = userNumber / 2;
            Console.WriteLine("So, your number " + userNumber + " divided by 2 equals " + result + ".");
            Console.ReadLine(); 
        }

         
        //Overload a method
        public void DivisionOp(double userNumber2)
        {
            double quotient = userNumber2 / 0.75;
            Console.WriteLine("Your number " + userNumber2 + " divided by 0.75 equals" + quotient + ".");
            Console.ReadLine();
        }


        //Create a method with output parameters. 
        public void NameWriter(out string newF, out string newL)
        {
            newF = "Lance";
            newL = "Uppercut";

        }

    }
    

}
