using TMPS_AFactory_Pattern.Fabric;
using TMPS_AFactory_Pattern.Products;
using TMPS_AFactory_Pattern.UsedMaterials;

namespace Patterns;

class Program
{
    static void Main(string[] args)
    {
        IProductType factory = new ProductTypeX();
        //ProductTypeY - textil + belt
        //ProductTypeX - leather + wallet

        ChooseProdcut product = factory.GetProdcut();
        ChooseMaterial material = factory.GetMaterial();

        product.CreateProduct();
        material.UsedMaterial();
    }
}