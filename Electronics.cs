using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Electronics : IProduct
    {
        public string Name { get; set; }

        public double Price { get; set; }
        public int WarrantyTime { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Warranty: {WarrantyTime} months");
        }

        public void GetWarrantyTime()
        {
            Console.WriteLine("Input the Warranty in months aka ('12' or '14')");
            var GetWarrantyTime = Convert.ToInt32(Console.ReadLine());
            WarrantyTime = GetWarrantyTime;
        }

        public void GetName()
        {
            Console.WriteLine("Give the electronic product a name:");
            var GetName = Console.ReadLine();
            Name = GetName;
            Console.WriteLine($"You named your product {Name}");
            Thread.Sleep(1000);
        }

        public void GetPrice()
        {
            Console.Write("BuyPrice in $:");
            double GetPrice = double.Parse(Console.ReadLine());
            Price = GetPrice;
            Console.WriteLine($"You made it cost {Price}$");
            Thread.Sleep(1000);
        }

        public void CreateElectronicProduct()
        {
            GetName();
            GetPrice();
            GetWarrantyTime();
            Console.Clear();
            Console.WriteLine("You have successfully created a new electronic product!");
            Thread.Sleep(2000);
            PrintInfo();
        }
    }
}
