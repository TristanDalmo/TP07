using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07.Classes
{
    internal class Wheel
    {
        private int size;
        public int Size { get { return size; } }

        public Wheel(int size)
        {
            this.size = size;
        }

        public Wheel (Wheel wheel)
        {
            this.size = wheel.size;
        }

        public override string ToString()
        {
            return "[Wheel] " + size + " inches";
        }

        public override bool Equals(object? obj)
        {
            return obj is Wheel wheel &&
                   size == wheel.size;
        }
    }
}
