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

        public void Rev()
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
        public void Rev(int n1)
        {
            int counter = 0;
            while(counter < n1)
            {
                if(CurrentEnergyStore == 0)
                {
                    Console.WriteLine("OUT OF FUEL");
                } else
                {
                    Console.WriteLine("VROOOOMMMM!");
                    CurrentEnergyStore--;
                }
                counter++;
            }
        }
        public void Refuel()
        {
            CurrentEnergyStore = EnergyStoreMaxSize;
            Console.WriteLine("REFUELED TO FULL");
        }
        public void Refuel(int n1)
        {
            if(!(CurrentEnergyStore + n1 > EnergyStoreMaxSize))
            {
                CurrentEnergyStore += n1;
                Console.WriteLine($"REFUELLED {n1} LITRES");
            } else
            {
                CurrentEnergyStore = EnergyStoreMaxSize;
                Console.WriteLine("REFUELED TO FULL");
            }   
        }
    }
    public class ElectricEngine:Engine
    {
        public string batteryType { get; set; }

        public ElectricEngine(string pBatteryType, int pHorsePower, int pEnergyStoreMaxSize):base(pHorsePower, pEnergyStoreMaxSize)
        {
            this.batteryType = pBatteryType;
            this.EnergyStoreMaxSize = pEnergyStoreMaxSize;
            this.CurrentEnergyStore = pEnergyStoreMaxSize;
        }
        public ElectricEngine(){} 
        public void Rev()
        {
            if(CurrentEnergyStore == 0)
            {
                Console.WriteLine("FLAT BATTERY");
            } else
            {
                Console.WriteLine("SWWIIIISSSSHHH!");
                CurrentEnergyStore--;
            }
        }
        public void Rev(int n1)
        {
            int counter = 0;
            while(counter < n1)
            {
                if(CurrentEnergyStore == 0)
                {
                    Console.WriteLine("FLAT BATTERY");
                } else
                {
                    Console.WriteLine("SWWIIIISSSSHHH!!");
                    CurrentEnergyStore--;
                }
                counter++;
            }
        }
        public void Refuel()
        {
            CurrentEnergyStore = EnergyStoreMaxSize;
            Console.WriteLine("RECHARGED TO FULL");
        }
        public void Refuel(int n1)
        {
            if(!(CurrentEnergyStore + n1 > EnergyStoreMaxSize))
            {
                CurrentEnergyStore += n1;
                Console.WriteLine($"RECHARGED {n1} AMP HOURS");
            } else
            {
                CurrentEnergyStore = EnergyStoreMaxSize;
                Console.WriteLine("RECAHRGED TO FULL");
            }   
        }
    }
}