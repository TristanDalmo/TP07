using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07.Classes
{
    internal class Trailer
    {
        private int size;

        public Trailer(int size)
        {
            this.size = size;
        }

        public Trailer (Trailer trailer)
        {
            this.size = trailer.size;
        }

        public override bool Equals(object? obj)
        {
            return obj is Trailer trailer &&
                   size == trailer.size;
        }

        public override string ToString()
        {
            return "[Trailer] capacity " + size + " L";
        }
    }
}
