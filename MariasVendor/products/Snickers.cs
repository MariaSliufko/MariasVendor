using System;
namespace MariasVendor.products
{
	public class Snickers : Product
    {
        public Snickers() : base("Snickers", "Single size chocklate bar. Milk Chocolate (Sugar, Cocoa Butter, Chocolate, " +
            "Skim Milk, Lactose, Milkfat", 20, ProductType.Snack) { }

        public override void Use()
        {
            Console.WriteLine("Eat your Snickers");
        }
    }
}

