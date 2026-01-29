    using System.Collections.Generic;
using System.IO;
	
	var fruits = new List<string> { "Apple", "Banana", "Cherry" };
        string filePath = "MyFruits.txt";

        try
        {
            // Writes each element of the 'fruits' list to a new line in the specified file
            File.WriteAllLines(filePath, fruits);
            Console.WriteLine("Successfully wrote list to {filePath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: {ex.Message}");
        }