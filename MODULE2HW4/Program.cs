using MODULE2HW4.Enums;
using MODULE2HW4.Helpers;
using MODULE2HW4.Models.Cats;
using MODULE2HW4.Providers;
using MODULE2HW4.Services;

namespace MODULE2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AnimalProvider animalProvider = new AnimalProvider();
            SectionServicec sectionService = new SectionServicec();
            sectionService.Add(animalProvider.Animals[0]);
            sectionService.Add(animalProvider.Animals[1]);
            sectionService.Add(animalProvider.Animals[2]);
            sectionService.Add(animalProvider.Animals[3]);
            Finder.FindbyName(sectionService.Get(), "Oleg");
            Finder.FindAmountOfAnimalTypes(sectionService.Get(), TypeOfAnimal.Lion);
        }
    }
}