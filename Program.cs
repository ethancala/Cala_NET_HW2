namespace Cala_NET_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //title of application, as well as short description of what it does
            Console.WriteLine("POLYNOMIAL CALCULATOR V1.0\n");
            Console.WriteLine("This application  will calculate the values of polynomial functions of up to degree 3 over a domain. It\r\nwill start with a heading. It will then ask you to enter the details of a polynomial, including its degree, its\r\ncoefficients, and the min and max of the dom\r\nain. Provided all the data was entered correctly, the application will\r\ntabulate the values over the domain. It will then ask the user if they want to enter the details for another\r\npolynomial. If they do, it will repeat the process.");
        

            //prompt the user for the details of polynamial #!
            Console.WriteLine("Enter the details for the polynomial #1");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + degree);

            //if the user selects 3
            if (degree == 3) {
                Console.WriteLine("\n Please specify the coefficients for f(x) = ax^3 + bx^2 +cx +d: \n");
                Console.WriteLine("Enter d: ");
                    }
            else if (degree == 2) { }


            else if (degree == 1) { }

            else { Console.WriteLine("Invalid Degree, Please only provide degree within range of 1-3\n"); }

        }

        }
}
