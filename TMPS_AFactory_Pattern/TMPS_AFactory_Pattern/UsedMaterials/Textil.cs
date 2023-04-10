using System;
namespace TMPS_AFactory_Pattern.UsedMaterials
{
	class Textil : ChooseMaterial
	{
		public Textil()
		{
			Length = 10;
			Width = 15;
		}

        public override void UsedMaterial()
        {
            Console.WriteLine($"The length of the material: {Length} cm");
            Console.WriteLine($"The width of the material: {Width} cm");
        }
    }
}

