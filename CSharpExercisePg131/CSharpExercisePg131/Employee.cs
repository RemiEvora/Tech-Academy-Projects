using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg131
{
    //1. Make the Employee class take a generic type parameter.
    public class Employee <T>: Person, IQuittable
    {
        //2. Add a property to the Employee class called "things" and have its data 
        // type be a generic list matching the generic type of the class.
        public List<T> Things { get; set; }
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

        
        public static bool operator ==(Employee<T> NewEmp1, Employee<T> NewEmp2)
        {

            {
                return NewEmp1.EmployeeID == NewEmp2.EmployeeID;
            }

        }

        public static bool operator !=(Employee<T> NewEmp1, Employee<T> NewEmp2)
        {


            {
                return NewEmp1.EmployeeID != NewEmp2.EmployeeID;
            }

        }

        public override int GetHashCode()
        {
            return EmployeeID.GetHashCode();
        }

        public override bool Equals(object obj) //Suggested addition by Tech Ac. Jordan (review/research syntax for later) 
        {
            var NewEmp1 = obj as Employee<T>;

            if (null != NewEmp1)
            {
                return NewEmp1.EmployeeID == this.EmployeeID;
            }
            else
            {
                return base.Equals(NewEmp1);
            }
        }
    }

    
}
