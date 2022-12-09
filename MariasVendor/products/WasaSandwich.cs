using System;
namespace MariasVendor.products
{
	public class WasaSandwich : Product
    {
        public WasaSandwich() : base("WasaSandwich", "Wholegrain flou, vegetable fat, rye flour, maltodextrin, cheese powder, buttermilk powder, flavor (milk), salt, dried chives " +
            "Skim Milk, Lactose, Milkfat", 20, ProductType.Snack)
        { }

        public override void Use()
        {
            Console.WriteLine("Eat your WasaSandwich");
        }
    }
}

