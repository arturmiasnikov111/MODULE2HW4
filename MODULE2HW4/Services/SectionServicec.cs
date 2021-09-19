using System;
using MODULE2HW4.Models;
using MODULE2HW4.Services.Abstractions;

namespace MODULE2HW4.Services
{
    public class SectionServicec : ISectionService
    {
        private const int _sectionSize = 10;
        private int _index = 0;

        public SectionServicec()
        {
           Section = new Animal[_sectionSize];
        }

        public Animal[] Section { get; }

        public void Add(Animal animal)
        {
            Section[_index] = animal;
            _index++;
        }

        public Animal[] Get() => FillArrayWithoutNull();

        public void Print()
        {
            foreach (var item in FillArrayWithoutNull())
            {
                Console.WriteLine(
                    $"{item} Name: {item.Name}, Weight: {item.Weight.AnimalWeight}, isMale: {item.IsMale}");
            }
        }

        private Animal[] FillArrayWithoutNull()
        {
            Animal[] sectionAnimal = new Animal[_index];
            for (var i = 0; i < sectionAnimal.Length; i++)
            {
                sectionAnimal[i] = Section[i];
            }

            return sectionAnimal;
        }
    }
}