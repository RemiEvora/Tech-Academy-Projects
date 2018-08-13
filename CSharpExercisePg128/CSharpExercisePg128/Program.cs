using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg128
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee Example = new Employee
            //{
            //    FirstName = "Sample",
            //    LastName = "Student"
            //};

            //Example.SayName();

             
            //IQuittable QuittingPerson = new Employee();
            //QuittingPerson.Quit();

            //=====Overload the '==' operator so it checks if two Employee objects are equal by comparing their ID property=====//
            Employee NewEmp1 = new Employee();
            NewEmp1.EmployeeID = 000000;

            Employee NewEmp2 = new Employee();
            NewEmp2.EmployeeID = 000001;

            Console.WriteLine(NewEmp1 == NewEmp2);
            Console.ReadLine(); 



        }
    }
}
