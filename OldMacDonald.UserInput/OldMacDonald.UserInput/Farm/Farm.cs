using OldMacDonald.UserInput.Animals;

namespace OldMacDonald.UserInput.Farm;

public class Farm
{
    private readonly List<IAnimal> animals = new();

    public void LoadDefaultAnimals()
    {
        animals.AddRange(new IAnimal[]
        {
            new Cow(), new Duck(), new Pig(), new Sheep(), new Dog(),
            new Cat(), new Horse(), new Chicken(), new Frog(), new Goat(),
            new Rooster(), new Bee(), new Owl(), new Turkey(), new Donkey()
        });
    }

    public void AddCustomAnimals()
    {
        int count = UserInputHandler.PositiveNumber("How many animals would you like to add? ");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nAnimal #{i + 1}");
            string name = UserInputHandler.OnlyLetters("Enter animal name: ");
            string sound = UserInputHandler.OnlyLetters($"Enter the sound that the {name} makes: ");
            animals.Add(new CustomAnimal(name.ToLower(), sound.ToLower()));
        }
    }

    public void SingFarmSong()
    {
        foreach (var animal in animals)
        {
            animal.SingSong();
            Console.WriteLine();
        }
    }
}
