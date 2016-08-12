using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    class Earthling : Robot
    {
       

        public Earthling(string name, string purpose, int age)
        {
            this.name = name;
            this.purpose = purpose;
            this.age = age;
            this.origin = "Planet Earth";
        }

    }
}
