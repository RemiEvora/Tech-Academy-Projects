using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg113
{
    public class ConversionMethods
    {
        public ConversionMethods()
        {

        }

        public int IntAddition(int num01)
        {
            return num01 + 250; 
        }

        public double DoubleMultiplication (double num02)
        {   

            return Convert.ToInt32(num02 * 0.25); 
        }

        public int StringSubtraction(string num03)
        {
            int convert03 = Int32.Parse(num03);
            int subtract = convert03 - 5;
            return subtract; 

           
        }
    }
}
