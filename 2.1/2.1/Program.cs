using System;
using System.Globalization;

class Program {
    static void Main() {
        Console.Write("Enter the variant number (1 for 'first', 2 for 'second', 3 for 'third'): ");
        int variant = int.Parse(Console.ReadLine());

        Console.Write("Enter the value for x: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double z = 0;
        bool isValid = true;

        switch (variant) {
            case 1: 
                z = Math.Pow(Math.Sin(x), 2);
                break;
            case 2: 
                if (x <= 0){
                    Console.WriteLine("Error: x must be greater than 0 to calculate its logarithm base 2.");
                    isValid = false;
                } else {
                    z = Math.Log(x, 2);
                }
                break;
            case 3: 
                double cosCubedX = Math.Cos(Math.Pow(x, 3));
                if (cosCubedX == 0) {
                    Console.WriteLine("Error: cosine of x cubed cannot be zero.");
                    isValid = false;
                } else {
                    z = 1 / cosCubedX;
                }
                break;
            default:
                Console.WriteLine("Error: May be next time))");
                isValid = false;
                break;
        }

        if (isValid) {
            Console.WriteLine($"The value of z(x) for variant {variant} is: {z}");
        }
    }
}