using OldMacDonald.UserInput.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.UserInput.Animals
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; }
        public string Sound { get; }

        protected Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public virtual void SingSong()
        {
            Console.WriteLine("Old MacDonald had a farm, E I E I O");
            Console.WriteLine($"And on his farm he had a {Name}, E I E I O.");
            Console.WriteLine($"With a {Sound} {Sound} here and a {Sound} {Sound} there,");
            Console.WriteLine($"Here a {Sound}, there a {Sound}, ev'rywhere a {Sound} {Sound}");
            Console.WriteLine("Old MacDonald had a farm, E I E I O.");
        }
    }
}