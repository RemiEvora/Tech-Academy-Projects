using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg140
{
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int IDNumber { get; set; }

        public Employee(string FName, string LName, int IDNumber)
        {
            this.FName = FName;
            this.LName = LName;
            this.IDNumber = IDNumber;

        }


    }

    
}
