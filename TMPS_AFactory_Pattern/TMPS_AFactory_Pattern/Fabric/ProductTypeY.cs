using System;
using TMPS_AFactory_Pattern.Products;
using TMPS_AFactory_Pattern.UsedMaterials;

namespace TMPS_AFactory_Pattern.Fabric
{
	class ProductTypeY : IProductType
	{
        public ChooseMaterial GetMaterial()
        {
            return new Textil();
        }

        public ChooseProdcut GetProdcut()
        {
            return new Belt();
        }
    }
}

