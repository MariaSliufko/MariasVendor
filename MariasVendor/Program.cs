using System;
using System.Collections.Generic;
using MariasVendor;
using MariasVendor.products;

namespace MariasVendor
{
    class Program
    {
        static Wallet wallet = new Wallet(10, 10, 10); // Customer wallet
        static List<Product> products = new List<Product>(); // List of products
        static int machineBalance = 0; // Machine balance


        static void Main(string[] args)
        {
            // Init products
            products.Add(new CocaCola()); //adds each object to the end of the list
            products.Add(new Sprite());
            products.Add(new Water());

            products.Add(new Chips());
            products.Add(new Snickers());
            products.Add(new WasaSandwich());

            products.Add(new Gloves());
            products.Add(new Poncho());
            products.Add(new Scarf());

            // Print main menu
            PrintMainMenu();
        }

        // Print main menu
        static void PrintMainMenu()
        {
            // Clear console
            Console.Clear();

            // Print menu
            Console.WriteLine("Welcome to the vending machine!");
            Console.WriteLine("");
            Console.WriteLine("You have " + wallet.GetTotal() + "kr in your wallet.");
            Console.WriteLine("The machine has " + machineBalance + "kr in it.");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Buy a product");
            Console.WriteLine("2. Add money to the machine");
            Console.WriteLine("3. Return change");
            Console.WriteLine("4. Exit");

            // Get user input
            string input = Console.ReadLine();

            // Check user input and prints diffrent cases
            switch (input)
            {
                case "1":
                    PrintProductMenu();
                    break;
                case "2":
                    PrintAddMoneyMenu();
                    break;
                case "3":
                    ReturnChange();
                    break;
                case "4":
                    // Check if user has any change
                    if (machineBalance > 0) { ReturnChange(true); }
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input, press any key to try again"); //if not correct input
                    Console.ReadKey();
                    PrintMainMenu();
                    break;
            }
        }

        // Print add money menu
        static void PrintAddMoneyMenu()
        {
            // Clear console
            Console.Clear();

            // Print menu
            Console.WriteLine("Machine balance: " + machineBalance + "kr");
            Console.WriteLine("Your wallet: " + wallet.GetTotal() + "kr");
            Console.WriteLine("");
            Console.WriteLine("How much money would you like to add?");
            Console.WriteLine("1. 1kr   (" + wallet.enkroner + " st)");
            Console.WriteLine("2. 5kr   (" + wallet.femkroner + " st)");
            Console.WriteLine("3. 10kr  (" + wallet.tiokroner + " st)");
            Console.WriteLine("4. 20kr  (" + wallet.tjugolappar + " st)");
            Console.WriteLine("5. 50kr  (" + wallet.femtiolappar + " st)");
            Console.WriteLine("6. 100kr (" + wallet.hundralappar + " st)");
            Console.WriteLine("7. Go back");

            // Get user input
            string input = Console.ReadLine();

            // Check user input
            switch (input)
            {
                case "1":
                    // Check if user has enough money
                    if (wallet.enkroner <= 0)
                    {
                        Console.WriteLine("You don't have any 1kr coins, press any key to try again");
                        Console.ReadKey();
                        PrintAddMoneyMenu();
                        break;
                    }

                    wallet.enkroner--;
                    machineBalance++;
                    Console.WriteLine("You added 1kr to the machine, press any key to continue");
                    PrintAddMoneyMenu();
                    break;
                case "2":
                    // Check if user has enough money
                    if (wallet.femkroner <= 0)
                    {
                        Console.WriteLine("You don't have any 5kr coins, press any key to try again");
                        Console.ReadKey();
                        PrintAddMoneyMenu();
                        break;
                    }

                    wallet.femkroner--;
                    machineBalance += 5;
                    Console.WriteLine("You added 5kr to the machine, press any key to continue");
                    PrintAddMoneyMenu();
                    break;
                case "3":
                    // Check if user has enough money
                    if (wallet.tiokroner <= 0)
                    {
                        Console.WriteLine("You don't have any 10kr coins, press any key to try again");
                        Console.ReadKey();
                        PrintAddMoneyMenu();
                        break;
                    }

                    wallet.tiokroner--;
                    machineBalance += 10;
                    Console.WriteLine("You added 10kr to the machine, press any key to continue");
                    PrintAddMoneyMenu();
                    break;
                case "4":
                    // Check if user has enough money
                    if (wallet.tjugolappar <= 0)
                    {
                        Console.WriteLine("You don't have any 20kr bills, press any key to try again");
                        Console.ReadKey();
                        PrintAddMoneyMenu();
                        break;
                    }

                    wallet.tjugolappar--;
                    machineBalance += 20;
                    Console.WriteLine("You added 20kr to the machine, press any key to continue");
                    PrintAddMoneyMenu();
                    break;
                case "5":
                    // Check if user has enough money
                    if (wallet.femtiolappar <= 0)
                    {
                        Console.WriteLine("You don't have any 50kr bills, press any key to try again");
                        Console.ReadKey();
                        PrintAddMoneyMenu();
                        break;
                    }

                    wallet.femtiolappar--;
                    machineBalance += 50;
                    Console.WriteLine("You added 50kr to the machine, press any key to continue");
                    PrintAddMoneyMenu();
                    break;
                case "6":
                    // Check if user has enough money
                    if (wallet.hundralappar <= 0)
                    {
                        Console.WriteLine("You don't have any 100kr bills, press any key to try again");
                        Console.ReadKey();
                        PrintAddMoneyMenu();
                        break;
                    }

                    wallet.hundralappar--;
                    machineBalance += 100;
                    Console.WriteLine("You added 100kr to the machine, press any key to continue");
                    PrintAddMoneyMenu();
                    break;
                case "7":
                    PrintMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input, press any key to try again");
                    Console.ReadKey();
                    PrintAddMoneyMenu();
                    break;
            }
        }

