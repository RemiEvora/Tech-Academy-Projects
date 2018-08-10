using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg123
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee Name: ");
            base.SayName();
        }
    }
}
