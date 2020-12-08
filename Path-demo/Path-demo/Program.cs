using System;
using System.IO;

namespace Path_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Advanced-oop\Path-demo\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); //OUTPUT: \

            Console.WriteLine("PathSeparator: " + Path.PathSeparator); //OUTPUT: ;

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); //OUTPUT: E:\Advanced-oop\Path-demo\myfolder

            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); //OUTPUT: file1.txt

            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); //OUTPUT: .txt

            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); //OUTPUT: file1

            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); //OUTPUT:  E:\Advanced-oop\Path-demo\myfolder\file1.txt

            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); //OUTPUT: Will show the path of your temporary folder from disc C
        }
    }
}