        // Print product menu
        static void PrintProductMenu()
        {
            // Clear console
            Console.Clear();

            // Print menu
            Console.WriteLine("What would you like to buy?");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + products[i].type + " - " + products[i].name + " - " + products[i].price + "kr");
            }
            Console.WriteLine(products.Count + 1 + ". Go back");

            // Get user input
            string input = Console.ReadLine();

            // Check if user input is a number
            if (int.TryParse(input, out int index))
            {
                // Check if user input is a valid product
                if (index > 0 && index <= products.Count)
                {
                    // Print product info
                    PrintProductInfo(index - 1);
                }
                else if (index == products.Count + 1)
                {
                    // Go back to main menu
                    PrintMainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input, press any key to try again");
                    Console.ReadKey();
                    PrintProductMenu();
                }
            }
            else
            {
                Console.WriteLine("Invalid input, press any key to try again");
                Console.ReadKey();
                PrintProductMenu();
            }

        }

        // Print product info
        static void PrintProductInfo(int index)
        {
            // Clear console
            Console.Clear();

            // Print info
            Console.WriteLine("Machine ballance: " + machineBalance + "kr");
            Console.WriteLine("");
            Console.WriteLine(products[index].name);
            Console.WriteLine(products[index].description);
            Console.WriteLine("Price: " + products[index].price + "kr");
            Console.WriteLine("");
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Go back");

            // Get user input
            string input = Console.ReadLine();

            // Check user input
            switch (input)
            {
                case "1":
                    machineBalance = products[index].Buy(machineBalance);
                    Console.ReadKey();
                    PrintProductInfo(index);
                    break;
                case "2":
                    PrintProductMenu();
                    break;
                default:
                    System.Console.WriteLine("Invalid input, press any key to try again");
                    Console.ReadKey();
                    PrintProductInfo(index);
                    break;
            }
        }

        // Return change
        static void ReturnChange(bool exitAfterChange = false)
        {
            // Clear console
            Console.Clear();

            // Check if machine has enough money
            if (machineBalance <= 0)
            {
                Console.WriteLine("No change to return, press any key to continue");
                Console.ReadKey();
                PrintMainMenu();
                return;
            }

            // Return change
            int enkroner = 0;
            int femkroner = 0;
            int tiokroner = 0;
            int tjugolappar = 0;
            int femtiolappar = 0;
            int hundralappar = 0;

            while (machineBalance >= 100)
            {
                machineBalance -= 100;
                wallet.hundralappar++;
                hundralappar++;
            }

            while (machineBalance >= 50)
            {
                machineBalance -= 50;
                wallet.femtiolappar++;
                femtiolappar++;
            }

            while (machineBalance >= 20)
            {
                machineBalance -= 20;
                wallet.tjugolappar++;
                tjugolappar++;
            }

            while (machineBalance >= 10)
            {
                machineBalance -= 10;
                wallet.tiokroner++;
                tiokroner++;
            }
            while (machineBalance >= 5)
            {
                machineBalance -= 5;
                wallet.femkroner++;
                femkroner++;
            }
            while (machineBalance >= 1)
            {
                machineBalance -= 1;
                wallet.enkroner++;
                enkroner++;
            }

            // Print change
            Console.WriteLine("You got total change of " + (enkroner * 1 + femkroner * 5 + tiokroner * 10 + tjugolappar * 20 + femtiolappar * 50 + hundralappar * 100) + "kr");

            if (hundralappar > 0)
            {
                System.Console.WriteLine(hundralappar + " x 100kr");
            }

            if (femtiolappar > 0)
            {
                System.Console.WriteLine(femtiolappar + " x 50kr");
            }

            if (tjugolappar > 0)
            {
                System.Console.WriteLine(tjugolappar + " x 20kr");
            }

            if (tiokroner > 0)
            {
                System.Console.WriteLine(tiokroner + " x 10kr");
            }

            if (femkroner > 0)
            {
                System.Console.WriteLine(femkroner + " x 5kr");
            }

            if (enkroner > 0)
            {
                System.Console.WriteLine(enkroner + " x 1kr");
            }

            if (!exitAfterChange)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                PrintMainMenu();
            }
        }
    }
}

