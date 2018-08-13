using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg125
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Example = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            Example.SayName();

            //Use Polymorphism to create object of type IQuittable and use the Quit() method on it. 
            IQuittable QuittingPerson = new Employee();
            QuittingPerson.Quit();

        }
    }
}
