using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my area calculator program!");
        Console.WriteLine("What AREA do you need to find? (circle, rectangle, triangle)?: ");
        string n;
        bool validate = false;
        string[] options = new string[] { "rectangle", "triangle", "circle" };   // creating an array for input validation
        do
        {
            n = Console.ReadLine().ToLower();   // getting user input and converting to lowercase 
            if (options.Contains(n))
            {
                Console.WriteLine($"Your option: {n}.");
                if (n == "triangle")
                {
                    Console.WriteLine("Please insert the base of the triangle: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("And now insert the height: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area = {AreaT(a, b)}.");
                }
                else if (n == "rectangle")
                {
                    Console.WriteLine("Please insert the length: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("And now insert the width: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area = {AreaR(c, d)}.");
                }
                else
                {
                    Console.WriteLine("Please insert the radius of your circle: ");
                    double e = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area = {Math.Round(AreaC(e), 2)}.");  // It prints out circle area with 2 decimals.
                }
                validate = true;
            }
            else
            {
                Console.WriteLine("You've entered an invalid option.\nPlease type \"triangle\", \"circle\" or \"rectangle\"");
            }

        } while (!validate);
    }
        
    public static double AreaC(double radius)  // Area function for a circle
    {
        return radius * radius * Math.PI;
    }

    public static double AreaR(double length, double width)  // Area function for a rectangle
    {
        return length * width;
    }

    public static double AreaT(double ba, double height) // Area function for a triangle
    {
        return (ba * height) / 2.0;
    }
}