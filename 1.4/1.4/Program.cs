using System;

class Program {
    static void Main() {
        Console.Write("Enter the maximum Fibonacci number: ");
        int max = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sum = a + b;

        while (b <= max) {
            int temp = a + b;
            a = b;
            b = temp;
            if (b <= max) {
                sum += b;
            }
        }

        Console.WriteLine($"The sum of Fibonacci numbers up to {max} is: {sum}");
    }
}
