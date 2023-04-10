using System;
namespace TMPS_Factory_Pattern
{
	class PCFactory : ComputerFactory
	{
        public override Computer Create(string procesor, string videocard, string ram)
        {
            PC pc = new PC(procesor, videocard, ram);

            return pc;
        }
    }
}

