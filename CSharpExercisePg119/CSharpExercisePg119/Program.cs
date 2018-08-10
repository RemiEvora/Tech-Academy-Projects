using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg119
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
        }
    }
}
