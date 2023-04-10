using System;

namespace TMPS_Prototype_Pattern;

class TroleibuzReader
{
	public static Troleibuz ReadTroleibuz()
	{
		Troleibuz troleibuz = new Troleibuz();

		troleibuz.Id_troleibuz = Guid.NewGuid().ToString().Substring(0, 6);
		troleibuz.Culoare = "Albastru";
		troleibuz.Sofer = "Petru";

		return troleibuz;
	}
}

