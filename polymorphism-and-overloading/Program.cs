using System;

namespace polymorphism_and_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalCombustionEngine ICE1 = new InternalCombustionEngine("Unleaded", 300, 500);
            ICE1.Rev(500);
            ICE1.Refuel(500);
        }
    }
}
