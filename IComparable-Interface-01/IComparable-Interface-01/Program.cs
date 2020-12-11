using System;
using System.Collections.Generic;
using System.IO;

namespace IComparable_Interface_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read a file containing people's names (one name per line), storing them in a list. Then, sort the data from this list and
             *show them neatly on the screen. Note: the file path can be entered "hardcode".*/

            string path = @"E:\Advanced-oop\IComparable-Interface-01\file.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
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
