using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Storage
    {

     public List<Clothes> ClothesList { get; set; } = new List<Clothes>();

     public List<FoodProducts> FoodProductsList { get; set; } = new List<FoodProducts>();

     public List<Electronics> ElectronicsList { get; set; } = new List<Electronics>();

     public Storage(Clothes clothes, FoodProducts foodProducts, Electronics electronics)
     {

         ClothesList.Add(clothes);
         FoodProductsList.Add(foodProducts);
         ElectronicsList.Add(electronics);
     }

     public void ShowFoodProductList()
     {
         foreach (var FoodProduct in FoodProductsList)
         {
             Console.WriteLine($"Product Name: {FoodProduct.Name}");
             Console.WriteLine($"Product Price: {FoodProduct.Price}");
             Console.WriteLine($"Product Expire: {FoodProduct.Expire}");
         }
         Console.WriteLine("Hit a key to continue");
         Console.ReadKey();
     }
     public void ShowClothesList()
     {
         foreach (var Clothe in ClothesList)
         {
             Console.WriteLine($"Product Name: {Clothe.Name}.");
             Console.WriteLine($"Product Price: {Clothe.Price}");
             Console.WriteLine($"Product Size: {Clothe.Size}");
         }
         Console.WriteLine("Hit a key to continue");
         Console.ReadKey();
     }
     public void ShowElectronicsList()
     {
         foreach (var Electronic in ElectronicsList)
         {
             Console.WriteLine($"Product Name: {Electronic.Name}");
             Console.WriteLine($"Product Price: {Electronic.Price}");
             Console.WriteLine($"Product Warranty: {Electronic.WarrantyTime}");
         }
         Console.WriteLine("Hit a key to continue");
         Console.ReadKey();
     }

     public void ShowEntireStock()
     {
         Console.Clear();
         ShowFoodProductList();
         ShowClothesList();
         ShowElectronicsList();
         Console.WriteLine("Hit a key to continue");
         Console.ReadKey();
     }

     public void RemoveItem()
     {
         Console.WriteLine("Please Select a category to remove an item from:");
         Console.WriteLine("1. Clothes");
         Console.WriteLine("2. Food Products");
         Console.WriteLine("3. Electronics");
         var input = Console.ReadLine();
         switch (input)
         {
             case "1":
                 Console.WriteLine($"Select a clothes item to remove");
                     ShowClothesList();
                     Console.WriteLine("List starts at '0', select item to remove");
                    var Remove1 = Convert.ToInt32(Console.ReadLine());
                    ClothesList.RemoveAt(Remove1);
                    break;
             case "2":
                 Console.WriteLine("Select a food product to remove");
                     ShowFoodProductList();
                     Console.WriteLine("List starts at '0', select item to remove");
                     Console.WriteLine("hit a key to continue"); 
                    var Remove2 = Convert.ToInt32(Console.ReadLine());
                    FoodProductsList.RemoveAt(Remove2);
                    break;
             case "3":
                 ShowElectronicsList();
                 Console.WriteLine("List starts at '0', select item to remove");
                 var Remove3 = Convert.ToInt32(Console.ReadLine());
                 ElectronicsList.RemoveAt(Remove3);
                 break;
         }
         Console.WriteLine("Hit a key to continue");
         Console.ReadKey();
        }


    }
}
