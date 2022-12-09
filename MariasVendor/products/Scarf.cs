using System;
namespace MariasVendor.products
{
	public class Scarf : Product
    {
		public Scarf() : base("Scarf", "Cashmere scarf black, unisex", 40, ProductType.Wearable) { }

        public override void Use()
        {
            Console.WriteLine("Wear the scarf");
        }

    }
}

