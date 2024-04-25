using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employe
    {
        private string name;
        private double salary;
        private string ocupation;
        private string department;

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Occupation { get; set; }
        public string Department { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {this.Name}; Salary: {this.Salary}; Occupation: {this.Occupation}; Department: {this.Department}");
        }
    }
}