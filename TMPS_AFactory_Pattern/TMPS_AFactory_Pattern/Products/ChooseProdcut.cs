using System;
namespace TMPS_AFactory_Pattern.Products
{
	abstract class ChooseProdcut
	{
		public string Name { get; set; }

		public abstract void CreateProduct();
	}
}

