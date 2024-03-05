using System;

class Program {
    static void Main() {
        Console.Write("Enter the minimum value of x (xmin): ");
        double xmin = double.Parse(Console.ReadLine());

        Console.Write("Enter the maximum value of x (xmax): ");
        double xmax = double.Parse(Console.ReadLine());

        Console.Write("Enter the step value (dx): ");
        double dx = double.Parse(Console.ReadLine());

        for (double x = xmin; x <= xmax; x += dx){
            double y = (1.0 / 3.0) * (Math.Pow(x, 2) * Math.Cbrt(x) + 2) + Math.Log(x * x + 1) / (2 * Math.PI);
            Console.WriteLine($"f({x}) = {y}");
        }
    }
}
