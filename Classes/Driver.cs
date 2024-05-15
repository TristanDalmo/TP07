using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07.Classes
{
    internal class Driver
    {
        private string name;

        public Driver(string name)
        {
            this.name = name;
        }

        public Driver (Driver driver)
        {
            this.name = driver.name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Driver driver &&
                   name == driver.name;
        }

        public override string ToString()
        {
            return "[Driver] " + name;
        }
    }
}
