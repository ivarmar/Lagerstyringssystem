using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Clothes : IProduct
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public char Size { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Size: {Size} ");
        }

        public void GetName()
        {
            Console.WriteLine("Give the clothes product a name:");
            var GetName = Console.ReadLine();
            Name = GetName;
            Console.WriteLine($"You named your product {Name}$");
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

        public void ChooseSize()
        {
            Console.Clear();
            Console.WriteLine("Choose a Size(1,2 or 3):");
            Console.WriteLine("1.Small");
            Console.WriteLine("2.Medium");
            Console.WriteLine("3.Large");
            var selectedSize = Console.ReadKey().KeyChar;
            switch (selectedSize)
            {
                case '1':
                    Console.WriteLine("S");
                    Size = 'S';
                    break;
                case '2':
                    Console.Write("M");
                    Size = 'M';
                    break;
                case '3': 
                    Console.WriteLine("L");
                    Size = 'L';
                    break;
            }
            Console.WriteLine($"You selected {Size}");
            Thread.Sleep(2000);
        }

        public void CreateClothes()
        {
            GetName();
            GetPrice();
            ChooseSize();
            Console.Clear();
            Console.WriteLine("You have successfully created a new clothes item!");
            Thread.Sleep(2000);
            PrintInfo();
        }
    }
}
