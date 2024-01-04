namespace Lagerstyringssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Electronics electronics = new Electronics();
            Clothes clothes = new Clothes();
            FoodProducts food = new FoodProducts();
            Storage storage = new Storage(clothes, food, electronics);
            Console.WriteLine("Welcome");
            
            while (true)
            {
                Console.WriteLine("Select what to do:");
                Console.WriteLine("1. Options to View storage");
                Console.WriteLine("2. Add Products");
                Console.WriteLine("3. Remove Product");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Select What Storage to View:");
                        Console.WriteLine("1. Everything at once.");
                        Console.WriteLine("2. Clothes");
                        Console.WriteLine("3. Electronics");
                        Console.WriteLine("4. Food Product");
                        var userInput2 = Console.ReadLine();
                        if (userInput2 == "1")
                        {
                            storage.ShowEntireStock();
                        }

                        if (userInput2 == "2")
                        {
                            storage.ShowClothesList();
                        }

                        if (userInput2 == "3")
                        {
                            storage.ShowElectronicsList();
                        }
                        if (userInput == "4")
                        {
                            storage.ShowFoodProductList();
                        }
                        break;
                    case "2":
                        Console.WriteLine("1. Add Clothes Product");
                        Console.WriteLine("2. Add Electronics");
                        Console.WriteLine("3. Add Food Products");
                        var userInput3 = Console.ReadLine();

                        if (userInput3 is "1")
                        {
                            clothes.CreateClothes();
                        }

                        if (userInput3 is "2")
                        {
                            electronics.CreateElectronicProduct();
                        }

                        if (userInput3 is "3")
                        {
                            food.CreateFoodProduct();
                        }
                        break;
                    case "3":
                        storage.RemoveItem();
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}