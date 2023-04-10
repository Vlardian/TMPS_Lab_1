using System;
using TMPS_AFactory_Pattern.Products;
using TMPS_AFactory_Pattern.UsedMaterials;

namespace TMPS_AFactory_Pattern.Fabric
{
	interface IProductType
	{
		ChooseMaterial GetMaterial();

		ChooseProdcut GetProdcut();
	}
}

