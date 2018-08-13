using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg128
{
    class Employee : Person, IQuittable
    {
        public int EmployeeID { get; set; }

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

        //=====Overload the '==' operator so it checks if two Employee objects are equal by comparing their ID property=====//
        public static bool operator ==(Employee NewEmp1, Employee NewEmp2)
        {
            
            {
                return NewEmp1.EmployeeID == NewEmp2.EmployeeID;
            }
             
        }

        public static bool operator !=(Employee NewEmp1, Employee NewEmp2)
        {
           
            
            {
                return NewEmp1.EmployeeID != NewEmp2.EmployeeID;
            }
            
        }

        public override int GetHashCode()
        {
            return EmployeeID.GetHashCode();
        }
    }
}
