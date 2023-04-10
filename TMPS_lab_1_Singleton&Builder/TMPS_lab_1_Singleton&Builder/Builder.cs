using System;

namespace Builder
{
	public class Builder
	{
		public string TipulPartidului { get; set; }
		public string DenumireaPartidului { get; set; }
		public string LiderulPartidului { get; set; }


		public void Display()
		{
			Console.WriteLine("Tipul partidului:" + TipulPartidului);
			Console.WriteLine("Denumirea partidului:" + DenumireaPartidului);
			Console.WriteLine("Liderul partidului:" + LiderulPartidului);
		}

		public abstract class AbstractClass
		{
			protected Builder Create;

			public abstract void SetTipulPartidului();
			public abstract void SetDenumireaPartidului();
			public abstract void SetLiderulPartidului();

			public void CreateNew()
			{
				Create = new Builder();
			}

			public Builder GetPartid()
			{
				return Create;
			}

			public class Partid : AbstractClass
			{
                public override void SetDenumireaPartidului()
                {
					Create.DenumireaPartidului = "PAS";
                }

                public override void SetLiderulPartidului()
                {
					Create.LiderulPartidului = "Maia Sandu";
                }
                public override void SetTipulPartidului()
                {
					Create.TipulPartidului = "Democrat";
                }
            }

			public class CreateDirector
			{
				public Builder MakeBuild(AbstractClass abstractClass)
				{
					abstractClass.CreateNew();
					abstractClass.SetDenumireaPartidului();
					abstractClass.SetTipulPartidului();
					abstractClass.SetLiderulPartidului();

					return abstractClass.GetPartid();
				}
			}
        }
	}
}

