using System;
using TMPS_AFactory_Pattern.Products;
using TMPS_AFactory_Pattern.UsedMaterials;

namespace TMPS_AFactory_Pattern.Fabric
{
	class ProductTypeX : IProductType
	{
        public ChooseMaterial GetMaterial()
        {
            return new Leather();
        }

        public ChooseProdcut GetProdcut()
        {
            return new Wallet();
        }
    }
}

