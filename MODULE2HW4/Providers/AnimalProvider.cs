using MODULE2HW4.Enums;
using MODULE2HW4.Models;
using MODULE2HW4.Models.Cats;

namespace MODULE2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public AnimalProvider()
        {
            Animals = new Animal[]
            {
                new Lion
                {
                    TypeOfAnimal = TypeOfAnimal.Lion,
                    Weight = new Weight(150),
                    Name = "Oleg",
                    IsMale = true,
                    Color = Color.Orange
                },
                new Tiger
                {
                    TypeOfAnimal = TypeOfAnimal.Tiger,
                    Weight = new Weight(100),
                    Name = "Anton",
                    IsMale = true,
                    Color = Color.Orange,
                },
                new Lion
                {
                    TypeOfAnimal = TypeOfAnimal.Lion,
                    Weight = new Weight(100),
                    Name = "Oleg",
                    IsMale = true,
                    Color = Color.Orange,
                },
                new PumaConcolor
                {
                    TypeOfAnimal = TypeOfAnimal.Puma,
                    Weight = new Weight(50),
                    Name = "Marina",
                    IsMale = false,
                    Color = Color.Multicolored,
                }
            };
        }

        public Animal[] Animals { get; }
    }
}