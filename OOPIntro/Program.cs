using System;
using System.Collections.Generic;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Customer();
            while (true)
            {
                Console.WriteLine("Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("What do you want to buy?");
                    Console.WriteLine("1. coffee");
                    Console.WriteLine("2. milk");
                    Console.WriteLine("3. nocco");
                    var choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        var coffee = new Coffee();
                        kund._cart.Add(coffee);
                    }
                    if (choice == "2")
                    {
                        kund._cart.Add(milk);
                    }
                    if (choice == "3")
                    {
                        kund._cart.Add(nocco);
                    }
                }
                else
                    break;

                Console.WriteLine("Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes")
                    foreach (var item in kund._cart)
                        Console.WriteLine(item._productName);
                else
                    Console.WriteLine("Suck a duck!");
            }
        }
    }
}
