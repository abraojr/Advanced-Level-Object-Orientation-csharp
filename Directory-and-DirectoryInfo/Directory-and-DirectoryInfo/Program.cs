using System;
using System.IO;

namespace Directory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //To use DirectoryInfo you just need to instantiate its members, as is the case with FileInfo

            string path = @"E:\Advanced-oop\Directory-and-DirectoryInfo\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(path + @"\newfolder"); //creates a new folder
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
