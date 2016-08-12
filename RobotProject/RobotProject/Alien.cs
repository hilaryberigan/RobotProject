using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class Alien : Robot
    {
        public Alien (string name, string purpose, int age)
        {
            this.name = name;
            this.age = age;
            this.purpose = purpose;
            this.origin = "Kodetopia";
        }


    }
}
