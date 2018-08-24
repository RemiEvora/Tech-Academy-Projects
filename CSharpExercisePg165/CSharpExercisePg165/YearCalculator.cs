using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg165
{
    public class YearCalculator
    {
        public YearCalculator()
        {
            
        }
        public int userAge { get; set; }

        public int Calculate(int userAge)
        {
            var todayDate = DateTime.Now;
            var userYears = todayDate.AddYears(-userAge);
            return userYears;
        }
    }
}
