using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg137
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.In the Main() method, create an object of data type Number and assign an amount to it.
            Number Num1 = new Number(); 
            Num1.Amount = 3500.50M;


            //3.Print this amount to the console.
            Console.WriteLine(Num1.Amount);
            Console.ReadLine(); 
        }
    }
}
