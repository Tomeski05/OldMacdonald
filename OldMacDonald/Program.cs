//// DATA DRIVEN APPROACH - Solution 1

//public class Program
//{
//    static void Main()
//    {
//        List<AnimalData> animals = new List<AnimalData>
//        {
//            new AnimalData { Name = "cow", Sound = "moo" },
//            new AnimalData { Name = "dog", Sound = "woof" },
//            new AnimalData { Name = "cat", Sound = "meow" },
//            new AnimalData { Name = "pig", Sound = "oink" },
//            new AnimalData { Name = "duck", Sound = "quack" }
//        };

//        foreach (var animal in animals)
//        {
//            PrintSong(animal);
//            Console.WriteLine();
//        }
//    }

//    static void PrintSong(AnimalData animal)
//    {
//        string name = animal.Name;
//        string sound = animal.Sound;

//        Console.WriteLine("Old MacDonald had a farm, E I E I O");
//        Console.WriteLine($"And on his farm he had a {name}, E I E I O");
//        Console.WriteLine($"With a {sound} {sound} here and a {sound} {sound} there,");
//        Console.WriteLine($"Here a {sound}, there a {sound}, ev'rywhere a {sound} {sound}");
//        Console.WriteLine("Old MacDonald had a farm, E I E I O");
//    }
//}

//class AnimalData
//{
//    public string Name { get; set; }
//    public string Sound { get; set; }
//}








//// POLYMORPHISM APPROACH - Solution 2

class Program
{
    static void Main()
    {
        var farm = new Farm();
        farm.LoadDefaultAnimals();
        farm.SingSong();
    }
}





//// Question 4 - Translation

// Za da se iskreira makedonska verzija, celiot tekst ke go dodadam vo eksterni fajlovi (.resx) za da nema hardkodirani nizi vo kodot.
//Bi kreiral po edna datoteka za sekoj jazik kako Strings.en.resx, Strings.mk.resx
// So toa sekoj bi mozel da gi editira datotekite bez da ima dopir so kodot
// Za vreme na izvrsuvanje, aplikacijata go vcituva tocniot jazik koristejki go sistem za lokalizacija na .NET