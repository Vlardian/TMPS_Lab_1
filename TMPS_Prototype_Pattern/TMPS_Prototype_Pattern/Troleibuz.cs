using System;
namespace TMPS_Prototype_Pattern;

class Troleibuz : Report
{
    public override Report Clone()
    {
        Troleibuz copy = new Troleibuz();

        copy = (Troleibuz)this.MemberwiseClone();

        return copy;
    }

    public override void DisplayInfo()
    {
        string info =
            "Detalii despre troleibuz\n\n" +
            $"Id-ul troleibuzului = {Id_troleibuz}\n" +
            $"Culoarea troleibuzului = {Culoare}\n" +
            $"Soferul troleibuzului = {Sofer}\n";
            

        Console.WriteLine(info);
    }
}

