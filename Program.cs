namespace Cala_NET_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //title of application, as well as short description of what it does
            Console.WriteLine("POLYNOMIAL CALCULATOR V1.0\n");
            Console.WriteLine("This application  will calculate the values of polynomial functions of up to degree 3 over a domain. It\r\nwill start with a heading. It will then ask you to enter the details of a polynomial, including its degree, its\r\ncoefficients, and the min and max of the dom\r\nain. Provided all the data was entered correctly, the application will\r\ntabulate the values over the domain. It will then ask the user if they want to enter the details for another\r\npolynomial. If they do, it will repeat the process.");
            char sentinel = 'y';
            do
            {
                //prompt the user for the details of polynamial #!
                Console.WriteLine("Enter the degree for the polynomial ");
                int degree = int.Parse(Console.ReadLine());
                Console.WriteLine("\n" + degree);

                //if the user selects 3
                if (degree == 3)
                {
                    Console.WriteLine("\n Please specify the coefficients for f(x) = ax^3 + bx^2 + cx +d: \n");

                    //get d
                    Console.WriteLine("Enter d: ");
                    int d = int.Parse(Console.ReadLine());

                    //get c
                    Console.WriteLine("Enter c: ");
                    int c = int.Parse(Console.ReadLine());

                    //get b
                    Console.WriteLine("Enter b: ");
                    int b = int.Parse(Console.ReadLine());

                    //get a
                    Console.WriteLine("Enter a: ");
                    int a = int.Parse(Console.ReadLine());

                    //get min x
                    Console.WriteLine("Enter min x: ");
                    int min = int.Parse(Console.ReadLine());

                    //get max x
                    Console.WriteLine("Enter max x: ");
                    int max = int.Parse(Console.ReadLine());


                    //calculate results here

                    //print results
                    Console.WriteLine("Here is the polynomial over the domain  through ");
                }
                else if (degree == 2)
                {
                    Console.WriteLine("\n Please specify the coefficients for f(x) = bx^2 + cx +d: \n");

                    //get d
                    Console.WriteLine("Enter d: ");
                    int d = int.Parse(Console.ReadLine());

                    //get c
                    Console.WriteLine("Enter c: ");
                    int c = int.Parse(Console.ReadLine());

                    //get b
                    Console.WriteLine("Enter b: ");
                    int b = int.Parse(Console.ReadLine());

                    //get min x
                    Console.WriteLine("Enter min x: ");
                    int min = int.Parse(Console.ReadLine());

                    //get max x
                    Console.WriteLine("Enter max x: ");
                    int max = int.Parse(Console.ReadLine());

                    //calculate results here

                    //print results
                    Console.WriteLine("Here is the polynomial over the domain  through");
                }


                else if (degree == 1)
                {
                    Console.WriteLine("\n Please specify the coefficients for f(x) = cx +d: \n");

                    //get d
                    Console.WriteLine("Enter d: ");
                    int d = int.Parse(Console.ReadLine());

                    //get c
                    Console.WriteLine("Enter c: ");
                    int c = int.Parse(Console.ReadLine());

                    //get min x
                    Console.WriteLine("Enter min x: ");
                    int min = int.Parse(Console.ReadLine());

                    //get max x
                    Console.WriteLine("Enter max x: ");
                    int max = int.Parse(Console.ReadLine());

                    //calculate results here

                    //print results
                    Console.WriteLine("Here is the polynomial over the domain  through");
                }

                else { Console.WriteLine("Invalid Degree, Please only provide degree within range of 1-3\n"); }
            }

            while (true);
        }

     }
}
