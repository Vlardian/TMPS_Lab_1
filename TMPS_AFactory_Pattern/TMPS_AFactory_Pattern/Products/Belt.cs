using System;

namespace TMPS_AFactory_Pattern.Products
{
	class Belt : ChooseProdcut
    { 
		public Belt()
		{
			Name = "Petru";
		}

		public override void CreateProduct()
		{
			Console.WriteLine($"Your name on the product: {Name}");
		}
	}
}


