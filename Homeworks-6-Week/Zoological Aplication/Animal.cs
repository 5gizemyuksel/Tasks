using System;

namespace Zoological_Aplication;

public class Animal
{
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public virtual void MakeSound()
    {
        System.Console.WriteLine($"{Species} türündeki {Name} ses çıkarıyor.");
    }


}