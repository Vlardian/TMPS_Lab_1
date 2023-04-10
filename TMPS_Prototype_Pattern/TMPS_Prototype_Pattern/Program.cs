using TMPS_Prototype_Pattern;

namespace Patterns;

public class Prgram
{
    static void Main(string[] args)
    {
        Troleibuz troleibuz_1 = TroleibuzReader.ReadTroleibuz();
        troleibuz_1.DisplayInfo();

        Troleibuz troleibuz_2 = (Troleibuz)troleibuz_1.Clone();
        troleibuz_2.Sofer = "Anatolie";
        troleibuz_2.DisplayInfo();
    }
}