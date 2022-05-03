using System;

namespace polymorphism_and_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalCombustionEngine ICE1 = new InternalCombustionEngine("Unleaded", 300, 500);
            ICE1.Rev();
            //ICE1.Rev(500);
            ICE1.Refuel();
            //ICE1.Refuel(500);

            ElectricEngine EE1 = new ElectricEngine("Li", 250, 300);
            EE1.Rev();
            EE1.Rev(10);
            EE1.Refuel();
            EE1.Refuel(50);
        }
    }
}
