using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg131
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

            //Employee NewEmp1 = new Employee();
            //NewEmp1.EmployeeID = 000000;

            //Employee NewEmp2 = new Employee();
            //NewEmp2.EmployeeID = 000001;

            //Console.WriteLine(NewEmp1 == NewEmp2);
            //Console.ReadLine();



            //3. Instantiate an Employee object with type "string" as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<string> NewEmp3 = new Employee<string>
            {
                Things = new List<string> { "a ", "b ", "c ", "d ", "e " }
            };

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
            Employee<int> NewEmp4 = new Employee<int>
            {
                Things = new List<int> { 1, 2, 3, 4, 5, 6 }
            };

            //5. Create a loop that prints all of the Things to the Console.
            foreach (string item in NewEmp3.Things)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadLine();

            foreach (int number in NewEmp4.Things)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            Console.ReadLine(); 

            //Employee<int> NewEmp4 = new Employee<int> {};


        }
    }
}
