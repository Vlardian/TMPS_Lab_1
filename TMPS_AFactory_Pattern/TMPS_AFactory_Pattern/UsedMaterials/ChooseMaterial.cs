using System;
namespace TMPS_AFactory_Pattern.UsedMaterials
{
	abstract class ChooseMaterial
	{
		public int Length { get; set; }
		public int Width { get; set; }

		public abstract void UsedMaterial();
	}
}

