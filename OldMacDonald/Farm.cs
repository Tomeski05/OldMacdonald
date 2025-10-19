using System;
using System.Collections.Generic;
using OldMacDonald.Animals;

public class Farm
{
    private List<IAnimal> animals = new List<IAnimal>();

    public void LoadDefaultAnimals()
    {
        animals.Add(new Cow());
        animals.Add(new Duck());
        animals.Add(new Pig());
        animals.Add(new Sheep());
        animals.Add(new Dog());
    }

    public void SingSong()
    {
        foreach (var animal in animals)
        {
            animal.SingSong();
            Console.WriteLine();
        }
    }
}
