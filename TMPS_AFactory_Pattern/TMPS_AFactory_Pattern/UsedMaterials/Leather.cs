using System;
namespace TMPS_AFactory_Pattern.UsedMaterials
{
	class Leather : ChooseMaterial
	{
		public Leather()
		{
            Length = 5;
            Width = 10;
		}

        public override void UsedMaterial()
        {
            Console.WriteLine($"The length of the material: {Length} cm");
            Console.WriteLine($"The width of the material: {Width} cm");
        }
    }
}

