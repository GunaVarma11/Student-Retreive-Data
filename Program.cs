using System;
using System.IO;

class Program
{
    static void Main()
    {


        // Specify the path to your text file
        string filePath = @"R:\Guna\Student.txt ";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("invalid file path");

        }

    }
}
