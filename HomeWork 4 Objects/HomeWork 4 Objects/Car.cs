using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_4_Objects
{
    internal class Car
    {
        // Task-3
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1Km;
        public int Millage;

        public void Drive(int HowManyKm)
        {
            if (CurrentFuel / FuelFor1Km >= HowManyKm)
            {
                Millage += HowManyKm;
                CurrentFuel -= FuelFor1Km * HowManyKm;
            }
            else
                Console.WriteLine("Xeta: Deponuzda kifayet qeder benzin yoxdur");
        }
    }
}
