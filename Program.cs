using System;

namespace Cala_NET_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //title of application, as well as short description of what it does
            Console.WriteLine("POLYNOMIAL CALCULATOR V1.0\n");
            Console.WriteLine("This application will calculate the values of polynomial functions of up to degree 3 over a domain. It will start with a heading, then ask you to enter the details of a polynomial, including its degree, its coefficients, and the min and max of the domain. Provided all the data was entered correctly, the application will tabulate the values over the domain. It will then ask the user if they want to enter the details for another polynomial. If they do, it will repeat the process.");

            //condition for loop
            string sentinel = "y";
            int attemptCount = 0;

            //do while loop to execute at least once
            do
            {
                //increment attempts
                attemptCount++;

                Console.WriteLine($"Enter the details for polynomial #{attemptCount}");
                // Prompt the user for the degree of the polynomial
                Console.WriteLine("\nEnter the degree for the polynomial (1-3): ");

                //the degree
                int degree = 0;

                //infinite loop that breaks IF the input is valid
                while (true)
                {
                    //try to get input, as long as it is valid
                    try
                    {
                        //get int degree 
                        degree = int.Parse(Console.ReadLine());

                        //ensure it is valid
                        if (degree < 1 || degree > 3)
                        {

                            //if not valid contiue loop until valid
                            Console.WriteLine("Invalid input. Please enter a degree between 1 and 3.");
                            continue;
                        }
                        //break from loop if valid
                        break;
                    }
                    //format error
                    catch (FormatException)
                    {
                        //let user know the format is wrong
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }



                // Get coefficients and domain based on the degree
                int a = 0, b = 0, c = 0, d = 0;
                int min = 0, max = 0;

                //if we get degree 3
                if (degree == 3)
                {
                    //prompt and get user input
                    Console.WriteLine("\nPlease specify the coefficients for f(x) = ax^3 + bx^2 + cx + d:");

                    d = GetCoefficient("Enter d: ");
                    c = GetCoefficient("Enter c: ");
                    b = GetCoefficient("Enter b: ");
                    a = GetCoefficient("Enter a: ");
                }

                //if we get degree 2
                else if (degree == 2)
                {
                    //prompt and get user input
                    Console.WriteLine("\nPlease specify the coefficients for f(x) = bx^2 + cx + d:");

                    d = GetCoefficient("Enter d: ");
                    c = GetCoefficient("Enter c: ");
                    b = GetCoefficient("Enter b: ");
                }

                //if we get degree 1
                else if (degree == 1)
                {
                    //prompt and get user input
                    Console.WriteLine("\nPlease specify the coefficients for f(x) = cx + d:");

                    d = GetCoefficient("Enter d: ");
                    c = GetCoefficient("Enter c: ");
                }

                // get the min and max values for x
                min = GetXValue("Enter min x: ");
                max = GetXValue("Enter max x: ");

                // Calculate and print results in a nice formatted way
                Console.WriteLine("\nPolynomial over the domain:");

                Console.WriteLine(" x        |  f(x)");
                Console.WriteLine("--------------------");

                //calculate domain
                int x = min;

                //iterate through domain min -> max
                while (x <= max)
                {
                    double y = 0;

                    //This is just the f(x) = ax^3 + bx^2 + cx + d. solved. I used the math libarary to calulate the powers. 
                    if (degree == 3) { y = a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d; }

                    //This does the same, just for f(x) = bx^2 + cx + d.
                    else if (degree == 2) { y = b * Math.Pow(x, 2) + c * x + d; }

                    //same here f(x) = cx + d
                    else if (degree == 1) { y = c * x + d;}

                    
                    //this is the formatted output, I had to look up how to format the table properly.
                    Console.WriteLine($" {x,-8} | {y,-8:F2}");

                    //once the y value is calculated, we keep iterating until x > max, which means we checked the entire domain
                    //increment x
                    x++;
                }

                

                // ask the user if they want to enter another polynomial
                Console.Write("\nDo you want to enter another polynomial? (y/n): ");
                sentinel = Console.ReadLine().ToLower();

                //Im not sure if this is a requirment, but I also make sure that the input here is valid
                while (sentinel != "y" && sentinel != "n")
                {
                    Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
                    sentinel = Console.ReadLine().ToLower();
                }

                //if yes keep looping
            } while (sentinel == "y");

            // exit message if no
            Console.WriteLine("\nThank you for using the Polynomial Calculator. Goodbye!");
        }






        // I made functions to get Xvalue and Coefficient to do error handling instead, just to clean up the code, I hope that is ok

        //get coe
        static int GetCoefficient(string prompt)
        {
            int coef = 0;

            //loop forever until valid input
            while (true)
            {
                //try catch for formatting error
                try
                {
                    //prompt user using prompt 
                    Console.Write(prompt);

                    //read the coe
                    coef = int.Parse(Console.ReadLine());

                    //break if valid
                    break;
                }

                //otherwise keep looping and let user know invalid input
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            //return the coe if valid
            return coef;
        }

        //get Xvalue
        static int GetXValue(string prompt)
        {
            int value = 0;

            //loop forever until valid input
            while (true)
            {
                //try catch for formatting error
                try
                {
                    //prompt user using prompt 
                    Console.Write(prompt);

                    //read value
                    value = int.Parse(Console.ReadLine());

                    //break if valid
                    break;
                }

                 //otherwise keep looping and let user know invalid input
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } 
            //otherwise keep looping and let user know invalid input
            return value;
        }
    }
}
