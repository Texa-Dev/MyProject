using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGitHW
{
    internal class Worker : Human
    {
        private double Salary;

        public Worker(string name, int age, double salary) : base(name, age)
        {
            Salary = salary;
        }

        public double GetSalary() { return Salary; }
    }
}
