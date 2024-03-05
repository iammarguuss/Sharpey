using System;

class Program
{
    static void Main() {
        Console.WriteLine("Enter the value for x:");
        string inputX = Console.ReadLine();
        Console.WriteLine("Enter the value for a:");
        string inputA = Console.ReadLine();

        if (double.TryParse(inputX, out double x) && double.TryParse(inputA, out double a)) {
            if (x > 0 && 2 * Math.Sin(Math.PI / 3 + x) != 0) {
                double y = (1.0 / 3.0) * Math.Cbrt(x - a) + Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x));
                Console.WriteLine($"The value of the function f(x) is: {y}");
            } else {
                if (x <= 0) {
                    Console.WriteLine("The variable x must be greater than 0.");
                } 
                if (2 * Math.Sin(Math.PI / 3 + x) == 0) {
                    Console.WriteLine("Division by zero in the denominator.");
                }
            }
        } else {
            Console.WriteLine("Invalid input. Please enter numbers for both x and a.");
        }
    }
}
