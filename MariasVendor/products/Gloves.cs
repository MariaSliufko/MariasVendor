using System;
namespace MariasVendor.products
{
	public class Gloves : Product
    {
        public Gloves() : base("Gloves", "Warm, trerndy black gloves. Unisex product", 40, ProductType.Wearable) { }

        public override void Use()
        {
            Console.WriteLine("Wear the gloves");
        }

    }
}

