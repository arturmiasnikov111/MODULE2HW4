using MODULE2HW4.Enums;

namespace MODULE2HW4.Models
{
    public abstract class Animal
    {
        public Weight Weight { get; init; }

        public TypeOfAnimal TypeOfAnimal { get; init; }

        public string Name { get; init; }

        public bool IsMale { get; init; }

        public Color Color { get; init; }

        public abstract bool IsDangerousToOtherAnimals { get; init; }

        public bool HasTail { get; init; }
        public TypeOfSound TypeOfSound { get; init; }
    }
}