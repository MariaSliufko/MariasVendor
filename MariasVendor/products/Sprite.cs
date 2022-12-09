using System;
namespace MariasVendor.products
{
	public class Sprite : Product
    {
        public Sprite() : base("Sprite", "A lemon and lime-flavoured soft drink\"", 15, ProductType.Liquid) { }

        public override void Use()
        {
            Console.WriteLine("Drink youre Sprite");
        }
    }
}

