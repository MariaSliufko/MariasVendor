using System;
namespace MariasVendor.products
{
	public class CocaCola : Product
    {
        public CocaCola() : base("Coca-Cola", "A carbonated soft drink with vanilla and cinnamon flavour, " +
            "with trace amounts of essential oils, and spices such as nutmeg.", 15, ProductType.Liquid) { }

        public override void Use()
        {
            Console.WriteLine("Drink youre Coca-Cola");
        }
    }
}

