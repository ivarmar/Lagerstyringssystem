using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lagerstyringssystem
{
    internal class FoodProducts : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Expire { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Expire date: {Expire} ");
        }

        public void GetExpireDate()
        {
            Console.WriteLine("Input with numbers Day / Month / Year your product expires.");
            Console.Write("Day:");
            var ExpireDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month:");
            var ExpireMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year:");
            var ExpireYear = Convert.ToInt32(Console.ReadLine());

            Expire = ExpireDay + ExpireMonth + ExpireYear;
        }

        public void GetName()
        {
            Console.WriteLine("Give the food product a name:");
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

        public void CreateFoodProduct()
        {
            GetName();
            GetPrice();
            GetExpireDate();
            Console.Clear();
            Console.WriteLine("You have successfully created a new Food Product!");
            Thread.Sleep(2000);
            PrintInfo();
        }
    }
}
