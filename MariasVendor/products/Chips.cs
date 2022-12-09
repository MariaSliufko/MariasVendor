using System;
namespace MariasVendor.products
{
	public class Chips : Product
    {
        public Chips() : base("Chips", "Thin slices of potato that has been deep fried until crunchy with salt.", 25, ProductType.Snack) { }

        public override void Use()
        {
            Console.WriteLine("Eat your chips");
        }
    }
}

