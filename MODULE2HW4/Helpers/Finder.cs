using System;
using MODULE2HW4.Enums;
using MODULE2HW4.Models;

namespace MODULE2HW4.Helpers
{
    public static class Finder
    {
        public static Animal[] FindbyName(this Animal[] animals, string name)
        {
            int capacity = 0;
            int index = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].Name == name)
                {
                    capacity++;
                }
            }

            Animal[] animalsFinder = new Animal[capacity];

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].Name == name)
                {
                    animalsFinder[index] = animals[i];
                    index++;
                }
            }

            foreach (var item in animalsFinder)
            {
                Console.WriteLine(
                    $"Animal with Name: {item.Name}, has these stats: Weight: {item.Weight.AnimalWeight}, isMale: {item.IsMale}");
            }

            return animalsFinder;
        }

        public static void FindAmountOfAnimalTypes(Animal[] animals, TypeOfAnimal typeOfAnimal)
        {
            int counter = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].TypeOfAnimal == typeOfAnimal)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Amount of Type {typeOfAnimal} has been found: {counter}");
        }
    }
}