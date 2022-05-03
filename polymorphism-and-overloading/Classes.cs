using System;

namespace polymorphism_and_overloading
{
    public abstract class Engine
    {
        private  int horsePower { get; set; }
        private int energyStoreMaxSize { get; set; }
        private int currentEnergyStore { get; set; }

        public Engine(int pHorsePower, int pEnergyStoreMaxSize)
        {
            this.horsePower = pHorsePower;
            this.energyStoreMaxSize = pEnergyStoreMaxSize;
        }
        public Engine (){}
        public void Rev(){}
        public void Rev(int n1){}
        public void Refuel(){}
        public void Refuel(int n1){}
    }
    public class InternalCombustionEngine:Engine
    {
        public string fuelType { get; set; }

        public InternalCombustionEngine(string pFuelType, int pHorsePower, int pEnergyStoreMaxSize):base(pHorsePower, pEnergyStoreMaxSize)
        {
            this.fuelType = pFuelType;
        }
    }
}