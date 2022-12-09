using System;
namespace MariasVendor.products
{
	public abstract class Product : IProduct  //abstract class that gets from interface
	{
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }

        public enum ProductType //3 types of ctegories that wont change
        {
            Liquid,
            Snack,
            Wearable
        }

        public ProductType type { get; set; }


        public Product(string name, string description, int price, ProductType type) //constructor with parameters
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.type = type;
        }

        public void Description()
        {
            System.Console.WriteLine(description); //method for description
        }

        // Returns balance after purchase
        public int Buy(int balance)
        {
            if (balance >= price) // if balance is greather then the price you buy product else you need to add money
            {
                System.Console.WriteLine("You bought " + name);
                Use();
                return balance - price;
            }
            else
            {
                System.Console.WriteLine("You need to insert more money to buy " + name + ", press any key to go back");
                return balance;
            }
        }

        public abstract void Use();
    }
}


