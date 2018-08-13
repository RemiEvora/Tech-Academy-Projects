using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg125
{
    //Have employee class inherit interface and implement the Quit() method. 
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee Name: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Warning or guidance message here.");
            Console.ReadLine();
        }
    }
}
