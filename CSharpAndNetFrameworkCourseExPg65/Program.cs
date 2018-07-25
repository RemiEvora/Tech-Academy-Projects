using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndNetFrameworkCourseExPg65
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== User Introduction Question =====// 
            int choice;
            

            Console.WriteLine("Which equation do you want to perform?");
            Console.WriteLine("1.Multiply your input by 50 and print the result.");
            Console.WriteLine("2.Add 25 to your input and print the result.");
            Console.WriteLine("3.Divide your input by 12.5 and print the result.");
            Console.WriteLine("4.Check your input if it's greater than 50 then print true/false.");
            Console.WriteLine("5.Divide your input by 7 and print the remainder.");
            Console.WriteLine("Please choose a number between 1 and 5:");
            choice = int.Parse(Console.ReadLine());
            
            if (choice > 5 || choice < 0)
                Console.WriteLine("Please enter a number between 1 and 5:");
            else
                Console.WriteLine("Thanks. Let's get started. Press 'Enter' to continue.");  
                Console.ReadLine();


            //===== Switch for Number Chosen =====// 
            switch (choice)
            { 
                case  1: // <--Use the variables you set then provide it with a valid input - 
                         //in this case, "int choice" requires a 7, not a string input of "7".
                    {
                        int userNumber;
                        Console.WriteLine("Give me the number you want to multiply: ");
                        userNumber = int.Parse(Console.ReadLine());
                        int productTotal = userNumber * 50;
                        Console.WriteLine(productTotal);
                        Console.ReadLine();
                        break; //Adding 'break' here removes red lines from 'case' 
                    }; 
                case 2:
                    
                    {
                        int userNumber;
                        Console.WriteLine("Give me the number you want to add: ");
                        userNumber = int.Parse(Console.ReadLine());
                        int sumTotal = userNumber + 25;
                        Console.WriteLine(sumTotal);
                        Console.ReadLine();
                        break;
                    };
                case 3:
                    
                    {
                        double userDividend;
                        Console.WriteLine("Give me the number you want to divide: ");
                        userDividend = double.Parse(Console.ReadLine());
                        double quotientTotal = userDividend / 12.5;
                        Console.WriteLine(quotientTotal);
                        Console.ReadLine();
                        break;
                    };
                case 4:
                    
                    {
                        int userNumber;
                        Console.WriteLine("Give me the number you want to check: ");
                        userNumber = int.Parse(Console.ReadLine());
                        if (userNumber > 50)
                            Console.WriteLine("True");
                        else
                            Console.WriteLine("False");
                        Console.ReadLine();
                        break;
                    };
                case 5:

                    {
                        double userDividend;
                        Console.WriteLine("Give me the number you want to divide by: ");
                        userDividend = double.Parse(Console.ReadLine());
                        double remainderTotal = userDividend % 7;
                        Console.WriteLine(remainderTotal);
                        Console.ReadLine();
                        break;

                    }
            }


           
           





        }
    }
}
