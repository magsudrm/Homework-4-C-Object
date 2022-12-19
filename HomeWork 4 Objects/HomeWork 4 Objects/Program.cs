using System;
using System.Data;

namespace HomeWork_4_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-2
            Notebook Company1 = new Notebook
            {
                BrandName = "Acer",
                Name = "Aspire 3",
                Price = 800
            };
            Notebook Company2 = new Notebook
            {
                BrandName = "Asus",
                Name = "GTX 15",
                Price = 2700
            };
            Notebook Company3 = new Notebook
            {
                BrandName = "Apple",
                Name = "Mac Book Pro",
                Price = 3800
            };
            Notebook Company4 = new Notebook
            {
                BrandName = "HP",
                Name = "Elite Dragonfly",
                Price = 6900
            };

            // Task-2

            Notebook[] MinAndMaxPrice = new Notebook[] { Company1, Company2, Company3, Company4 };
            Console.WriteLine("Minimum deyeri daxil edin");
            string MinPriceStr=Console.ReadLine();
            int MinPrice=Convert.ToInt32(MinPriceStr);
            Console.WriteLine("Maksimum deyeri daxil edin");
            string MaxPriceStr=Console.ReadLine();
            int MaxPrice=Convert.ToInt32(MaxPriceStr);
            bool IsHere = false;

            for(int i = 0; i < MinAndMaxPrice.Length; i++)
            {
                if (MinPrice < MinAndMaxPrice[i].Price && MaxPrice > MinAndMaxPrice[i].Price)
                {
                    Console.WriteLine(MinAndMaxPrice[i].BrandName +" "+ MinAndMaxPrice[i].Name);
                    IsHere = true;
                }
            }
             if(IsHere == false)
                    Console.WriteLine("Axtardiginiz araliqda Notebook yoxdur");
             Console.WriteLine("===============================================");

            // Task-3

            Car Corporation1 = new Car
            {
                Brand = "Lexus",
                Model = "Lx570",
                CurrentFuel = 100,
                FuelFor1Km = 3,
                Millage = 34221
            };
            Car Corporation2 = new Car
            {
                Brand = "Mercedes Benz",
                Model = "C600",
                CurrentFuel = 85,
                FuelFor1Km = 2,
                Millage = 75643
            };
            Car Corporation3 = new Car
            {
                Brand = "Chevrolet",
                Model = "Malibu",
                CurrentFuel = 56,
                FuelFor1Km = 1,
                Millage = 173289
            };
            Car Corporation4 = new Car
            {
                Brand = "Vaz",
                Model = "2107",
                CurrentFuel = 34,
                FuelFor1Km =1,
                Millage = 554833
            };

            Car[] corporations = new Car[] { Corporation1, Corporation2, Corporation3, Corporation4 };
            Console.WriteLine("Getmek istediyiniz mesafeni daxil edin");
            string KmStr=Console.ReadLine();
            int KM = Convert.ToInt32(KmStr);

            for(int i = 0;i< corporations.Length; i++)
            {
                corporations[i].Drive(KM);
                Console.WriteLine(corporations[i].Brand+" " + corporations[i].Model);
                Console.WriteLine($"Current Fuel: " + corporations[i].CurrentFuel);
                Console.WriteLine($"Millage: " + corporations[i].Millage);
                Console.WriteLine("-----------------------------------------------");
            }

            



        }
    }
}
