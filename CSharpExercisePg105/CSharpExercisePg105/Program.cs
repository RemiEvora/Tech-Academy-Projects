using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg105
{
    class Program
    {
        static void Main(string[] args)
        {

            //====Integer List, Divisor Input, and Result-Printing Loop Construction====//
            //==========================================================================//
            try
            {
                List<int> numberList = new List<int>()
                { 1, 55, 72, 8, 37, 90, 20500 };
                List<int> resultList = new List<int>();

                Console.WriteLine("Give me a number to divide my list by: ");
                int divisorInput = Convert.ToInt32(Console.ReadLine());

                foreach (int dividend in numberList)
                {
                    int quotient = dividend / divisorInput;

                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }
            catch (FormatException ex) //for any format errors, such as string inputs for int input requests
                {
                    Console.WriteLine("Please provide a numeric input."); 
                }
            catch (DivideByZeroException ex) //for any errors from using '0' as the input
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            finally
                {
                    Console.WriteLine("Program enacted a try-catch block and continued with execution.");
                    Console.ReadLine(); 
                }
             
        }
    }
}
