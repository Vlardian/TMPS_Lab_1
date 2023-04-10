using System;
namespace TMPS_Prototype_Pattern
{
	abstract class Report
	{
		public string Id_troleibuz;
		public string Culoare;
		public string Sofer;

		public abstract void DisplayInfo();

		public abstract Report Clone();
	}
}

