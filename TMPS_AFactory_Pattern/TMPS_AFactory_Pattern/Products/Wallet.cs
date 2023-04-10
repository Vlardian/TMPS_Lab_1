using System;
namespace TMPS_AFactory_Pattern.Products
{
	class Wallet : ChooseProdcut
	{
		public Wallet()
		{
			Name = "Daniel";
		}

        public override void CreateProduct()
        {
			Console.WriteLine($"Your name on the product: {Name}");
        }
    }
}

