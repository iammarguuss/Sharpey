using System;

class Program {
    static void Main() {
        Console.Write("Enter the value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the minimum value of x (xmin): ");
        double xmin = double.Parse(Console.ReadLine());

        Console.Write("Enter the maximum value of x (xmax): ");
        double xmax = double.Parse(Console.ReadLine());

        Console.Write("Enter the step value (dx): ");
        double dx = double.Parse(Console.ReadLine());

        for (double x = xmin; x <= xmax; x += dx) {
            if (a * x <= 0) {
                Console.WriteLine("The argument of the logarithm must be greater than 0. Skipping the value.");
                continue;
            }

            double cos_ax = Math.Cos(a * x);
            double y = Math.Cbrt(cos_ax + x * cos_ax / Math.Log(a * x));
            Console.WriteLine($"f({x}) = {y}");
        }
    }
}
