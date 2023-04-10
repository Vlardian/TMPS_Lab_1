using System;

namespace TMPS_Factory_Pattern
{
	class LaptopFactory : ComputerFactory
	{
        public override Computer Create(string procesor, string videocard, string ram)
        {
            Laptop laptop = new Laptop(procesor,videocard,ram);

            return laptop;
        }
    }
}

