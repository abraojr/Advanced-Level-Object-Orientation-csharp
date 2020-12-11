using IComparable_Interface_02.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparable_Interface_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Advanced-oop\IComparable-Interface-02\file.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
