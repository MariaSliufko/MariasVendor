using System;
namespace MariasVendor.products
{
	public class Poncho : Product
    {
        public Poncho() : base("Poncho", "Reusable waterproof poncho. Unisex, black.", 40, ProductType.Wearable) { }

        public override void Use()
        {
            Console.WriteLine("Wear the poncho");
        }
    }
}

