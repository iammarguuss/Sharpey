using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] height = new int[n];
        int[] weight = new int[n];
        Random random = new Random();

        int minHeight = 150, maxHeight = 200;
        int minWeight = 50, maxWeight = 100;

        for (int i = 0; i < n; i++){
            height[i] = random.Next(minHeight, maxHeight + 1);
            weight[i] = random.Next(minWeight, maxWeight + 1);
        }

        Array.Sort(height, weight);

        Console.WriteLine("Sorted employees by height:");
        for (int i = 0; i < n; i++){
            Console.WriteLine($"Height: {height[i]} cm, Weight: {weight[i]} kg");
        }
    }
}
