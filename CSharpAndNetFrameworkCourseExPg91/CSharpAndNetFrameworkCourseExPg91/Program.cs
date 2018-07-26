using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndNetFrameworkCourseExPg91
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("For any fractions, please round UP - EG. 1.4 => 2");
            Console.WriteLine("Please enter the total weight of the package: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

           if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
           else
            {
                Console.WriteLine("Thank you.");
            }

            Console.WriteLine("Please enter your package's width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your package's height: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finally, please enter your package's length: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int totalDimensions = packageWidth + packageHeight + packageLength;
            int quote = (totalDimensions * packageWeight) / 100;

            if (totalDimensions > 50)
            {
                Console.WriteLine("Your package is too large to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C2"));
                Console.WriteLine("Press Enter key to continue.");
                Console.ReadLine(); 
            }
            
        }
    }
}
