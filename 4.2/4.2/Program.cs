using System;

class Program{
    static void Main(){
        int[] presentationIDs = { 1, 2, 3, 4, 5 };
        int[] popularityRatings = { 85, 70, 95, 60, 90 };

        Array.Sort(popularityRatings, presentationIDs);

        Console.WriteLine("Presentations sorted by popularity:");
        for (int i = 0; i < presentationIDs.Length; i++){
            Console.WriteLine($"Presentation ID: {presentationIDs[i]}, Popularity: {popularityRatings[i]}");
        }
    }
}
