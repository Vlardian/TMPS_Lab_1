using TMPS_Factory_Pattern;

ComputerFactory factory = new PCFactory();

Console.WriteLine("Procesor: ");
string procesor = Console.ReadLine();

Console.WriteLine("Videocard: ");
string videocard = Console.ReadLine();

Console.WriteLine("Ram: ");
string ram = Console.ReadLine();

Computer computer = factory.Create(procesor, videocard, ram);

computer.DisplayInfo();
