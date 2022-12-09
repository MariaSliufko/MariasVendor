using System;
namespace MariasVendor.products
{
	public class Water : Product
    {
        public Water() : base("Water", "Evian still water contains natural drinking water from the French Alps. " +
            "It quench your thirst with pure naturally filtered water.", 15, ProductType.Liquid) { }

        public override void Use()
        {
            Console.WriteLine("Drink youre water");
        }
    }
}

