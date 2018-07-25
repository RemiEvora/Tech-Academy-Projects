using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndNetFramworkCourseExPg66
{
    class Program
    {
        static void Main(string[] args)
        {
            int rateOne;
            int hoursOne;
            int rateTwo;
            int hoursTwo;



            Console.WriteLine("Anonymous Income Comparison Program - Press Enter to Begin");
            Console.ReadLine();

            //===PERSON 1 DATA INPUT===// 
            Console.WriteLine("Please provide the details for Person 1.");
            Console.WriteLine("Hourly Rate?");
            rateOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            hoursOne = int.Parse(Console.ReadLine());

            //===PERSON 2 DATA INPUT===// 
            Console.WriteLine("Please provide the details for Person 2.");
            Console.WriteLine("Hourly Rate?");
            rateTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            hoursTwo = int.Parse(Console.ReadLine());

            //===SALARY AND COMPARISON OUTPUTS===// 
            int salaryOne = (rateOne * hoursOne) * 52;
            Console.WriteLine("The annual salary of Person 1 is: " + salaryOne);
            int salaryTwo = (rateTwo * hoursTwo) * 52;
            Console.WriteLine("The annual salary of Person 2 is: " + salaryTwo);
            

            Console.WriteLine("Does Person 1 make more money than Person 2?");

            if (salaryOne > salaryTwo)
                Console.WriteLine("True");
            else if (salaryOne < salaryTwo)
                Console.WriteLine("False");
            else
                Console.WriteLine("They make the same amount.");


            Console.WriteLine("Analysis Complete. Press the Enter key to close.");
            Console.ReadLine();
        }
    }
}
