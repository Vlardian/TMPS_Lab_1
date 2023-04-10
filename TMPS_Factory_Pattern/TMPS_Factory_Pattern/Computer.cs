using System;
namespace TMPS_Factory_Pattern
{
	public abstract class Computer
	{
		private string _procesor;
		private string _videoCard;
		private string _ram;

		public Computer(string procesor, string videocard, string ram)
		{
			_procesor = procesor;
			_videoCard = videocard;
			_ram = ram;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Procesor: {_procesor}");
            Console.WriteLine($"Video Card: {_videoCard}");
            Console.WriteLine($"Ram: {_ram}");
        }
	}
}

