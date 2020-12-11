using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IComparable_Interface_02.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string employeeCsv)
        {
            string[] vect = employeeCsv.Split(",");
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", U$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
