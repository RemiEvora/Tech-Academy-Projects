using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg110
{
    public class InputModifier
    {
       
        public InputModifier()
        {

        }

        public double Addition(double numInput1, double numInput2)

        { 
            return numInput1 + numInput2;
        }

        public double Multiplication(double numInput1, double numInput2)

        {
            return numInput1 * numInput2;
        }

        public double Division(double numInput1, double numInput2)

        {
            return numInput1 / numInput2;
        }

    }
}
