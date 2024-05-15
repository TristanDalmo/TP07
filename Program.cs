using System;
using TP07.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wheel w1 = new Wheel(15);
            Wheel w2 = new Wheel(w1);
            Console.WriteLine(w1 == w2); // doit indiquer false
            Console.WriteLine(w1.Equals(w2)); // doit indiquer true

        }
    }
}