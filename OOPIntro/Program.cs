using System;
using System.Collections.Generic;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            var answer = "";
            var kund = new Customer();
            while (true)
            {
                Console.WriteLine("\n" + "Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("\n" + "What do you want to buy?");
                    Console.WriteLine("1. Bread");
                    Console.WriteLine("2. Cider");
                    Console.WriteLine("3. Shirt");
                    var choice = Console.ReadLine();
                    
                    if (choice == "1")
                    {
                        var bread = new Bread();
                        kund._cart.Add(bread);

                        Console.WriteLine("\n" + "What bread do you want?");
                        Console.WriteLine("1. Soft bread");
                        Console.WriteLine("2. Hard bread");
                        Console.WriteLine("3. Knäkebröd");
                        answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            bread.Type = "Soft bread";
                        }

                        else if (answer == "2")
                        {
                            bread.Type = "Hard bread";
                        }

                        else if (answer == "3")
                        {
                            bread.Type = "Knäkebröd";
                        }
                    }

                    else if (choice == "2")
                    {
                        var cider = new Cider();
                        kund._cart.Add(cider);

                        Console.WriteLine("\n" + "What alcaholpercentage do you want?");
                        Console.WriteLine("1. 0.5%");
                        Console.WriteLine("2. 2.2%");
                        Console.WriteLine("3. 4.5%");
                        answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            cider.Alcohol = "0.5%";
                        }

                        else if (answer == "2")
                        {
                            cider.Alcohol = "2.2%";
                        }

                        else if (answer == "3")
                        {
                            cider.Alcohol = "4.5%";
                        }

                    }

                    else if (choice == "3")
                    {
                        var shirt = new Shirt();
                        kund._cart.Add(shirt);

                        Console.WriteLine("\n" + "What size do you want?");
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            shirt.Size = "Small";
                        }

                        else if (answer == "2")
                        {
                            shirt.Size = "Medium";
                        }

                        else if (answer == "3")
                        {
                            shirt.Size = "Large";
                        }
                    }
                }
                else
                    break;

                Console.WriteLine("\n" + "Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes")
                foreach (var product in kund._cart)
                {
                    if (product.GetType() == typeof(Bread))
                    {
                        Console.WriteLine("You ordered a " + ((Bread)product).Type);
                    }
                    else if (product.GetType() == typeof(Cider))
                    {
                        Console.WriteLine("You ordered a " + ((Cider)product).Alcohol + " cider");
                    }
                    else if (product.GetType() == typeof(Shirt))
                    {
                        Console.WriteLine("You ordered a " + ((Shirt)product).Size + " shirt");
                    }

                }
                else
                    Console.WriteLine("Suck a duck!");
            }
        }
    }
}
