using System;

class Program{
    static void Main(){
        int[] productIDs = { 1, 2, 3, 4, 5 };
        double[] volumes = { 10.0, 20.0, 15.0, 10.0, 5.0 };
        double[] prices = { 100.0, 300.0, 225.0, 110.0, 50.0 };
        double[] pricePerVolume = new double[prices.Length];

        for (int i = 0; i < prices.Length; i++){
            pricePerVolume[i] = prices[i] / volumes[i];
        }

        Array.Sort(pricePerVolume, productIDs, Comparer<double>.Create((x, y) => y.CompareTo(x)));

        Console.WriteLine("Products sorted by descending price per volume:");
        for (int i = 0; i < productIDs.Length; i++){
            Console.WriteLine($"Product ID: {productIDs[i]}, Price per Volume: {pricePerVolume[i]}");
        }
    }
}
