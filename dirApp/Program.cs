using System;
using System.Collections.Generic;

namespace BurgerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🍔 Welcome to the Burger Order App!");

            // Step 1: Show burger menu
            Console.WriteLine("\nPlease choose a burger:");
            Console.WriteLine("1. Classic Burger - $5.99");
            Console.WriteLine("2. Cheese Burger - $6.99");
            Console.WriteLine("3. Chicken Burger - $6.49");

            // Step 2: Read user choice
            Console.Write("Enter the number of your choice: ");
            string userInput = Console.ReadLine();
            int burgerChoice = int.Parse(userInput);

            string burgerName = "";
            double burgerPrice = 0;

            if (burgerChoice == 1)
            {
                burgerName = "Classic Burger";
                burgerPrice = 5.99;
            }
            else if (burgerChoice == 2)
            {
                burgerName = "Cheese Burger";
                burgerPrice = 6.99;
            }
            else if (burgerChoice == 3)
            {
                burgerName = "Chicken Burger";
                burgerPrice = 6.49;
            }
            else
            {
                Console.WriteLine("❌ Invalid burger choice.");
                return;
            }

            // Step 3: Ask for add-ons
            Console.WriteLine("\nWould you like to add anything?");
            Console.WriteLine("A. Fries - $2.49");
            Console.WriteLine("B. Soft Drink - $1.99");
            Console.WriteLine("C. Extra Cheese - $0.99");

            Console.Write("Enter your add-ons (A,B,C), or leave empty to skip: ");
            string addonInput = Console.ReadLine();
            string[] addons = addonInput.ToUpper().Split(',');

            double total = burgerPrice;
            List<string> orderItems = new List<string>();
            orderItems.Add(burgerName);

            foreach (string addon in addons)
            {
                string a = addon.Trim();
                if (a == "A")
                {
                    orderItems.Add("Fries");
                    total += 2.49;
                }
                else if (a == "B")
                {
                    orderItems.Add("Soft Drink");
                    total += 1.99;
                }
                else if (a == "C")
                {
                    orderItems.Add("Extra Cheese");
                    total += 0.99;
                }
                else if (a != "")
                {
                    Console.WriteLine($"⚠️ Unknown add-on: {a}");
                }
            }

            // Step 4: Show summary
            Console.WriteLine("\n🧾 Order Summary:");
            foreach (string item in orderItems)
            {
                Console.WriteLine("- " + item);
            }

            Console.WriteLine($"Total Price: ${total:F2}");

            // Step 5: Confirm
            Console.Write("\nConfirm your order? (Y/N): ");
            char confirm = Convert.ToChar(Console.ReadLine().ToUpper());

            if (confirm == 'Y')
            {
                Console.WriteLine("✅ Your order is confirmed! Enjoy your meal 🍔");
            }
            else
            {
                Console.WriteLine("❌ Order canceled.");
            }
        }
    }
}
