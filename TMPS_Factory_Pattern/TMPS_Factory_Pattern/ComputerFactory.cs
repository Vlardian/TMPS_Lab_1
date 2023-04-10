using System;
namespace TMPS_Factory_Pattern
{
	abstract class ComputerFactory
	{
		public abstract Computer Create(string procesor, string videocard, string ram);
	}
}

