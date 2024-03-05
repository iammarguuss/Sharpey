using System;

class Program
{
    static void Main(){
        double[] array1 = ReadArrayFromConsole("1");
        double[] array2 = ReadArrayFromConsole("2");
        double[] array3 = ReadArrayFromConsole("3");

        AnalyzeArray(array1);
        AnalyzeArray(array2);
        AnalyzeArray(array3);
    }

    static double[] ReadArrayFromConsole(string arrayNumber){
        Console.WriteLine($"Enter the number of elements for array {arrayNumber}:");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        for (int i = 0; i < n; i++){
            Console.Write($"Enter element {i + 1} of array {arrayNumber}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        return array;
    }

    static void AnalyzeArray(double[] array){
        double geometricMean = 1;
        int positiveCount = 0;
        double arithmeticMean = 0;
        int negativeCount = 0;

        foreach (double element in array){
            if (element > 0){
                geometricMean *= element;
                positiveCount++;
            } else if (element < 0){
                arithmeticMean += element;
                negativeCount++;
            }
        }

        if (positiveCount > 0){
            geometricMean = Math.Pow(geometricMean, 1.0 / positiveCount);
            Console.WriteLine($"Geometric mean of positive elements: {geometricMean}");
        } else{
            Console.WriteLine("No positive elements for geometric mean calculation.");
        }

        if (negativeCount > 0) {
            arithmeticMean /= negativeCount;
            Console.WriteLine($"Arithmetic mean of negative elements: {arithmeticMean}");
        } else {
            Console.WriteLine("No negative elements for arithmetic mean calculation.");
        }
    }
}
