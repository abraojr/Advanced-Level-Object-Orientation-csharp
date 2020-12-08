using System;
using System.IO;

namespace Using_block_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The block using is a simplified syntax that ensures that the IDisposable objects will be closed.
             * IDisposable objects are NOT managed by the CLR. They need to be manually closed. Examples: Font, FileStream, StreamReader, StreamWriter.*/

            string path = @"E:\Advanced-oop\Using-block-01\file1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
