using System;

namespace polymorphism_and_overloading
{
    public abstract class Engine
    {
        private  int horsePower;
        public int HorsePower { get; set; }
        private int energyStoreMaxSize;
        public int EnergyStoreMaxSize { get; set; }
        private int currentEnergyStore;
        public int CurrentEnergyStore { get; set; }

        public Engine(int pHorsePower, int pEnergyStoreMaxSize)
        {
            this.horsePower = pHorsePower;
            this.energyStoreMaxSize = pEnergyStoreMaxSize;
            currentEnergyStore = energyStoreMaxSize;
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
            this.EnergyStoreMaxSize = pEnergyStoreMaxSize;
            this.CurrentEnergyStore = pEnergyStoreMaxSize;
        }
        public InternalCombustionEngine(){}

        public void rev()
        {
            if(CurrentEnergyStore == 0)
            {
                Console.WriteLine("OUT OF FUEL");
            } else
            {
                Console.WriteLine("VROOOOMMMM!");
                CurrentEnergyStore--;
            }
        }

    }
    public class ElectricEngine:Engine
    {
        public string batteryType { get; set; }

        public ElectricEngine(string pBatteryType, int pHorsePower, int pEnergyStoreMaxSize):base(pHorsePower, pEnergyStoreMaxSize)
        {
            this.batteryType = pBatteryType;
            CurrentEnergyStore = EnergyStoreMaxSize;
        }
        public ElectricEngine(){} 
    }
}