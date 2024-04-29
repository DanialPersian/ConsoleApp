using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please select a file:");

        // Specify the directory path where your text files are located
        string directoryPath = "C:\\Users\\774244.ADIR\\source\\repos\\ConsoleApp2\\ConsoleApp2\\Menu\\"; // Replace with your actual directory path

        // Get all text files in the specified directory
        string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");

        // Display a menu with the available text files
        for (int i = 0; i < txtFiles.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(txtFiles[i])}");
        }

        // Prompt the user to choose a file
        Console.Write("Enter the number corresponding to the file: ");
        if (int.TryParse(Console.ReadLine(), out int selectedFileIndex) && selectedFileIndex >= 1 && selectedFileIndex <= txtFiles.Length)
        {
            // Read and display the contents of the selected file
            string selectedFilePath = txtFiles[selectedFileIndex - 1];
            string fileContents = File.ReadAllText(selectedFilePath);
            Console.WriteLine($"Contents of '{Path.GetFileName(selectedFilePath)}':\n{fileContents}");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please choose a valid file number.");
        }
    }
}
