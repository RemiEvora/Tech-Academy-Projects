using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg116
{
    //Declare a class to be static
    public static class StaticMethod
    {
        public static double DogYearConverter(double userAge)
        {
            double dogYears = userAge * 6.4;
            return dogYears;
        }
    }
}
