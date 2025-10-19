using OldMacDonald.UserInput.Farm;

class Program
{
    static void Main()
    {
        var farm = new Farm();
        farm.LoadDefaultAnimals();
        farm.AddCustomAnimals();
        farm.SingFarmSong();
    }
}
