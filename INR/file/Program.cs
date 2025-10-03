using System;
using System.IO;

class ListFiles
{
    static void Main()
    {
        Console.Write("Enter Directory Path: ");
        string path = Console.ReadLine();

        if (Directory.Exists(path))
        {
            Console.WriteLine("\nFiles in the Directory:");
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist!");
        }
    }
}