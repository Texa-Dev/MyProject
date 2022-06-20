using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGitHW
{
    internal class Human
    {
        private string Name;

        private int Age;

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetName() { return Name; }

        public int GetAge() { return Age; } 
    }
}
